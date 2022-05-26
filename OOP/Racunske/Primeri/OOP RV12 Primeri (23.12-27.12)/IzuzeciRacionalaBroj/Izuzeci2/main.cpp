#include "Vektor.h"
#include "RacionalanBroj.h"
#include <fstream>

void main()
{
	Vektor< int, 10 > v1;
	try
	{		
		/*Greska s = Greska::DATOTEKA_NIJE_OTVORENA;
		if (s == Greska::DATOTEKA_NIJE_OTVORENA)
			return;*/
		v1.ucitajBin( "INTVEK.dat" );
		int s = 0;
		s++;
		s += 2;
		cout << s << endl;
	}
	catch ( Greska g )
	{
		cout << g;
		cout << "Ulazna datoteka nije otvorena, unesite elemente celobrojnog vektora." << endl;
		v1.ucitajStd();
	}
	catch (int s)
	{
		cout << s;
	}
	catch (...)
	{
		cout << "Nepoznato";
	}

	v1.upisiTxt( "INTVEK.txt" );
	v1.upisiBin( "INTVEK.dat" );

	cout << "Minimalni element celobrojnog vektora je: " << v1.min() << endl;

	Vektor< RacionalanBroj, 5 > v2;
	try
	{
		v2.ucitajTxt("RBVEK.txt");
		//v2.ucitajBin("INTVEK.dat");
		v2.ucitajBin( "RBVEK.dat" );
	}
	catch ( Greska g )
	{
		cout << "Ulazna datoteka nije otvorena, unesite elemente vektora racionalnih brojeva." << endl;
		v2.ucitajStd();
	}

	v2.upisiTxt( "RBVEK.txt" );
	v2.upisiBin( "RBVEK.dat" );

	try
	{
		cout << "Minimalni element vektora racionalnih brojeva je: " << v2.min() << endl;
	}
	catch ( Greska g )
	{
		cout << "Vektor racionalnih brojeva sadrzi nedefinisane elemente." << endl;
	}
}