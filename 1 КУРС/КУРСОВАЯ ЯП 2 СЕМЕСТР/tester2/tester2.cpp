#include <iostream>
#include <fstream>
#include <stdlib.h>
using namespace std;
int main()
{
	setlocale(LC_ALL, "RUSSIAN");
	ofstream testinput("30");
	srand(time(0));
	//int n = 3, x;
	int n =1+rand()%100000, x; //1000000
	testinput << n << "\n";
	for (int i = 0; i < n; i++)
	{
		x = rand()%200001 - 5000;//2000001-5000
		testinput << x << " ";
	}
	testinput.close();
	return 0;
}