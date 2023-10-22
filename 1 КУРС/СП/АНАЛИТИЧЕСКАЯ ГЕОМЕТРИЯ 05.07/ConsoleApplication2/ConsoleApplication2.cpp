/*
#include <iostream>
#include <algorithm>
using namespace std;
int main()
{
	int* a, * b, m, n, sum=0, k = 0, j;
	cin >> n >> m;
	a = new int[n];
	b = new int[n];
	j = n - 1;
	for (int i = 0; i < n; i++)
	{
		cin >> a[i] >> b[i];
 		sum += a[i];
	}
	sort(a, a + n);
	sort(b, b + n);
	if (sum < m) k = 0;
	else
	{
		while (sum > m)
		{
			sum -= a[j] - b[j];
			j--;
			k++;
			if (k > n) { k = -1; break; }
		}
	}
	cout << k;
	return 0;
}*/

#include <iostream>
#include <iomanip>
#include <algorithm>
using namespace std;
int main()
{
	unsigned long long n, k, t, l = 0, r = 15e8+1, m;
	cin >> n >> k;
	while (l < r - 1)
	{
		m = (r + l) / 2;
		t = ((n * m * (m + 1)) / 2);
		if (t == k) break;
		if (t > k) { r = m; }
		else l = m;
		cout << "left:  " << l << ",  right:  " << r << ",  function:  " << t << "\n";
	}
	if (t < k) r--;
	cout << r;
	return 0;
}