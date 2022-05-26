

#ifndef _VEKTOR
#define _VEKTOR

#include "Greska.h"
#include <fstream.h>

template < class T, int velicina >
class Vektor
{
	T niz[velicina];
public:
	T min();
	void ucitajBin( char* imeDatoteke );
	void ucitajStd();
	void upisiTxt( char* imeDatoteke);
};

template < class T, int velicina >
T Vektor< T, velicina> :: min()
{
	T minel = niz[0];
	for ( int i=0; i<velicina; i++ )
		if ( niz[i] < minel )
			minel = niz[i];
	return minel;
}

template < class T, int velicina >
void Vektor< T, velicina> :: ucitajBin( char* imeDatoteke )
{
	ifstream uldat( imeDatoteke );
	if ( !uldat.good() )
		throw DATOTEKA_NIJE_OTVORENA;
	uldat.read( ( char* ) this, velicina * sizeof( T ) );
	uldat.close();
}

template < class T, int velicina >
void Vektor< T, velicina> :: ucitajStd()
{
	for ( int i=0; i<velicina; i++ )
		cin >> niz[i];
}

template < class T, int velicina >
void Vektor< T, velicina> :: upisiTxt( char* imeDatoteke )
{
	ofstream izdat( imeDatoteke );
	for ( int i=0; i<velicina; i++ )
		izdat << niz[i] << " ";
	izdat.close();
}

#endif