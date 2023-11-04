#pragma once
#include "MagmaFunctions.h"

inline pair<uint64_t, uint64_t> EncryptionRound(uint64_t& subKey, uint64_t& L, uint64_t& R)
{
    // Сохранение начального значения младшей части блока
    uint64_t Rtemp = R;

    R = R + subKey;

    // Разделение на S-подблоки по 4 бита

    vector<char> subBlocks(FULL_BLOCK_BYTE_SIZE, 0);

    for (int i = 0; i < FULL_BLOCK_BYTE_SIZE; i++)
    {
        subBlocks[i] = (R >> (4 * (15 - i))) & 0x0F;

        // Замена по таблице
        subBlocks[i] = ReplacementTable[i][subBlocks[i]];

    }

    // Запись результата замены в правую часть блока
    R = 0;

    for (int i = 0; i < FULL_BLOCK_BYTE_SIZE; i++)
    {
        R = R | (static_cast<uint64_t>(subBlocks[i]) << (4 * (15 - i)));
    }

    // Циклический сдвиг на 11 бит влево

    R = (R << 11) | (R >> 53);

    // Сложение со старшей частью блока

    R ^= L;
    L = Rtemp;

    return make_pair(L, R);
}


inline pair<uint64_t, uint64_t> DecryptionRound(uint64_t& subKey, uint64_t& L, uint64_t& R)
{
    uint64_t temp = R;
    R = L;

    L = L + subKey;

    // Разделение на S-подблоки по 4 бита

    vector<char> subBlocks(FULL_BLOCK_BYTE_SIZE, 0);

    for (int i = 0; i < FULL_BLOCK_BYTE_SIZE; i++)
    {
        subBlocks[i] = (L >> (4 * (15 - i))) & 0x0F;

        // Замена по таблице
        subBlocks[i] = ReplacementTable[i][subBlocks[i]];
    }

    // Запись результата замены в правую часть блока

    L = 0;

    for (int i = 0; i < FULL_BLOCK_BYTE_SIZE; i++)
    {
        L = L | (static_cast<uint64_t>(subBlocks[i]) << (4 * (15 - i)));
    }

    // Циклический сдвиг на 11 бит влево

    L = (L << 11) | (L >> 53);

    L = L ^ temp;

    return make_pair(L, R);
}

inline vector<unsigned char> EncryptionBlock(const vector <unsigned char>& key, const vector <unsigned char>& data)
{
    // Разделение блока пополам

    pair<uint64_t, uint64_t> DATA;
    DATA = MakePairFromBlock(data);

    uint64_t L, R;

    L = DATA.first;
    R = DATA.second;

    // Разделение ключа на массив подключей

    vector<uint64_t> SUBKEYS;
    SUBKEYS = MakeSubkeysArray(key);

    // Первые 24 раунда шифрования K0-7

    for (int j = 0; j < 3; j++)
    {
        for (int i = 0; i < 8; i++)
        {
            // Определение подключа раунда
            uint64_t subKey = SUBKEYS[i];

            EncryptionRound(subKey, L, R);
        }
    }

    // Последние 8 раундов шифрования K7-0

    for (int i = 7; i >= 0; i--)
    {
        // Определение подключа раунда
        uint64_t subKey = SUBKEYS[i];

        EncryptionRound(subKey, L, R);
    }

    DATA = { L,R };
    vector <unsigned char> newData = CombineBlocksToData(L, R);
    return newData;
}

inline vector<unsigned char> DecryptionBlock(const vector <unsigned char>& key, const vector <unsigned char>& data)
{
    ofstream decryptedFile(OUTPUT_PATH, ios::binary);

    // Разделение блока пополам

    pair<uint64_t, uint64_t> DATA;
    DATA = MakePairFromBlock(data);

    uint64_t L, R;

    L = DATA.first;
    R = DATA.second;

    // Разделение ключа на массив подключей

    vector<uint64_t> SUBKEYS;
    SUBKEYS = MakeSubkeysArray(key);

    // Первые 8 раундов расшифрования K0-7

    for (int i = 0; i < 8; i++)
    {
        // Определение подключа раунда
        uint64_t subKey = SUBKEYS[i];

        DecryptionRound(subKey, L, R);
    }

    // Последние 24 раунда шифрования K7-0

    for (int j = 0; j < 3; j++)
    {
        for (int i = 7; i >= 0; i--)
        {
            // Определение подключа раунда
            uint64_t subKey = SUBKEYS[i];

            DecryptionRound(subKey, L, R);
        }
    }
    DATA = { L,R };
    vector <unsigned char> newData = CombineBlocksToData(L, R);
    return newData;
}