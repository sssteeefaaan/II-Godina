// trougao1.cpp – Izracunavanje površine trougla.

#include <math.h>
#include <iostream>
using namespace std;

// Opšti trougao.
double P(double a, double b, double c) {
	if (a>0 && b>0 && c>0 && a+b>c && b+c>a && c+a>b) 
	{
		double s = (a + b + c) / 2;
		return sqrt(s * (s-a) * (s-b) * (s-c));
	} 
	else 
	{
		return -1;
	}
}

// Jednakokraki trugao.
inline double P(double a, double b) 
{ return P(a, b, b); }

// Jednakostranicni trougao.
inline double P(double a) 
{ return P(a, a, a); }

// Glavna funkcija.
int main() {
	while (true) {
		cout << "Vrsta (1, 2, 3, 0)? "; 
		int k; cin >> k;
		if (k<1 || k>3) break;

		double a, b, c, s;
		switch (k) {
			case 1: cout << "a? ";     cin >> a;
				s = P(a);       break;
			case 2: cout << "a,b? ";   cin >> a >> b;
				s = P(a, b);    break;
			case 3: cout << "a,b,c? "; cin >> a >> b >> c;
				s = P(a, b, c); break;
		}
		if (s > 0)
			cout << "P= " << s << endl;
		else
			cout << "Greska!\n";
	}
	return 0;
}