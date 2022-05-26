#include "Objekat.h"
#include "Tabla.h"

void Objekat::Promeni(int x)
{
	energy += x;
	if (energy <= 0)
		p->Brisi(r - 1, k - 1);
}

Objekat::Objekat(Tabla * ptr, int i, int j)
{
	this->p = ptr;
	this->r = i + 1;
	this->k = j + 1;
}


Objekat::Objekat(int i, int j)
{
	r = i + 1;
	k = j + 1;
}
