// Vektor.cpp: implementation of the Vektor class.
//
//////////////////////////////////////////////////////////////////////

#include "Vektor.h"
#include "Izuzetak.h"

//////////////////////////////////////////////////////////////////////
// Construction/Destruction
//////////////////////////////////////////////////////////////////////

Vektor::Vektor()
{
	velicina = 0;
	niz = 0;
}

Vektor::~Vektor()
{
	if ( niz != 0 )
		delete [] niz;
}

void Vektor::kreiraj( int donjaGranica, int gornjaGranica)
{

	if ( donjaGranica > gornjaGranica )
		throw NEKOREKTNE_GRANICE;
//		throw Izuzetak( "Donja granica je veca od gornje");
	velicina = gornjaGranica - donjaGranica+1;
	gg = gornjaGranica;
	dg = donjaGranica;
	niz = new double[ velicina ];
	if ( niz == 0 )
		throw POPUNJENA_MEMORIJA;
//		throw Izuzetak( "Nema mesta u memoriji" );
}



Vektor::Vektor( int gornjaGranica )
{
	kreiraj( 1, gornjaGranica );

}

Vektor::Vektor( int donjaGranica, int gornjaGranica )
{
	kreiraj( donjaGranica, gornjaGranica );
}

Vektor::Vektor( const Vektor& vektor )
{
	if ( vektor.velicina > 0 )
	{
		kreiraj( vektor.dg, vektor.gg );
		for ( int i=0; i<velicina; i++ )
			niz[i] = vektor.niz[i];
	}
	else
		throw VEKTOR_JE_PRAZAN;
//		throw Izuzetak("Vektor je prazan" );
}

Vektor& Vektor::operator=( const Vektor& desni )
{
	if ( this != &desni )
	{
		if ( velicina != 0 )
			delete [] niz;
		if ( desni.velicina > 0 )
		{
			kreiraj( desni.dg, desni.gg );
			for ( int i=0; i< velicina; i++ )
				niz[i] = desni.niz[i];
		}
		else 
			throw VEKTOR_JE_PRAZAN;
//			throw Izuzetak("Vektor je prazan" );
	}
	return *this;
}

double& Vektor::operator[]( int index )
{
	if ( velicina == 0 )
		throw VEKTOR_JE_PRAZAN;
//		throw Izuzetak("Vektor je prazan" );
	if ( index < dg || index > gg )
		throw LOS_INDEX;
//		throw Izuzetak("Index je van dozvoljenih granica");
	return niz[ index - dg ];
}

double operator*( const Vektor& levi, const Vektor& desni )
{
	if ( levi.velicina == 0 || desni.velicina == 0 )
		throw Vektor::Greska::VEKTOR_JE_PRAZAN;
//		throw Izuzetak("Vektor je prazan" );
	if ( levi.velicina != desni.velicina )
		throw Vektor::Greska::RAZLICITE_VELICINE;
//		throw Izuzetak("Vektori ne mogu da se pomnoze");
	double proizvod = 0;
	for ( int i=0; i<levi.velicina; i++ )
		proizvod += levi.niz[i]*desni.niz[i];
	return proizvod;
}








