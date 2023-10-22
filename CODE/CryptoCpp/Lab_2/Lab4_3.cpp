#include <fstream>
#include <vector>
#include <iostream>
#include <string>
#include <bit>

#define SIZE_BLOCK 1

using namespace std;

struct Block
{
    unsigned char b1 : 4;
    unsigned char b2 : 4;

public:
    Block(unsigned char uchar_block)
    {

        b2 = uchar_block & 0x3f;
        b1 = (uchar_block >> 4) & 0x3f;
    }

public:
    unsigned char toChar() const
    {
        // значения в младшей части переменной char
        // XXXX XXXX
        return (b1 << 4) | b2;
    }

};

const vector<vector<unsigned char>> table = {
    {2, 12, 1, 14, 3, 8, 10, 9, 5, 4, 0, 15, 6, 7, 13, 11},
    {10, 7, 12, 2, 6, 3, 1, 9, 14, 4, 5, 11, 15, 0, 13, 8},
};

void encryptFile(const string& inputFilepath, const string& outputFilepath,
    vector<vector<unsigned char>> subsTable, vector<unsigned char> gamma)
{
    ifstream inputFile(inputFilepath, ios::binary);
    ofstream encryptedFile(outputFilepath, ios::binary);
    int gammaIndex = 0;

    while (!inputFile.eof())
    {
        char byte;

        // Считывание из файла по байту
        inputFile.read(&byte, 1);

        Block block{ *reinterpret_cast<unsigned char*>(&byte) };

        // Замена по таблице
        block.b1 = subsTable[0][block.b1];
        block.b2 = subsTable[1][block.b2];

        auto recast = block.toChar();

        // Гаммирование
        recast ^= gamma[gammaIndex];

        // Переход к следующему байту гаммы
        gammaIndex = (gammaIndex + 1) % gamma.size();

        encryptedFile.write(reinterpret_cast<char*>(&recast), 1);
    }

    inputFile.close();
    encryptedFile.close();
}

void decryptFile(const string& inputFilepath, const string& outputFilepath,
    vector<vector<unsigned char>> subsTable, vector<unsigned char> gamma)
{
    ifstream encryptedFile(inputFilepath, ios::binary);
    ofstream decryptedFile(outputFilepath, ios::binary);
    int gammaIndex = 0;

    while (!encryptedFile.eof())
    {
        char byte;

        // Считывание из файла по байту
        encryptedFile.read(&byte, 1); 

        Block block{ *reinterpret_cast<unsigned char*>(&byte) };

        auto recast = block.toChar();

        // Обратное гаммирование
        recast ^= gamma[gammaIndex];

        // Переход к следующему байту гаммы
        gammaIndex = (gammaIndex + 1) % gamma.size();

        // Обратная замена по таблице

        Block encryptBlock{ recast };

        encryptBlock.b1 = distance
        (
            subsTable[0].begin(),
            (find(subsTable[0].begin(), subsTable[0].end(), encryptBlock.b1))
        );
        encryptBlock.b2 = distance
        (
            subsTable[1].begin(),
            (find(subsTable[1].begin(), subsTable[1].end(), encryptBlock.b2))
        );

        recast = encryptBlock.toChar();

        decryptedFile.write(reinterpret_cast<char*>(&recast), SIZE_BLOCK);
    }

    encryptedFile.close();
    decryptedFile.close();
}
//
//int main()
//{
//    string dataPath = "C:\\Users\\Вика\\Desktop\\test.txt";
//    string encryptPath = "C:\\Users\\Вика\\Desktop\\encrypted.txt";
//    string decryptPath = "C:\\Users\\Вика\\Desktop\\decrypted.txt";
//
//    string gammaValue;
//    vector<unsigned char> gamma;
//
//    cout << "Write the gamma (4 symbols): ";
//    cin >> gammaValue;
//
//    // Преобразование ключа в массив байтов
//
//    for (int i = 0; i < 4; i++)
//    {
//        gamma.push_back(gammaValue[i]);
//    }
//
//    encryptFile(dataPath, encryptPath, table, gamma);
//    decryptFile(encryptPath, decryptPath, table, gamma);
//
//    return 0;
//}