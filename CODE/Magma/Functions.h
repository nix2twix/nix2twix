#pragma once
#include "MagmaConst.h"

// ���������� 64-������� ����� ������� 

pair<uint64_t, uint64_t> MakePairFromBlock(const vector <unsigned char>& data)
{
    // BLOCK = {[64], [64]} = {[L], [R]} 
    uint64_t L, R;

    for (int i = 0; i < FULL_BLOCK_BYTE_SIZE / 2; i++)
    {
        L = (L << 8) | data[i];
    }

    for (int i = FULL_BLOCK_BYTE_SIZE / 2; i < FULL_BLOCK_BYTE_SIZE; i++)
    {
        R = (R << 8) | data[i];
    }

    //cout << "L: " << hex << L << endl;
    //cout << "R: " << hex << R << endl;

    return { L, R };
}

// ����������� 64-������� ����� � ������ char

vector<unsigned char> CombineBlocksToData(uint64_t L, uint64_t R) 
{
    vector<unsigned char> data(FULL_BLOCK_BYTE_SIZE);

    for (int i = FULL_BLOCK_BYTE_SIZE / 2 - 1; i >= 0; i--) 
    {
        data[i] = static_cast<unsigned char>(L & 0xFF); // ����� ������� ���� L
        L >>= 8; // ����� ������ �� 8 ���
    }

    for (int i = FULL_BLOCK_BYTE_SIZE - 1; i >= FULL_BLOCK_BYTE_SIZE / 2; i--) 
    {
        data[i] = static_cast<unsigned char>(R & 0xFF); // ����� ������� ���� R
        R >>= 8; // ����� ������ �� 8 ���
    }

    return data;
}


vector<uint64_t> MakeSubkeysArray(const vector <unsigned char>& key)
{
    // KEY = SUBKEYS[8]
    vector<uint64_t> SUBKEYS(8, 0);

    // ���������� ����� �� ������ �� 8 ��������� �� 512/8 = 64 ���
    for (int j = 0, i = 0; i < 8; i++)
    {
        SUBKEYS[i] = 0;
        for (j = 0; j < 8; j++)
        {
            SUBKEYS[i] = (SUBKEYS[i] << 8) | key[i * 8 + j];
        }
    }

    //for (int i = 0; i < 8; i++)
    //{
    //    cout << "Subkey " << i << ": " << hex << SUBKEYS[i] << endl;
    //}

    return SUBKEYS;
}