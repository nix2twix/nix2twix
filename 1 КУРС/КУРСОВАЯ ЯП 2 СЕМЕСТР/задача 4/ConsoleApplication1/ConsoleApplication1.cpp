#include <iostream>
#include <cmath>
using namespace std;
class point
{
	double x, y;
public: point(double xx = 0, double yy = 0) 
{
	x = xx;
	y = yy;
}
	  double getx() { return x; } 
	  double gety() { return y; }
	  friend istream& operator >> (istream& input, point& p) 
	  {
		  input >> p.x >> p.y;
		  return input;
	  }
	  friend ostream& operator << (ostream& output, point& p)
	  {
		  output << "(" << p.x << ";" << p.y << ")";
		  return output;
	  }
	  point operator-(point b)
	  {
		  point res;
		  res.x = x - b.x;
		  res.y = y - b.y;
		  return res;
	  }
	  point operator+(point b)
	  {
		  point res;
		  res.x = x + b.x;
		  res.y = y + b.y;
		  return res;
	  }
	  double distanceSquare(point b)
	  {
		  return (x - b.x) * (x - b.x) + (y - b.y) * (y - b.y);
	  }
	  double pointBelong(point a, point b) //для прямой, заданной двумя точками
	  {
		  double x1 = a.x, x2 = b.x;
		  double y1 = a.y, y2 = b.y;
		  double eps = 0.000000001; //точность
		  if ((x - x1) * (y2 - y1) - (y - y1) * (x2 - x1) == eps) return 1; //принадлежит
		  else return 0; //не принадлежит
	  }
}; 
class line {
	int a, b, c;
public: line(int aa = 0, int bb = 0, int cc = 0)
{
	a = aa;
	b = bb;
	c = cc;
}
public: line(point p1, point p2)
{
	double x1, y1, x2, y2;
	x1 = p1.getx();
	x2 = p2.getx();
	y1 = p1.gety();
	y2 = p2.gety();
	b = x2 - x1;
	a = y2 - y1;
	c = x2*y1 - x1*y2;
}
public: line(double x1, double y1, double x2, double y2)
{
	b = x2 - x1;
	a = y2 - y1;
	c = x2 * y1 - x1 * y2;
}
	  friend istream& operator >> (istream& input, line& l)
	  {
		  input >> l.a >> l.b >> l.c;
		  return input;
	  }
	  friend ostream& operator << (ostream& output, line& l)
	  {
		  if ((l.b >= 0) & (l.c >= 0)) output << l.a << "x + " << l.b << "y + " << l.c;
		  if ((l.b < 0) & (l.c > 0)) output << l.a << "x - " << abs(l.b) << "y + " << l.c;
		  if ((l.b < 0) & (l.c < 0)) output << l.a << "x - " << abs(l.b) << "y - " << abs(l.c);
		  return output;
	  }  
	  double getA() { return a; }
	  double getB() { return b; }
	  double getC() { return c; }
}; 
class vektor
{
	double X, Y;
	point A, B;
public: vektor(point P1(0,0), point P2(0,0))
{
	A = P1;
	B = P2;
}
public: vektor(double XX, double YY) 
{
	X = XX;
	Y = YY;
}
	  double getX() { return X; }
	  double getY() { return Y; }
	 friend istream& operator >> (istream& input, vektor&P1)
	  {
		  input >> P1.X >> P1.Y;
		  return input;
	  }
	  friend ostream& operator << (ostream& output, vektor& P1)
	  {
		  output << "(" << P1.X << ";" << P1.Y << ")";
		  return output;
	  }
	  double modul()
	  {
		  return sqrt(X * X + Y * Y);
	  }
	  double kosoe_pr(vektor b)
	  {
		  return a.getX()*b.Y - b.X * a.getY();
	  }
	  double skalyar_pr(vektor b)
	  {
		  return b.X*a.getX() + b.Y*a.getY();
	  }
};
int main ()
{
	double eps = 1e-8;
	point P1, P2, M;
	cin >> P1 >> P2 >> M;
	vektor P1P2(P1, P2), P1M(P1, M), MP1(M, P1), MP2(M, P2);
	cout << P1P2.modul();
	cout << P1P2.kosoe_pr(P1M);
	cout << "\n" << MP2.skalyar_pr(MP1);
	//if ((P1P2.kosoe_pr(P1M) <= eps)&(MP2.skalyar_pr(MP1) <= eps)) cout << "YES";
	else cout << "NO";
	return 0;
}

