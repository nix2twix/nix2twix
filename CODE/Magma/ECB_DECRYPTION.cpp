#include "MagmaRounds.h"

int main_n2()
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

    ifstream dataFile(OUTPUT_PATH, ios::binary);
    vector <unsigned char> data;

    // ���������� ����� ������

    for (int i = 0; i < FULL_BLOCK_BYTE_SIZE; i++)
    {
        dataFile.read(&buff, sizeof(unsigned char));
        data.push_back(buff);
    }


    DecryptionBlock(key, data);

    return EXIT_SUCCESS;
}
