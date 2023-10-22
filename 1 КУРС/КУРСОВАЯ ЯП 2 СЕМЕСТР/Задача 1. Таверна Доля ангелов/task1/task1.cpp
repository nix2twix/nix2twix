#include <iostream>
#include <fstream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "RUSSIAN");
	ifstream input("04");
	ofstream output("04.a2");
	if (!input.is_open())
	{
		cout << "ERROR: FILE IS NOT OPEN";
	}
	else
	{
		long int n, m, y, z, l, r;
		long long int* array, * pref;
		input >> n;
		array = new long long int[n];
		pref = new long long int[n + 1];
		pref[0] = 0;
		for (int i = 0; i < n; i++)
		{
			input >> array[i];
			pref[i + 1] = pref[i] + array[i];
		}

		input >> m;
		for (int i = 0; i < m; i++)
		{
			input >> y >> z;
			l = y-1;
			r = z;
			output << pref[r] - pref[l] << "\n";
		}
	}
	input.close();
	output.close();
	return 0;
}