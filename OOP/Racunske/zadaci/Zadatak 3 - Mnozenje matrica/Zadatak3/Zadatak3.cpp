#include "Matrica.h"
#include <iostream>
using namespace std;


void main()
{
	Matrica a(2,3), b(3,4);

	cout << "ucitajte elemente prve matrice" << endl;
	a.ucitaj();

	cout << "unesite elemente druge matrice" << endl;
	b.ucitaj();

	cout << "proizvod matrica je: " << endl;
	a.pomnozi( b ).prikazi();

}