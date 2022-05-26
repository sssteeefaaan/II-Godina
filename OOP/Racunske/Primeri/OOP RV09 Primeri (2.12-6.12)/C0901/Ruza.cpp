#include "Ruza.h"
Ruza::Ruza(Tabla * ptr, int i, int j) : Objekat(ptr, i, j)
{
	c = '@'; energy = 10;
}

void Ruza::Dobro()
{
	p->PromeniSusedima(11, r - 1, k - 1);
}

void Ruza::Zlo()
{
	energy += 12;
}