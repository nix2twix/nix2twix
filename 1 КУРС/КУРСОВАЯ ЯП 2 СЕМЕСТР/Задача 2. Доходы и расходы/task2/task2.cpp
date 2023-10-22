#include <iostream>
#include <fstream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "RUSSIAN");
	ifstream input("17");
	ofstream output("17.a");
	if (!input.is_open()) { cout << "ERROR: FILE IS NOT OPEN"; }
	else
	{
		int n, k = 0;
		input >> n;
		long long int *a, * s;
		int l, r;
		a = new long long int[n];
		s = new long long int[n + 1];
		s[0] = 0;
		for (int i = 0; i < n; i++)
		{
			input >> a[i];
			s[i + 1] = s[i] + a[i];
		}
		for (int j = 0; j < n + 1; j++)
		{
			for (int i = j+1; i < n + 1; i++)
			{
				if (s[j] == s[i])
				{
					output << j+1 << " " << i << "\n";
					k++;
					break;
				}
			}
			if (k != 0) break;
		}
		if (k == 0) output << "EMPTY";

	}
	input.close();
	output.close();
	return 0;
}

