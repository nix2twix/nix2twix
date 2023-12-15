#include "Functions.h"
#include <fstream>

const string OUTPUT_PATH = "D:\\STUDY\\NIX2TWIX\\CODE\\Crypto_Lab7\\seed.txt";

int main()
{
	int seedSize = 100000;

	uint16_t LFSR1;
	uint16_t LFSR2;
	uint16_t LFSR3;
	vector<unsigned char> seed;

	Initialization(LFSR1, LFSR2, LFSR3);

	ofstream seedFile(OUTPUT_PATH, ios::binary);
	for (size_t i = 0; i < seedSize; i++)
	{
		unsigned char gammaByte = MakeGamma(LFSR1, LFSR2, LFSR3);

		seed.push_back(gammaByte);

		seedFile << (double)gammaByte / 0xFF << " ";
	}

	seedFile.close();

	return EXIT_SUCCESS;
}