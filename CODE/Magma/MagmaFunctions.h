#pragma once
#include "MagmaConst.h"
#include <fstream>
#include <string>
#include <cstdlib>
#include <ctime>

// Разделение 64-битного блока пополам 

inline pair<uint64_t, uint64_t> MakePairFromBlock(const vector <unsigned char>& data)
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

    return { L, R };
}

// Объединение 64-битного блока в массив char

inline vector<unsigned char> CombineBlocksToData(uint64_t L, uint64_t R)
{
    vector<unsigned char> data(FULL_BLOCK_BYTE_SIZE);

    for (int i = FULL_BLOCK_BYTE_SIZE / 2 - 1; i >= 0; i--) 
    {
        data[i] = static_cast<unsigned char>(L & 0xFF); // Взять младший байт L
        L >>= 8; // Сдвиг вправо на 8 бит
    }

    for (int i = FULL_BLOCK_BYTE_SIZE - 1; i >= FULL_BLOCK_BYTE_SIZE / 2; i--) 
    {
        data[i] = static_cast<unsigned char>(R & 0xFF); // Взять младший байт R
        R >>= 8; // Сдвиг вправо на 8 бит
    }

    return data;
}


inline vector<uint64_t> MakeSubkeysArray(const vector <unsigned char>& key)
{
    // KEY = SUBKEYS[8]
    vector<uint64_t> SUBKEYS(8, 0);
    vector<uint64_t> KEYS(32, 0);

    // Разделение ключа на массив из 8 подключей по 512/8 = 64 бит
    for (int j = 0, i = 0; i < 8; i++)
    {
        SUBKEYS[i] = 0;
        for (j = 0; j < 8; j++)
        {
            SUBKEYS[i] = (SUBKEYS[i] << 8) | key[i * 8 + j];
        }
    }

    for (int i = 0; i < 24; i++)//0-7
    {
        KEYS[i] = SUBKEYS[i % 8];
    }

    for (int j = 7, i = 24; j >=0, i < 32; i++, j--)//7-0
    {
        KEYS[i] = SUBKEYS[j];
    }

    return SUBKEYS;
}

inline int Padding(int fileSize, string path)
{
    // Дополнение последнего блока данных на additionCount байт

    int lastBlockCount = fileSize % FULL_BLOCK_BYTE_SIZE;
    int additionByteCount = (lastBlockCount == 0)
        ? 0
        : FULL_BLOCK_BYTE_SIZE - lastBlockCount;

    ofstream rewriteDataFile(path, ios::binary | ios::app);

    char buff = 0;
    for (int i = 0; i < additionByteCount; i++)
    {
        if (i == 0)
        {
            buff = (buff << 2) | 0x10;
        }
        else
        {
            buff = 0;
        }
        rewriteDataFile.write(reinterpret_cast<const char*>(&buff), sizeof(unsigned char));
    }

    rewriteDataFile.close();

    return additionByteCount;
}

inline void RemovePadding(string path) 
{
    ifstream inputFile(path, ios::in | ios::out | ios::binary);
    ofstream tempFile("tempfile.txt", ios::binary | ios::trunc);

    inputFile.seekg(0, ios::end);
    int position = inputFile.tellg();

    char byte;
    bool isOneBitFound = false;
    int count = 0;

    while (position > 0) 
    {
        inputFile.seekg(--position);
        inputFile.get(byte);

        if (byte == '\x10') 
        {
            isOneBitFound = true;
            break;
        }
        if (count > FULL_BLOCK_BYTE_SIZE)
            break;
        count++;
    }

    if (isOneBitFound) 
    {
        inputFile.seekg(0); // Сбрасываем указатель на начало файла

        // Копируем данные до позиции position в tempFile
        while (inputFile.tellg() < position) 
        {
            inputFile.get(byte);
            tempFile.put(byte);
        }

        tempFile.close();
        inputFile.close();

        // Заменяем исходный файл временным
        remove(path.c_str());
        rename("tempfile.txt", path.c_str());

    }

    inputFile.close();
}

inline vector<uint64_t> MakeRegister(const vector<unsigned char>& IV)
{

    vector<uint64_t> shiftRegister(4, 0);

    uint64_t firstNumber = 0;
    for (int i = 0; i < FULL_BLOCK_BYTE_SIZE / 2; i++)
    {
        firstNumber = (firstNumber << 8) | IV[i];
    }
    shiftRegister[0] = firstNumber;

    uint64_t secondNumber = 0;
    for (int i = FULL_BLOCK_BYTE_SIZE / 2; i < FULL_BLOCK_BYTE_SIZE; i++)
    {
        secondNumber = (secondNumber << 8) | IV[i];
    }
    shiftRegister[1] = secondNumber;

    uint64_t thirdNumber = 0;
    for (int i = FULL_BLOCK_BYTE_SIZE; i < FULL_BLOCK_BYTE_SIZE + 8; i++)
    {
        thirdNumber = (thirdNumber << 8) | IV[i];
    }
    shiftRegister[2] = thirdNumber;

    uint64_t fourthNumber = 0;
    for (int i = FULL_BLOCK_BYTE_SIZE + 8; i < M; i++)
    {
        fourthNumber = (fourthNumber << 8) | IV[i];
    }
    shiftRegister[3] = fourthNumber;

    return shiftRegister;
}

inline vector<unsigned char> GenerateSinchrosign() 
{
    const string charset = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
    const int byteLength = 256 / 8;
    vector<unsigned char> result(byteLength);

   srand(static_cast<unsigned int>(time(nullptr)));

    for (int i = 0; i < byteLength; ++i) 
    {
        result[i] = charset[rand() % charset.length()];
    }

    ofstream sinchrosignFile(SINCHROSIGN_PATH, ios::binary);
    sinchrosignFile.write(reinterpret_cast<const char*>(result.data()), result.size());
    sinchrosignFile.close();

    return result;
}

inline vector<unsigned char> SplitRegister(const vector<uint64_t>& shiftRegister)
{
    vector<unsigned char> IV;

    for (int i = 0; i < shiftRegister.size(); i++)
    {
        uint64_t temp = shiftRegister[i];

        for (int j = 0; j < 8; j++) 
        {
            IV.push_back((temp >> ((7 - j) * 8)) & 0xFF);
        }
    }

    return IV;
}