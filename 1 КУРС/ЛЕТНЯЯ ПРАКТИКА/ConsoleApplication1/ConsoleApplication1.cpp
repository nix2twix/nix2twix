#include <ctime>
#include <iostream>
#include <unordered_set>
#include <vector>
#include <algorithm>
#include <set>
#include <fstream>
#include <stdlib.h>
using namespace std;
int main()
{
	unsigned int start_time = clock(); // начальное время
	ifstream testinput("20");
	ofstream testoutput("20.a");
	unordered_set <int> in;
	unordered_set <int>::iterator init = in.begin();
	int n, m, x;
	testinput >> n;
	for (int i = 0; i < n; i++)
	{
		testinput >> x;
		in.insert(x);
	}
	testinput >> m;
	for (int i = 0; i < m; i++)
	{
		testinput >> x;
		if (in.find(x) == in.end()) testoutput << "no" << "\n";
		else testoutput << "yes" << "\n";
	}
	testinput.close();
	testoutput.close();
	unsigned int end_time = clock(); // конечное время
	unsigned int search_time = end_time - start_time; // искомое время
	cout << "time is: " << search_time / 1000.0 << " sec.";
	return 0;
}

/*int main()
{
	ofstream out("20");
	int n = 10000;
	out << n << "\n";
	for (int i = 0; i < n; i++)
	{
		out << 1 + rand() % 10000 << " ";
	}
	int m = 10000;
	out << m << "\n";
	for (int i = 0; i < n; i++)
	{
		out << 1 + rand() % 10000 << "\n";
	}
	out.close();
}*/
