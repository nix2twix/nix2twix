#include <iostream>
#include <fstream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "RUSSIAN");
	ifstream input("30");
	ofstream output("30.a");
	if (!input.is_open()) { cout << "ERROR: FILE IS NOT OPEN"; }
	else
	{
		int n, k = 1, l, r, x, m;
		input >> n;
		long long int* a = new long long int[n];
		for (int i = 0; i < n; i++)
		{
			input >> a[i];
		}

		long long int* diff = new long long int[n + 1];
		diff[0] = a[0];
		diff[n] = 0;
		for (int i = 1; i < n; i++)
		{
			diff[i] = a[k] - a[k - 1];
			k++;
		}

		input >> m;
		for (int j = 0; j < m; j++)
		{
			input >> l >> r >> x;
			diff[l - 1] += x;
			diff[r] -= x;
			for (int i = 0; i < n; i++)
			{
				if (i == 0) a[i] = diff[i];
				else a[i] = diff[i] + a[i - 1];
			}
		}
		for (int i = 0; i < n; i++)
		{
			if (a[i] >= 0) output << a[i] << " ";
			else output << 0 << " ";
		}

	}
	input.close();
	output.close();
	return 0;
}
