#pragma once
#include "MagmaFunctions.h"

inline pair<uint64_t, uint64_t> EncryptionRound(uint64_t& subKey, uint64_t& L, uint64_t& R)
{
    // ���������� ���������� �������� ������� ����� �����
    uint64_t Rtemp = R;

    R = R + subKey;

    // ���������� �� S-�������� �� 4 ����

    vector<char> subBlocks(FULL_BLOCK_BYTE_SIZE, 0);

    for (int i = 0; i < FULL_BLOCK_BYTE_SIZE; i++)
    {
        subBlocks[i] = (R >> (4 * (15 - i))) & 0x0F;

        // ������ �� �������
        subBlocks[i] = ReplacementTable[i][subBlocks[i]];

    }

    // ������ ���������� ������ � ������ ����� �����
    R = 0;

    for (int i = 0; i < FULL_BLOCK_BYTE_SIZE; i++)
    {
        R = R | (static_cast<uint64_t>(subBlocks[i]) << (4 * (15 - i)));
    }

    // ����������� ����� �� 11 ��� �����

    R = (R << 11) | (R >> 53);

    // �������� �� ������� ������ �����

    R ^= L;
    L = Rtemp;

    return make_pair(L, R);
}


inline pair<uint64_t, uint64_t> DecryptionRound(uint64_t& subKey, uint64_t& L, uint64_t& R)
{
    uint64_t temp = R;
    R = L;

    L = L + subKey;

    // ���������� �� S-�������� �� 4 ����

    vector<char> subBlocks(FULL_BLOCK_BYTE_SIZE, 0);

    for (int i = 0; i < FULL_BLOCK_BYTE_SIZE; i++)
    {
        subBlocks[i] = (L >> (4 * (15 - i))) & 0x0F;

        // ������ �� �������
        subBlocks[i] = ReplacementTable[i][subBlocks[i]];
    }

    // ������ ���������� ������ � ������ ����� �����

    L = 0;

    for (int i = 0; i < FULL_BLOCK_BYTE_SIZE; i++)
    {
        L = L | (static_cast<uint64_t>(subBlocks[i]) << (4 * (15 - i)));
    }

    // ����������� ����� �� 11 ��� �����

    L = (L << 11) | (L >> 53);

    L = L ^ temp;

    return make_pair(L, R);
}

inline vector<unsigned char> EncryptionBlock(const vector <unsigned char>& key, const vector <unsigned char>& data)
{
    // ���������� ����� �������

    pair<uint64_t, uint64_t> DATA;
    DATA = MakePairFromBlock(data);

    uint64_t L, R;

    L = DATA.first;
    R = DATA.second;

    // ���������� ����� �� ������ ���������

    vector<uint64_t> SUBKEYS;
    SUBKEYS = MakeSubkeysArray(key);

    // ������ 24 ������ ���������� K0-7

    for (int j = 0; j < 3; j++)
    {
        for (int i = 0; i < 8; i++)
        {
            // ����������� �������� ������
            uint64_t subKey = SUBKEYS[i];

            EncryptionRound(subKey, L, R);
        }
    }

    // ��������� 8 ������� ���������� K7-0

    for (int i = 7; i >= 0; i--)
    {
        // ����������� �������� ������
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

    // ���������� ����� �������

    pair<uint64_t, uint64_t> DATA;
    DATA = MakePairFromBlock(data);

    uint64_t L, R;

    L = DATA.first;
    R = DATA.second;

    // ���������� ����� �� ������ ���������

    vector<uint64_t> SUBKEYS;
    SUBKEYS = MakeSubkeysArray(key);

    // ������ 8 ������� ������������� K0-7

    for (int i = 0; i < 8; i++)
    {
        // ����������� �������� ������
        uint64_t subKey = SUBKEYS[i];

        DecryptionRound(subKey, L, R);
    }

    // ��������� 24 ������ ���������� K7-0

    for (int j = 0; j < 3; j++)
    {
        for (int i = 7; i >= 0; i--)
        {
            // ����������� �������� ������
            uint64_t subKey = SUBKEYS[i];

            DecryptionRound(subKey, L, R);
        }
    }
    DATA = { L,R };
    vector <unsigned char> newData = CombineBlocksToData(L, R);
    return newData;
}