#pragma once
#include <iostream>
#include <vector>
#include <bitset>
#include <string>
using namespace std;

// ������� ���������

const int N = 16;
const int M = 16;
const int K = 16;

const int gammaSize = 8;

// ��������� �������� ���������

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
		// ��������� ������ ���� ��� 1-�� ��������

		newbit1 =
			((LFSR1 >> 1) & 0x01)		// ��� ������� �������
			^ ((LFSR1 >> 5) & 0x01)		// ��� ������ �������
			^ ((LFSR1 >> 8) & 0x01)		// ��� �������� �������
			^ ((LFSR1 >> 11) & 0x01)	// ��� ������������� �������
			^ ((LFSR1 >> 14) & 0x01);	// ��� �������������� �������

		// ��������� ���� �� 1-�� �������� ����� ������

		bit1 = LFSR1 & 0x01;

		LFSR1 = (LFSR1 >> 1) | (newbit1 << 15);
	
		// ��������� ��������� 2-�� ��������, 
		// ���� � ������ 1-�� �������� �������

		if (bit1 == 0x01)
		{
			// ��������� ������ ���� ��� 2-�� ��������
			newbit2 =
				((LFSR2 >> 1) & 0x01)		// ��� ������� �������
				^ ((LFSR2 >> 5) & 0x01)		// ��� ������ �������
				^ ((LFSR2 >> 8) & 0x01)		// ��� �������� �������
				^ ((LFSR2 >> 11) & 0x01)	// ��� ������������� �������
				^ ((LFSR2 >> 14) & 0x01);	// ��� �������������� �������

			// ��������� ���� �� 2-�� �������� ����� ������

			bit2 = LFSR2 & 0x01;

			LFSR2 = (LFSR2 >> 1) | (newbit2 << 15);
		}


		// ��������� ������ ���� ��� 3-�� ��������

		newbit3 =
			((LFSR3 >> 1) & 0x01)		// ��� ������� �������
			^ ((LFSR3 >> 5) & 0x01)		// ��� ������ �������
			^ ((LFSR3 >> 8) & 0x01)		// ��� �������� �������
			^ ((LFSR3 >> 11) & 0x01)	// ��� ������������� �������
			^ ((LFSR3 >> 14) & 0x01);	// ��� �������������� �������

		// ��������� ���� �� 3-�� �������� ����� ������

		bit3 = LFSR3 & 0x01;

		LFSR3 = (LFSR3 >> 1) | (newbit3 << 15);

		// ���������� ����� ������� �������������������

		gamma = (gamma << 1) | (bit2 ^ bit3);

	}

	return gamma;
}