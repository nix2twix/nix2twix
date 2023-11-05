#include "MagmaRounds.h"

int main_OFB_ENCRYPT()
{
    // ���������� �����
    ifstream keyFile(KEY_PATH, ios::binary);
    vector <unsigned char> key;

    char buff;

    for (int i = 0; i < FULL_KEY_BYTE_SIZE; i++)
    {
        keyFile.read(&buff, sizeof(unsigned char));
        key.push_back(buff);
    }

    // ����������� ������� ����� � ������� � ������
    ifstream dataFile(DATA_PATH, ios::binary);

    dataFile.seekg(0, ios::end);
    int fileSize = dataFile.tellg();
    dataFile.seekg(0, ios::beg);

    vector <unsigned char> data;
    for (int i = 0; i < fileSize; i++)
    {
        dataFile.read(&buff, sizeof(unsigned char));
        data.push_back(buff);
    }
    dataFile.close();

    /*
        ����� ������������ � �������� ������
        �� ������ [Output Feedback]
    */

    int S = fileSize % FULL_BLOCK_BYTE_SIZE;

    // ��������� �������������

    vector<unsigned char> IV = GenerateSinchrosign();

    // ���������� �������� ������ ��������� �������������

    vector<uint64_t> shiftRegister(M / 8);

    shiftRegister = MakeRegister(IV);

    // ������ ��� �������� ������������� ������

    vector <unsigned char> block(FULL_BLOCK_BYTE_SIZE);

    vector <unsigned char> encryptedBlock(FULL_BLOCK_BYTE_SIZE);

    vector<unsigned char> xorBlock(FULL_BLOCK_BYTE_SIZE, 0);

    uint64_t L, R;

    // ���������� �����, ����������� �� ����� �����

    int blockCount = 
        (fileSize % FULL_BLOCK_BYTE_SIZE == 0) 
        ? fileSize / FULL_BLOCK_BYTE_SIZE 
        : fileSize / FULL_BLOCK_BYTE_SIZE + 1;

    ofstream encryptedFile(ENCRYPT_PATH, ios::binary);

    for (int i = 0; i < blockCount; i++)
    {
        // ���������� �����
        vector <unsigned char> gamma = EncryptionBlock(key, IV);

        // ���������� ����� �������
        pair<uint64_t, uint64_t> ENCRYPTED_GAMMA;
        ENCRYPTED_GAMMA = MakePairFromBlock(gamma);

        L = ENCRYPTED_GAMMA.first;
        R = ENCRYPTED_GAMMA.second;

        // ����� �������� � ������� ������� �����
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
                data.begin() + FULL_BLOCK_BYTE_SIZE * (i) + (S),
                block.begin()
            );
        }
        // XOR
        for (int q = 0; q < block.size(); q++)
        {
            xorBlock[q] = block[q] ^ gamma[q];
        }

        // reinterpret_cast ����������� ��� ���������� ������ �� ���� ����������
        encryptedFile.write(reinterpret_cast<const char*>(xorBlock.data()), block.size());
    }

    encryptedFile.close();
    return EXIT_SUCCESS;
}
