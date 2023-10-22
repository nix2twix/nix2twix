#include <iostream>
#include <fstream>
#include <stdlib.h>
using namespace std;
int main()
{
	setlocale(LC_ALL, "RUSSIAN");
	ofstream testinput("01");
	srand((unsigned)time(NULL));
	int n = 1 + rand() % 50, m = 1 + rand() % 1000, y, z;
	testinput << n << "\n";
	for (int i = 0; i < n; i++)
	{
		testinput << 1 + rand() % 1000 << " "; //1000
	}
	testinput << "\n" << m << "\n";
	for (int i = 0; i < m; i++)
	{
		z = 1 + rand() % n;
		y = 1 + rand() % z;
		testinput << y << " " << z;
		if (i < m-1) testinput << "\n";
	}
	testinput.close();
	return 0;
}