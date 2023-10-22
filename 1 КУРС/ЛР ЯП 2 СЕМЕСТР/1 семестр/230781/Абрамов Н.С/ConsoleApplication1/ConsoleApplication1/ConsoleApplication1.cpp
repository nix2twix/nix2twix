#include <iostream>

using namespace std;
int main()
{
	int n, i = 1;
	int a=0,b;
    cout << "Enter number - ";
	cin >> n;
	b = (i + 1) * 1;
	while (i < n)
	{
		i++;
		b *= (i+1);
	}
	i = 0;
	while (i < n)
	{
		i++;
		a += (b / (i+1))*i;
	}
	cout << a << endl << "__\n" << b;
	return 0;
}
