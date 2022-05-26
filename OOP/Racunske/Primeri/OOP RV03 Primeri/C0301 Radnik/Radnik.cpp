#include "radnik.h"
#include <iostream>
using namespace std;

double Radnik::cena_prevoza;
int Radnik::br_radnika;
double Radnik::cena_rada;

double Radnik::prevoz()
{
	return (Radnik::br_radnika * Radnik::cena_prevoza);
}

void Radnik::input()
{
	cout<< "Unesi ime: ";
	cin >> ime;

	cout << "Unesi prezime: ";
	cin >> prezime;

	cout << "Unesi kss: ";
	cin >> kss;
}

void Radnik::output()
{
	cout << "Ime: " << ime << " Prezime: " << prezime;
	cout << "Plata: " << kss * Radnik::cena_rada << endl;
}