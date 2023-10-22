#include <iostream>
#include <fstream>
#include <iomanip>
#include <ctime>
#include <time.h>
using namespace std;
int main()
{
	setlocale(LC_ALL, "RUSSIAN");
	ifstream input("31");
	ofstream output("31.a");
	clock_t tStart = clock();
	if (!input.is_open()) { cout << "ERROR: FILE IS NOT OPEN"; }
	else
	{
		long long int** array, ** pref;
		long int m, n, c, count_null = 0, sum_g = 0, sum_v = 0, max_s = 0, x1 = 1, y1 = 1, x2 = 1, y2 = 1, l, r;
		long int b_x1=0, b_y1=0, b_x2=0, b_y2=0;
		input >> m >> n;
		array = new long long int* [m];
		pref = new long long int* [m + 1];
		for (int i = 0; i < m; i++) array[i] = new long long int[n];
		for (int i = 0; i < m + 1; i++) pref[i] = new long long int[n + 1];

		for (int i = 0; i < n + 1; i++) pref[0][i] = 0;
		for (int j = 0; j < m + 1; j++) pref[j][0] = 0;

		for (int i = 0; i < n; i++)
		{
			sum_g = 0;
			for (int j = 0; j < m; j++)
			{
				input >> array[j][i];
				sum_g += array[j][i];
				pref[j + 1][i + 1] = sum_g + pref[j + 1][i];
			}
		}

		while (x1 <= m)
		{
			y1 = 1;
			while (y1 <= n)
			{
				if (array[x1 - 1][y1 - 1] == 0) { y1++;  continue; }
				while (x2 <= m)
				{
					y2 = 1;
					while (y2 <= n)
					{
						if ((x1 > m) || (y1 > n) || (x2 > m) || (y2 > n)) break;
						c = pref[x2][y2] - pref[x1 - 1][y2] - pref[x2][y1 - 1] + pref[x1 - 1][y1 - 1];
						if (c % 2 == 0) c = (int)(c * 1.5);
						if (c > max_s)
						{
							max_s = c;
							b_x1 = x1; b_y1 = y1; b_x2 = x2; b_y2 = y2;
						}
						y2++;
					}
					x2++;
				}
				y1++;
			}
			x1++;
		}

		output << b_x1 << " " << b_y1 << " " << b_x2 << " " << b_y2;

	}
	input.close();
	output.close();
	printf("Time taken: %.2fs\n", (double)(clock() - tStart) / CLOCKS_PER_SEC);
	return 0;
}