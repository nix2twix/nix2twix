#include "MagmaRounds.h"

int main_n()
{
    // —читывание ключа
    ifstream keyFile(KEY_PATH, ios::binary);
    vector <unsigned char> key;

    char buff;

    for (int i = 0; i < FULL_KEY_BYTE_SIZE; i++)
    {
        keyFile.read(&buff, sizeof(unsigned char));
        key.push_back(buff);
    }

    ifstream dataFile(DATA_PATH, ios::binary);
    vector <unsigned char> data;

    // —читывание блока данных

    for (int i = 0; i < FULL_BLOCK_BYTE_SIZE; i++)
    {
        dataFile.read(&buff, sizeof(unsigned char));
        data.push_back(buff);
    }

    EncryptionBlock(key, data);

    return EXIT_SUCCESS;
}
