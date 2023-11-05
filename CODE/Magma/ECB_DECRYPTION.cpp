#include "MagmaRounds.h"

int main_ECB_DECRYPT()
{
    /* ДЛЯ ОДНОГО БЛОКА ДАННЫХ */

    // Считывание ключа
    ifstream keyFile(KEY_PATH, ios::binary);
    vector <unsigned char> key;

    char buff;

    for (int i = 0; i < FULL_KEY_BYTE_SIZE; i++)
    {
        keyFile.read(&buff, sizeof(unsigned char));
        key.push_back(buff);
    }

    // Считывание блока данных

    ifstream dataFile(OUTPUT_PATH, ios::binary);
    vector <unsigned char> data;

    for (int i = 0; i < FULL_BLOCK_BYTE_SIZE; i++)
    {
        dataFile.read(&buff, sizeof(unsigned char));
        data.push_back(buff);
    }

    auto decryptedData = DecryptionBlock(key, data);

    ofstream decryptedFile(OUTPUT_PATH, ios::binary);
    decryptedFile.write(reinterpret_cast<const char*>(decryptedData.data()), decryptedData.size());

    return EXIT_SUCCESS;
}
