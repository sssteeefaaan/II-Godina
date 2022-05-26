#include "Vektor.h"
#include <iostream>
using namespace std;

void main()
{
	Vektor a(5);	
	a.in();

	Vektor b(a);
	b.out();

	Vektor& c = a;		
	c.out();

	Vektor d(5);
	d = a;

	a.saberi(c)->out();  // !!!!!!!!!!!!!!!!!!!!!!!!!
	a.saberi(&b).out();
	Vektor* f = a.saberi(b)->saberi(&c).saberi(d);
	cout << (*f)[2] << " " << c[-4] << " " << a[6];

	delete f;
}
