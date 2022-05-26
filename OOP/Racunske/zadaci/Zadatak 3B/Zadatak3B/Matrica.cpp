// Matrica.cpp: implementation of the Matrica class.
//
//////////////////////////////////////////////////////////////////////

#include "Matrica.h"
#include <iostream.h>

//////////////////////////////////////////////////////////////////////
// Construction/Destruction
//////////////////////////////////////////////////////////////////////

Matrica::Matrica()
{
	m = n = 0;
	a = 0;
}

Matrica::~Matrica()
{
	if ( a != 0 )
	{
		for (int i=0; i<n; i++ )
			delete [] a[i];
		delete [] a;
	}
}

Matrica::Matrica(int brVrsta, int brKolona)
: n(brVrsta), m(brKolona)
{
	a = new int*[n];
	for ( int i=0; i<n; i++ )
		a[i] = new int[m];
}

Matrica::Matrica(const Matrica &mat)
: n(mat.n), m( mat.m )
{
	a = new int*[n];
	for ( int i=0; i<n; i++ )
		a[i] = new int[m];
	for ( i=0; i<n; i++ )
		for ( int j=0; j<m; j++ )
			a[i][j] = mat.a[i][j];
}

Matrica Matrica::operator*( const Matrica& desni )
{
	if ( m == desni.n )
	{
		Matrica rezultat( n, desni.m );
		for ( int i=0; i<rezultat.n; i++ )
			for ( int j=0; j<rezultat.m; j++ )
			{
				rezultat.a[i][j]=0;
				for ( int k=0; k<m; k++ )
					rezultat.a[i][j] += a[i][k]*desni.a[k][j];
			}
		return rezultat;
	}
	cout << "Matrice ne mogu da se pomnoze" << endl;
	Matrica rez;
	return rez;
}

Matrica& Matrica::operator=( const Matrica& desni )
{
	if ( this != &desni )
	{
		if ( a!=0)
		{
			for (int i=0; i<n; i++ )
				delete [] a[i];
			delete [] a;
		}
		n = desni.n;
		m=desni.m;
		if ( n!=0 )
		{
			a = new int*[n];
			for ( int i=0; i<n; i++ )
				a[i] = new int[m];
			for ( i=0; i<n; i++ )
				for ( int j=0; j<m; j++ )
					a[i][j] = desni.a[i][j];
		}
		else
			a=0;
	}
	return *this;
}

istream& operator>>(istream& ulaz, Matrica& mat)
{
	for( int i=0; i<mat.n; i++ )
		for ( int j=0; j<mat.m; j++ )
			ulaz >> mat.a[i][j];
	return ulaz;
}

ostream& operator<<(ostream& izlaz, const Matrica& mat)
{
	for( int i=0; i<mat.n; i++ )
	{
		for ( int j=0; j<mat.m; j++ )
			izlaz << mat.a[i][j] << "  ";
		izlaz << endl;
	}
	return izlaz;
}

