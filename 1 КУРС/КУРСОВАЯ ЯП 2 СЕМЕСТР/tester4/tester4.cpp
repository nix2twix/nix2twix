#include <iostream>
#include <fstream>
#include <cmath>
#include <stdlib.h>
using namespace std;
int main()
{
	setlocale(LC_ALL, "RUSSIAN");
	ofstream testinput("31");
	srand((unsigned)time(NULL));
	int n = 1000, m = 1000, x; //1000 1000
	testinput << m << " " << n << "\n";
	for (int i = 1; i <= m*n; i++)
	{	
		x = 1000; //1001
		testinput << x << " "; 
		if (i%m == 0) testinput << "\n";
	}
	testinput.close();
	return 0;
}