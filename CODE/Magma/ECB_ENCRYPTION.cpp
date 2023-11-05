#include "MagmaRounds.h"

int main_ECB_ENCRYPT()
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

    ifstream dataFile(DATA_PATH, ios::binary);
    vector <unsigned char> data;

    for (int i = 0; i < FULL_BLOCK_BYTE_SIZE; i++)
    {
        dataFile.read(&buff, sizeof(unsigned char));
        data.push_back(buff);
    }

    auto encryptedData = EncryptionBlock(key, data);

    ofstream encryptedFile(OUTPUT_PATH, ios::binary);
    encryptedFile.write(reinterpret_cast<const char*>(encryptedData.data()), encryptedData.size());

    return EXIT_SUCCESS;
}
