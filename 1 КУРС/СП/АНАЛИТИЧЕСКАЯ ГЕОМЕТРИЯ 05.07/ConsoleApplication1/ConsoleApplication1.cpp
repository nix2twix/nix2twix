#include <iostream>
using namespace std;
int main()
{
	double x1, y1, x2, y2, x3, y3, x4, y4, k1, k2;
	double eps = 1e-8;
	cin >> x1 >> y1 >> x2 >> y2 >> x3 >> y3 >> x4 >> y4;
	//k1 = (y2 - y1) / (x2 - x1);
	//k2 = (y4 - y3) / (x4 - x3);
	if (abs((x4 - x3) * (y2 - y1) + (y4 - y3) * (x1 - x2)) <= eps) cout << "Parallel";
	else
		if (abs((y2 - y1) * (y4 - y3) + (x1 - x2) * (x3 - x4)) <= eps) cout << "Normal";
		else cout << "Intersect";
	return 0;
} 
