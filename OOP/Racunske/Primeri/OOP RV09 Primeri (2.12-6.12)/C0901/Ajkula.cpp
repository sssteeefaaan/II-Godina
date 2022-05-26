#include "Ajkula.h"

Ajkula::Ajkula(Tabla* ptr, int i, int j) : Objekat(ptr, i, j)
{
	c = '~'; energy = 80;
}

void Ajkula::Dobro()
{
	energy += 25;
}

void Ajkula::Zlo()
{
	p->PromeniSusedima(-45, r - 1, k - 1);
}