#include "Vektor.h"
#include "RacionalanBroj.h"
#include <fstream.h>

void main()
{
	Vektor< int, 10 > v1;
	try
	{
		v1.ucitajBin( "INTVEK.dat" );
	}
	catch ( Greska g )
	{
		cout << "Ulazna datoteka nije otvorena, unesite elemente celobrojnog vektora." << endl;
		v1.ucitajStd();
	}
	v1.upisiTxt( "INTVEK.txt" );
	cout << "Minimalni element celobrojnog vektora je: " << v1.min() << endl;

	Vektor< RacionalanBroj, 15 > v2;
	try
	{
		v2.ucitajBin( "RBVEK.dat" );
	}
	catch ( Greska g )
	{
		cout << "Ulazna datoteka nije otvorena, unesite elemente vektora racionalnih brojeva." << endl;
		v2.ucitajStd();
	}
	v2.upisiTxt( "RBVEK.txt" );
	try
	{
		cout << "Minimalni element vektora racionalnih brojeva je: " << v2.min() << endl;
	}
	catch ( Greska g )
	{
		cout << "Vektor racionalnih brojeva sadrzi nedefinisane elemente." << endl;
	}
}