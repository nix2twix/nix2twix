#include "MagmaRounds.h"

int main2()
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

    vector <unsigned char> data;

    // ����������� ������� ����� � ������
    ifstream dataFile(DATA_PATH, ios::binary);

    dataFile.seekg(0, ios::end);
    int fileSize = dataFile.tellg();
    dataFile.seekg(0, ios::beg);

    dataFile.close();

    // ���������� ���������� ����� ��� �������������

    int padCount = Padding(fileSize, DATA_PATH);

    // ���������� ������
    dataFile.open(DATA_PATH, ios::binary);
    for (int i = 0; i < fileSize + padCount; i++)
    {
        dataFile.read(&buff, sizeof(unsigned char));
        data.push_back(buff);
    }

    dataFile.close();


    /*
        ����� ���������� ������� �������
        � �����������[Cipher Block Chaining]
    */

    vector<unsigned char> IV(SINCHROSIGN.begin(), SINCHROSIGN.end());

    vector<uint64_t> shiftRegister(4);

    // ���������� �������� ������ ��������� �������������

    shiftRegister = MakeRegister(IV);

    // ������ ��� �������� ������������� ������

    vector <unsigned char> block(FULL_BLOCK_BYTE_SIZE);

    vector <unsigned char> encryptedBlock(FULL_BLOCK_BYTE_SIZE);

    vector<unsigned char> xorBlock(FULL_BLOCK_BYTE_SIZE, 0);

    uint64_t L, R;

    // ���������� �����, ����������� �� �����

    for (int i = 0; i < (fileSize + padCount) / FULL_BLOCK_BYTE_SIZE; i++)
    {
        ofstream encryptedFile(OUTPUT_PATH, ios::binary | ios::app);

        block.clear();
        block.resize(FULL_BLOCK_BYTE_SIZE);

        copy(
            data.begin() + FULL_BLOCK_BYTE_SIZE * (i),
            data.begin() + FULL_BLOCK_BYTE_SIZE * (i + 1),
            block.begin()
        );

        // ����������
        for (int q = 0; q < FULL_BLOCK_BYTE_SIZE; q++)
        {
            xorBlock[q] = block[q] ^ IV[q];
        }

        // ����������
        encryptedBlock = EncryptionBlock(key, xorBlock);

        // ���������� ����� �������
        pair<uint64_t, uint64_t> ENCRYPTED_DATA;
        ENCRYPTED_DATA = MakePairFromBlock(encryptedBlock);

        L = ENCRYPTED_DATA.first;
        R = ENCRYPTED_DATA.second;

        // ����� �������� � ������� ������� �����
        uint64_t temp_1 = shiftRegister[2];
        uint64_t temp_2 = shiftRegister[3];

        shiftRegister[0] = temp_1;
        shiftRegister[1] = temp_2;
        shiftRegister[2] = L;
        shiftRegister[3] = R;

        IV = SplitRegister(shiftRegister);

        // reinterpret_cast ����������� ��� ���������� ������ �� ���� ����������
        encryptedFile.write(reinterpret_cast<const char*>(encryptedBlock.data()), encryptedBlock.size());
    }

    return EXIT_SUCCESS;
}
