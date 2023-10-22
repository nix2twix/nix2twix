#include <iostream>
#include <unordered_set>
#include <vector>
#include <algorithm>
#include <set>
#include <fstream>
using namespace std;
int main()
{
	ifstream testinput("16");
	ofstream testoutput("16.a");
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
	return 0;
}
