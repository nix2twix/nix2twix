#pragma once
#include <iostream>
#include <vector>
#include <bitset>
#include <string>
using namespace std;

// Размеры регистров

const int N = 16;
const int M = 16;
const int K = 16;

const int gammaSize = 8;

// Начальные значения регистров

const uint16_t INIT1 = 0xc332;
const uint16_t INIT2 = 0x13e5;
const uint16_t INIT3 = 0x669a;


inline void Print(uint16_t &LFSR1, uint16_t& LFSR2, uint16_t& LFSR3)
{
	cout << "Initial state of registers:\n";

	cout << "LFSR1:\t";
	for (size_t i = 0; i < N; i++)
	{
		cout << ((LFSR1 >> (N - i - 1) & 0x01));
	}
	cout << hex << "\t(" << INIT1 << ")\n";

	cout << "LFSR2:\t";
	for (size_t i = 0; i < M; i++)
	{
		cout << ((LFSR2 >> (M - i - 1) & 0x01));
	}
	cout << hex << "\t(" << INIT2 << ")\n";

	cout << "LFSR3:\t";
	for (size_t i = 0; i < K; i++)
	{
		cout << ((LFSR3 >> (K - i - 1) & 0x01));
	}
	cout << hex << "\t(" << INIT3 << ")\n";
}

inline void Initialization(uint16_t &LFSR1, uint16_t &LFSR2, uint16_t&LFSR3)
{

	LFSR1 = INIT1;
	LFSR2 = INIT2;
	LFSR3 = INIT3;

	Print(LFSR1, LFSR2, LFSR3);
}

inline char MakeGamma(uint16_t& LFSR1, uint16_t& LFSR2, uint16_t& LFSR3)
{
	char gamma;

	uint16_t bit1 = 0x00;
	uint16_t bit2 = 0x00;
	uint16_t bit3 = 0x00;

	uint16_t newbit1 = 0x00;
	uint16_t newbit2 = 0x00;
	uint16_t newbit3 = 0x00;

	for (size_t i = 0; i < gammaSize; i++)
	{
		// Получение нового бита для 1-го регистра

		newbit1 =
			((LFSR1 >> 1) & 0x01)		// Бит первого разряда
			^ ((LFSR1 >> 5) & 0x01)		// Бит пятого разряда
			^ ((LFSR1 >> 8) & 0x01)		// Бит восьмого разряда
			^ ((LFSR1 >> 11) & 0x01)	// Бит одиннадцатого разряда
			^ ((LFSR1 >> 14) & 0x01);	// Бит четырнадцатого разряда

		// Получение бита из 1-го регистра после сдвига

		bit1 = LFSR1 & 0x01;

		LFSR1 = (LFSR1 >> 1) | (newbit1 << 15);
	
		// Изменение состояния 2-го регистра, 
		// если с выхода 1-го получена единица

		if (bit1 == 0x01)
		{
			// Получение нового бита для 2-го регистра
			newbit2 =
				((LFSR2 >> 1) & 0x01)		// Бит первого разряда
				^ ((LFSR2 >> 5) & 0x01)		// Бит пятого разряда
				^ ((LFSR2 >> 8) & 0x01)		// Бит восьмого разряда
				^ ((LFSR2 >> 11) & 0x01)	// Бит одиннадцатого разряда
				^ ((LFSR2 >> 14) & 0x01);	// Бит четырнадцатого разряда

			// Получение бита из 2-го регистра после сдвига

			bit2 = LFSR2 & 0x01;

			LFSR2 = (LFSR2 >> 1) | (newbit2 << 15);
		}


		// Получение нового бита для 3-го регистра

		newbit3 =
			((LFSR3 >> 1) & 0x01)		// Бит первого разряда
			^ ((LFSR3 >> 5) & 0x01)		// Бит пятого разряда
			^ ((LFSR3 >> 8) & 0x01)		// Бит восьмого разряда
			^ ((LFSR3 >> 11) & 0x01)	// Бит одиннадцатого разряда
			^ ((LFSR3 >> 14) & 0x01);	// Бит четырнадцатого разряда

		// Получение бита из 3-го регистра после сдвига

		bit3 = LFSR3 & 0x01;

		LFSR3 = (LFSR3 >> 1) | (newbit3 << 15);

		// Наполнение гаммы битовой последовательностью

		gamma = (gamma << 1) | (bit2 ^ bit3);

	}

	return gamma;
}