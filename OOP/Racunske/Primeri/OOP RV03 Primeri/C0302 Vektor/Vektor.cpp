#include "Vektor.h"

Vektor::Vektor( int velicina )
{
	this->n = velicina;
	niz = new int[this->n];
}


Vektor ::~Vektor()
{
	if (niz != 0)
		delete[] niz;
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

int& Vektor::vratiElement(int index)
{
	return niz[index];
}

Vektor* Vektor::saberi(Vektor* v2)
{
	int minDuzina = this->n < v2->n ? this->n : v2->n;
	Vektor* ret = new Vektor(minDuzina);

	for(int i = 0; i < ret->n; i++)
	{
		ret->niz[i] = niz[i] + v2->niz[i];
	}
	return ret; 

}

