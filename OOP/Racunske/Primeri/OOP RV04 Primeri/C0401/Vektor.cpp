#include "Vektor.h"

Vektor::Vektor( int velicina )
{
	this->n = velicina;
	niz = new int[this->n];
}

Vektor :: Vektor ( const Vektor& v )
{
	this->n = v.n;
	niz = new int[v.n];

	for(int i = 0; i < n; i++)
		niz[i] = v.niz[i];
}

Vektor ::~Vektor()
{
	if (niz != 0)
		delete[] niz;
}


Vektor& Vektor::operator=(const Vektor& v)
{
	if ( this != &v )
	{
		n = v.n;
		delete [] niz;

		niz = new int[n];
		for ( int i=0; i<n; i++ )
			niz[i] = v.niz[i];
	}
	return *this;
}



int& Vektor :: operator[](int n)
{	
	return niz[n];
}

void Vektor :: in()
{
	for(int i = 0; i < this->n; i++)
		cin >> this->niz[i];

	
}

void Vektor :: out()
{
	for(int i = 0; i < n; i++)
		cout << niz[i] << " ";
	cout << endl;
	
}

Vektor* Vektor::saberi(Vektor v2)
{
	int minDuzina = this->n < v2.n ? this->n : v2.n;
	Vektor* ret = new Vektor(minDuzina);

	for(int i = 0; i < ret->n; i++)
	{
		ret->niz[i] = this->operator[](i) + v2[i];
	}
	return ret;          // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

}

Vektor Vektor::saberi(Vektor* v2)
{
	int minDuzina = this->n < v2->n ? this->n : v2->n;
	Vektor ret(minDuzina);

	for(int i = 0; i < ret.n; i++)
	{
		ret[i] = (*this)[i] + (*v2)[i];
	}
	return ret;

}