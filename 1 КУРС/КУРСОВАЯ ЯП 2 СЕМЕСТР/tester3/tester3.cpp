#include <iostream>
#include <fstream>
#include <stdlib.h>
using namespace std;
int main()
{
	setlocale(LC_ALL, "RUSSIAN");
	ofstream testinput("30");
	srand((unsigned)time(NULL));
	int n = 1 + rand() % 100, m = 1 + rand() % 100, l, r, y; //1000000
	testinput << n << "\n";
	for (int i = 0; i < n; i++)
	{
		testinput << 1 + rand() % 100 << " "; //10000
	}
	testinput << "\n" << m << "\n";
	for (int i = 0; i < m; i++)
	{
		r = 1 + rand() % n;
		l = 1 + rand() % r;
		y = rand() % 100; //2000001 - 5000
		testinput << l << " " << r << " " << y << "\n";
	}
	testinput.close();
	return 0;
}