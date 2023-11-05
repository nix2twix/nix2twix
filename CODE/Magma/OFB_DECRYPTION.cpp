#include "MagmaRounds.h"

int main_OFB_DECRYPT()
{
    // Считывание ключа
    ifstream keyFile(KEY_PATH, ios::binary);
    vector <unsigned char> key;

    char buff;

    for (int i = 0; i < FULL_KEY_BYTE_SIZE; i++)
    {
        keyFile.read(&buff, sizeof(unsigned char));
        key.push_back(buff);
    }

    ifstream dataFile(ENCRYPT_PATH, ios::binary);
    vector <unsigned char> data;

    // Определение размера файла в байтах
    dataFile.seekg(0, ios::end);
    int fileSize = dataFile.tellg();
    dataFile.seekg(0, ios::beg);

    // Считывание всех данных

    for (int i = 0; i < fileSize; i++)
    {
        dataFile.read(&buff, sizeof(unsigned char));
        data.push_back(buff);
    }

    dataFile.close();

    /*
        Режим гаммирования с обратной связью
        по выходу [Output Feedback]
    */

    int S = fileSize % FULL_BLOCK_BYTE_SIZE;

    // Считывание использованной при шифровании синхропосылки
    ifstream sinchrosignFile(SINCHROSIGN_PATH, ios::binary);
    vector<unsigned char> IV;

    for (int i = 0; i < M; i++)
    {
        sinchrosignFile.read(&buff, sizeof(unsigned char));
        IV.push_back(buff);
    }
    sinchrosignFile.close();

    // Заполнение регистра сдвига значением синхропосылки
    vector<uint64_t> shiftRegister(4);

    shiftRegister = MakeRegister(IV);

    // Буферы для хранения промежуточных данных

    vector <unsigned char> block(FULL_BLOCK_BYTE_SIZE);

    vector <unsigned char> decryptedBlock(FULL_BLOCK_BYTE_SIZE);

    vector<unsigned char> xorBlock(FULL_BLOCK_BYTE_SIZE, 0);

    uint64_t L, R;

    // Расшифрование файла, разделённого на блоки

    int blockCount =
        (fileSize % FULL_BLOCK_BYTE_SIZE == 0)
        ? fileSize / FULL_BLOCK_BYTE_SIZE
        : fileSize / FULL_BLOCK_BYTE_SIZE + 1;

    ofstream decryptedFile(DECRYPT_PATH, ios::binary);

    for (int i = 0; i < blockCount; i++)
    {
        // Шифрование гаммы
        vector <unsigned char> gamma = EncryptionBlock(key, IV);

        // Разделение блока пополам
        pair<uint64_t, uint64_t> ENCRYPTED_GAMMA;
        ENCRYPTED_GAMMA = MakePairFromBlock(gamma);

        L = ENCRYPTED_GAMMA.first;
        R = ENCRYPTED_GAMMA.second;

        // Сдвиг регистра в сторону старших битов
        uint64_t temp_1 = shiftRegister[2];
        uint64_t temp_2 = shiftRegister[3];

        shiftRegister[0] = temp_1;
        shiftRegister[1] = temp_2;
        shiftRegister[2] = L;
        shiftRegister[3] = R;

        IV.clear();
        IV.resize(M);
        IV = SplitRegister(shiftRegister);

        block.clear();

        if (FULL_BLOCK_BYTE_SIZE * (i + 1) <= data.size())
        {
            block.resize(FULL_BLOCK_BYTE_SIZE);
            copy(
                data.begin() + FULL_BLOCK_BYTE_SIZE * (i),
                data.begin() + FULL_BLOCK_BYTE_SIZE * (i + 1),
                block.begin()
            );
        }
        else
        {
            block.resize(S);
            copy(
                data.begin() + FULL_BLOCK_BYTE_SIZE * (i),
                data.begin() + FULL_BLOCK_BYTE_SIZE * (i)+(S),
                block.begin()
            );
        }
        // XOR
        for (int q = 0; q < block.size(); q++)
        {
            xorBlock[q] = block[q] ^ gamma[q];
        }

        // reinterpret_cast применяется для приведения разных по типу указателей
        decryptedFile.write(reinterpret_cast<const char*>(xorBlock.data()), block.size());
    }

    decryptedFile.close();

    return EXIT_SUCCESS;
}
