#include <fstream>
#include <vector>
#include <iostream>
#include <string>
using namespace std;

#define SIZE_BLOCK 3 


struct Block
{
    unsigned char b1 : 6;
    unsigned char b2 : 6;
    unsigned char b3 : 6;
    unsigned char b4 : 6;

public:
    Block(unsigned int uint_block)
    {
        b4 = (uint_block >> 0) & 0x3f;
        b3 = (uint_block >> 6) & 0x3f;
        b2 = (uint_block >> 12) & 0x3f;
        b1 = (uint_block >> 18) & 0x3f;
    }

public:
    unsigned int toInt() const
    {
        // значения в младшей части переменной int
        // 0000 0000 XXXXXX XXXXXX XXXXXX XXXXXX
        return (b1 << 18) | (b2 << 12) | (b3 << 6) | b4;
    }

};

const vector<vector<unsigned char>> table = {
    {40, 54, 49, 0, 51, 31, 59, 37, 16, 34, 62, 46, 56, 8, 1, 9, 20, 32, 41, 57, 2, 5, 44, 15, 29, 33, 35, 3, 10, 45, 38, 22, 17, 23, 61, 55, 50, 21, 48, 25, 27, 28, 24, 11, 42, 12, 13, 7, 30, 4, 36, 47, 60, 14, 43, 18, 26, 19, 39, 6, 58, 53, 52},
    {19, 26, 41, 52, 20, 56, 51, 33, 16, 36, 38, 61, 13, 35, 0, 45, 29, 6, 58, 30, 62, 46, 4, 2, 50, 1, 47, 5, 28, 54, 53, 59, 7, 27, 25, 18, 12, 8, 48, 15, 31, 11, 55, 22, 37, 43, 40, 14, 32, 44, 23, 42, 9, 10, 34, 17, 49, 21, 3, 24, 57, 39, 60},
    {9, 59, 24, 45, 6, 57, 39, 31, 43, 41, 26, 12, 34, 51, 11, 44, 46, 62, 7, 18, 55, 60, 30, 14, 28, 3, 16, 19, 29, 15, 23, 61, 58, 10, 1, 56, 38, 48, 25, 5, 20, 33, 8, 37, 0, 54, 50, 17, 53, 21, 36, 2, 22, 27, 40, 52, 47, 4, 32, 35, 42, 49, 13},
    {20, 56, 44, 38, 23, 36, 13, 27, 35, 18, 4, 55, 33, 24, 3, 31, 45, 29, 42, 30, 26, 19, 28, 6, 14, 0, 8, 22, 5, 41, 46, 21, 32, 9, 1, 7, 10, 37, 15, 52, 59, 2, 39, 11, 47, 34, 54, 48, 53, 60, 62, 61, 12, 51, 50, 17, 40, 58, 25, 57, 16, 43}
};


void encryptFile(const string& inputFilepath, const string& outputFilepath,
    vector<vector<unsigned char>> subsTable) 
{
    ifstream inputFile(inputFilepath, ios::binary);
    ofstream encryptedFile(outputFilepath, ios::binary);

    while (!inputFile.eof())
    {
        char buff[4];
        char byte;
        int count = 0;

        // Считывание из файла по байту
        for (count = 0; count < SIZE_BLOCK && inputFile.read(&byte, 1); count++)
            buff[count] = byte;

        unsigned int* uint_block = reinterpret_cast<unsigned int*>(buff);

        Block block{*uint_block};

        // Замена по таблице

        block.b1 = subsTable[0][block.b1];
        block.b2 = subsTable[1][block.b2];
        block.b3 = subsTable[2][block.b3];
        block.b4 = subsTable[3][block.b4];

        auto recast = block.toInt();

        encryptedFile.write(reinterpret_cast<char*>(&recast), count);
    }

    inputFile.close();
    encryptedFile.close();
}

void decryptFile(const string& inputFilepath, const string& outputFilepath,
    vector<vector<unsigned char>> subsTable)
{
    ifstream encryptedFile(inputFilepath, ios::binary);
    ofstream decryptedFile(outputFilepath, ios::binary);

    while (!encryptedFile.eof())
    {
        char buff[SIZE_BLOCK];
        char byte;
        int count = 0;

        // Считывание из файла по байту
        for (count = 0; count < SIZE_BLOCK && encryptedFile.read(&byte, 1); count++)
            buff[count] = byte;

        unsigned int* uint_block = reinterpret_cast<unsigned int*>(buff);

        Block block{ *uint_block };

        // Обратная замена по таблице (ищем индекс)

        block.b1 = distance
        (
            subsTable[0].begin(),
            (find(subsTable[0].begin(), subsTable[0].end(), block.b1))
        );
        block.b2 = distance
        (
            subsTable[1].begin(),
            (find(subsTable[1].begin(), subsTable[1].end(), block.b2))
        );
        block.b3 = distance
        (
            subsTable[2].begin(),
            (find(subsTable[2].begin(), subsTable[2].end(), block.b3))
        );
        block.b4 = distance
        (
            subsTable[3].begin(),
            (find(subsTable[3].begin(), subsTable[3].end(), block.b4))
        );

        auto recast = block.toInt();

        decryptedFile.write(reinterpret_cast<char*>(&recast), count);
    }

    encryptedFile.close();
    decryptedFile.close();
}
/*
int main() 
{

    string dataPath = "C:\\Users\\Вика\\Desktop\\test.txt";
    string encryptPath = "C:\\Users\\Вика\\Desktop\\encrypted.txt";
    string decryptPath = "C:\\Users\\Вика\\Desktop\\decrypted.txt";

    encryptFile(dataPath, encryptPath, table);
    decryptFile(dataPath, decryptPath, table);

    return 0;
}
*/