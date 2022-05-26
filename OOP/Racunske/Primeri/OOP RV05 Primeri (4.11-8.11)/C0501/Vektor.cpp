#include "Vektor.h"

void Vektor :: oslobodiMemoriju()
{
	if (this->niz != 0)
		delete[] this->niz;
}

void Vektor :: zauzmiMemoriju(int s)
{
	this->n = s;
	this->niz = new Complex[s];
}

void Vektor :: kopirajNiz(const Vektor& v)
{
	for(int i = 0; i < n; i++)
		niz[i] = v.niz[i];
}

Vektor::Vektor( int velicina )
{
	zauzmiMemoriju(velicina);
}

Vektor :: Vektor ( const Vektor& v )
{
	zauzmiMemoriju(v.n);
	kopirajNiz(v);
}

Vektor ::~Vektor()
{
	oslobodiMemoriju();
}

Vektor operator*( double levi, Vektor& desni)
{
	Vektor rezultat( desni.n );
	for ( int i=0; i<desni.n; i++ )
		rezultat.niz[i] = levi * desni.niz[i];
	return rezultat;
}

Vektor Vektor::operator*(const Vektor& desni)
{
	int rezDim = this->n < desni.n ? this->n : desni.n;
	Vektor rez(rezDim);

	for (int i = 0; i < rezDim; i++)
		rez.niz[i] = this->niz[i] * desni.niz[i];

	return rez;
}

istream& operator>>( istream& ulaz, Vektor& v)
{
	for(int i = 0; i < v.n; i++)
		ulaz >> v.niz[i];

	return ulaz;
}

Vektor& Vektor::operator=(const Vektor& v)
{
	if ( this != &v )
	{
		oslobodiMemoriju();
		zauzmiMemoriju(v.n);
		kopirajNiz(v);
	}
	return *this;
}

Vektor& Vektor::operator=(int t)
{
	for (int i = 0; i < this->n; i++)
	{
		niz[i].real = niz[i].imag = t;
	}

	return *this;
}

Vektor& Vektor::operator=(Complex ct)
{
	for (int i = 0; i < this->n; i++)
	{
		niz[i] = ct;
	}

	return *this;
}

ostream& operator<<( ostream& izlaz, Vektor& v)
{
	izlaz << endl;
	for(int i = 0; i < v.n; i++)
		izlaz << v.niz[i] << " ";
	izlaz << endl;
	return izlaz;
}

Complex Vektor :: operator[](int n)
{
	if (niz == 0 || n < 0 || n > this->n)
	{
		Complex toRet;
		return toRet;
	}

	return niz[n];
}
