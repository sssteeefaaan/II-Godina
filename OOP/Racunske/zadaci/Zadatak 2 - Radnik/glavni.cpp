#include "radnik.h"
#include <iostream>
using namespace std;

void main()
{
	int n; // broj radnika

	cout << " Unesi broj radnika: ";
	cin >> n;

	Radnik::br_radnika = n;

	cout << "Unesi cenu rada";

	cin >> Radnik::cena_rada;

	cout << "Unesi cenu prevoza";

	cin >> Radnik::cena_prevoza;

	Radnik* radnik_niz = new Radnik[n];

	Radnik a[100];

	int at[40];

	

	for (int i = 0; i < n; i++)
	{
		radnik_niz[i].input();
	}


	for ( int i = 0; i < n; i++)
	{
		radnik_niz[i].output();
	}


	cout << Radnik::prevoz() << endl;

	delete[] radnik_niz;

}