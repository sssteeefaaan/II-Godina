#include "Vektor.h"
#include <iostream>
using namespace std;

void main()
{
	Vektor a(5);	
	a.in();

	Vektor b(3);
	b.in();

	Vektor* c = a.saberi(&b);

	b.vratiElement(2) = 100;
	
	cout << b.vratiElement(2) << " " << c->vratiElement(-4) << " " << a.vratiElement(6);

	delete c;

}
