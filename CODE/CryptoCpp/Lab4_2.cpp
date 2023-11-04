#include <iostream>
#include <string>
#include <fstream>
#include <vector>
using namespace std;


void EncryptFile(string path, vector<unsigned char> gamma)
{
    ifstream dataFile(path, ios::binary);

    // Определение размера файла
    dataFile.seekg(0, ios::end);
    const int fileSize = dataFile.tellg();
    dataFile.seekg(0, ios::beg);

    vector<unsigned char> data(fileSize);

    dataFile.read(reinterpret_cast<char*>(data.data()), fileSize);

    string encOutPath = "C:\\Users\\Вика\\Desktop\\encrypt.txt";
    ofstream encryptedFile(encOutPath, ios::binary);
    
    for (int gammaIndex = 0, i = 0; i < data.size(); i++)
    {
        // Сдвиг на 5 бит влево
        data[i] = (data[i] << 5) | (data[i] >> 3);

        // Гаммирование
        data[i] ^= gamma[gammaIndex];

        // Переход к следующему байту гаммы
        gammaIndex = (gammaIndex + 1) % gamma.size();

    }

    encryptedFile.write(reinterpret_cast<const char*>(data.data()), data.size());
    encryptedFile.close();
    dataFile.close();
}

void DecryptFile(string path, vector<unsigned char> gamma)
{

    ifstream dataFile(path, ios::binary);

    // Определение размера файла
    dataFile.seekg(0, ios::end);
    const int fileSize = dataFile.tellg();
    dataFile.seekg(0, ios::beg);

    vector<unsigned char> data(fileSize);

    dataFile.read(reinterpret_cast<char*>(data.data()), fileSize);

    string decrOutPath = "C:\\Users\\Вика\\Desktop\\decrypt.txt";
    ofstream outputFile(decrOutPath, ios::binary);

    int gammaIndex = 0;
    for (int i = 0; i < data.size(); i++)
    {
        // Гаммирование
        data[i] ^= gamma[gammaIndex];

        // Циклический сдвиг на 5 бит вправо
        data[i] = (data[i] >> 5) | (data[i] << 3);

        // Переход к следующему байту гаммы
        gammaIndex = (gammaIndex + 1) % gamma.size();
    }
    outputFile.write(reinterpret_cast<const char*>(data.data()), data.size());
    dataFile.close();
    outputFile.close();
}

int main()
{
    // Для шифрования в путь прописать test.txt
    // Для расшифрования прописать encrypt.txt

    string dataPath = "C:\\Users\\Вика\\Desktop\\encrypt.txt";
    string gammaValue;
    vector<unsigned char> gamma;

    cout << "Write the gamma (4 symbols): ";
    cin >> gammaValue;

    // Преобразование ключа в массив байтов

    for (int i = 0; i < 4; i++)
    {
        gamma.push_back(gammaValue[i]);
    }

    // Шифрование

    // EncryptFile(dataPath, gamma);

    // Расшифрование

        DecryptFile(dataPath, gamma);

    return 0;
}

/*
#include <iostream>
#include <string>
#include <fstream>
#include <vector>
using namespace std;

# Аналогичный алгоритм со считыванием по 1 байту из файла

void EncryptFile(string inputFilepath, string outputFilepath, vector<unsigned char> gamma)
{

    ifstream inputFile(inputFilepath, ios::binary);
    ofstream encryptedFile(outputFilepath, ios::binary);
    int gammaIndex = 0;

    while (!inputFile.eof())
    {
        char byte;
        char buff;

        // Считать из файла байт
        inputFile.read(&buff, 1);

        // Сдвиг на 5 бит влево
        byte = (buff << 5) | (buff >> 3);

        // Гаммирование
        byte ^= gamma[gammaIndex];

        // Переход к следующему байту гаммы
        gammaIndex = (gammaIndex + 1) % gamma.size();

        encryptedFile.write(reinterpret_cast<char*>(&byte), 1);
    }

    inputFile.close();
    encryptedFile.close();

}

void DecryptFile(string inputFilepath, string outputFilepath, vector<unsigned char> gamma)
{
    ifstream inputFile(inputFilepath, ios::binary);
    ofstream decryptedFile(outputFilepath, ios::binary);
    int gammaIndex = 0;

    while (!inputFile.eof())
    {
        char buff;
        char byte;

        // Считать из файла байт
        inputFile.read(&buff, 1);

        // Гаммирование
        buff ^= gamma[gammaIndex];

        // Циклический сдвиг на 5 бит вправо
        byte = (buff << 3) | (buff >> 5);

        // Переход к следующему байту гаммы
        gammaIndex = (gammaIndex + 1) % gamma.size();

        decryptedFile.write(reinterpret_cast<char*>(&byte), 1);
    }

    inputFile.close();
    decryptedFile.close();

}

int main()
{
    string dataPath = "C:\\Users\\Вика\\Desktop\\test.txt";
    string encryptPath = "C:\\Users\\Вика\\Desktop\\encrypted.txt";
    string decryptPath = "C:\\Users\\Вика\\Desktop\\decrypted.txt";

    string gammaValue;
    vector<unsigned char> gamma;

    cout << "Write the gamma (2 symbols): ";
    cin >> gammaValue;

    // Преобразование ключа в массив байтов

    for (int i = 0; i < 2; i++)
    {
        gamma.push_back(gammaValue[i]);
    }

    // Шифрование

    EncryptFile(dataPath, encryptPath, gamma);

    // Расшифрование

    DecryptFile(encryptPath, decryptPath, gamma);

    return 0;
}
*/