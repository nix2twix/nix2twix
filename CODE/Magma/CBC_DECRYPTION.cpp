#include "MagmaRounds.h"

int main_CBC_DECRYPT()
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

    // Определение размера файла в байтах
    ifstream dataFile(ENCRYPT_PATH, ios::binary);

    dataFile.seekg(0, ios::end);
    int fileSize = dataFile.tellg();
    dataFile.seekg(0, ios::beg);

    // Считывание всех данных
    vector <unsigned char> data;
    for (int i = 0; i < fileSize; i++)
    {
        dataFile.read(&buff, sizeof(unsigned char));
        data.push_back(buff);
    }

    dataFile.close();

    /*
        Режим расшифрования простой заменой
        с зацеплением [Cipher Block Chaining]
    */

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
    ofstream decryptedFile(DECRYPT_PATH, ios::binary);

    for (int i = 0; i < fileSize / FULL_BLOCK_BYTE_SIZE; i++)
    {
        block.clear();
        block.resize(FULL_BLOCK_BYTE_SIZE);

        copy(
            data.begin() + FULL_BLOCK_BYTE_SIZE * (i),
            data.begin() + FULL_BLOCK_BYTE_SIZE * (i + 1),
            block.begin()
        );

        // Разделение блока пополам
        pair<uint64_t, uint64_t> ENCRYPTED_DATA;
        ENCRYPTED_DATA = MakePairFromBlock(block);

        L = ENCRYPTED_DATA.first;
        R = ENCRYPTED_DATA.second;

        // Расшифрование
        decryptedBlock = DecryptionBlock(key, block);

        // XOR
        for (int q = 0; q < FULL_BLOCK_BYTE_SIZE; q++)
        {
            xorBlock[q] = decryptedBlock[q] ^ IV[q];
        }

        // Сдвиг регистра в сторону старших битов
        uint64_t temp_1 = shiftRegister[2];
        uint64_t temp_2 = shiftRegister[3];

        shiftRegister[0] = temp_1;
        shiftRegister[1] = temp_2;
        shiftRegister[2] = L;
        shiftRegister[3] = R;

        IV = SplitRegister(shiftRegister);

        // reinterpret_cast применяется для приведения разных по типу указателей
        decryptedFile.write(reinterpret_cast<const char*>(xorBlock.data()), xorBlock.size());
    }

    decryptedFile.close();

    // Усечение последнего блока, если есть необходимость

    RemovePadding(DECRYPT_PATH);

    return EXIT_SUCCESS;
}
