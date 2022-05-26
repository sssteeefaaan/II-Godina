#include "Matrica.h"
#include <iostream.h>



void main()
{
	Matrica a(2,3), b(3,4);

	cout << "ucitajte elemente prve matrice" << endl;
	cin >> a;

	cout << "unesite elemente druge matrice" << endl;
	cin >> b;

	cout << "proizvod matrica je: " << endl;
	Matrica c;
	c=a*b;
	cout << c;
}