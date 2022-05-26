#include "Vektor.h"
#include <iostream>
using namespace std;

void main()
{
	Vektor a(5);
	Vektor aa = 6;
	cin >> a;
	Vektor	b = 3.5 * a;

	4.6*b;

	Vektor& c = a * (2.4 * b);	

	cout << b << c;	
	cout << b[2] << " " << c[-4] << " " << a[6];

	Vektor d(b);
	d = 3;
	cout << d << endl;

	Complex n(3.5, 3.7);
	d = n;
	cout << d << endl;
}
