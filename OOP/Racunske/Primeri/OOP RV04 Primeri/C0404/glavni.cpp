#include "Poligon.h"
#include <math.h>
#include <iostream>
using namespace std;
 
void main() 
{
	Poligon z;
    Poligon x(3);
    x.ucitaj();
    x.obim();
    x.prikazi();

	Poligon y(x);
	//y.ucitaj();
	y.obim();
	int s = y.vratiBrojTemena();

	z.kopiraj(y);
	z.obim();

	Poligon q = 5;
	q.ucitaj();
	z.prikazi();

	z = q;
	z.prikazi();

	Poligon t = x + q + q + x;
	t.prikazi();
}