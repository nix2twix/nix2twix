#include "Functions.h"
#include <fstream>

// Для расшифрования поменять data на encrypted

const string DATA_PATH = "D:\\STUDY\\NIX2TWIX\\CODE\\Crypto_Lab7\\data.txt";
const string OUTPUT_PATH = "D:\\STUDY\\NIX2TWIX\\CODE\\Crypto_Lab7\\encrypted.txt";

int main_ENC()
{
	uint16_t LFSR1;
	uint16_t LFSR2;
	uint16_t LFSR3;
	vector<unsigned char> gamma;

	int gammaByteSize = 16;

	Initialization(LFSR1, LFSR2, LFSR3);

	cout << "\nGamma:\t";
	for (size_t i = 0; i < gammaByteSize; i++)
	{
		char gammaByte = MakeGamma(LFSR1, LFSR2, LFSR3);

		cout << gammaByte;

		gamma.push_back(gammaByte);
	}

	ifstream dataFile(DATA_PATH, ios::binary);

	// Определение размера файла
	dataFile.seekg(0, ios::end);
	const int fileSize = dataFile.tellg();
	dataFile.seekg(0, ios::beg);

	vector<unsigned char> data(fileSize);

	dataFile.read(reinterpret_cast<char*>(data.data()), fileSize);
	dataFile.close();

	// Шифрование с помощью полученной гаммы

	ofstream encryptedFile(OUTPUT_PATH, ios::binary);

	for (int gammaIndex = 0, i = 0; i < data.size(); i++)
	{
		// Гаммирование
		data[i] ^= gamma[gammaIndex];

		// Переход к следующему байту гаммы
		gammaIndex = (gammaIndex + 1) % gamma.size();

	}

	encryptedFile.write(reinterpret_cast<const char*>(data.data()), data.size());
	encryptedFile.close();

	return EXIT_SUCCESS;
}