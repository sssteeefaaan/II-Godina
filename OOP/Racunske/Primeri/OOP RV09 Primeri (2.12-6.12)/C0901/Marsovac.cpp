#include "Marsovac.h"


Marsovac::Marsovac(Tabla * p, int i, int j) : Objekat(p, i, j)
{
	c = 'm'; energy = (int)exp((float)r*k);
}

void Marsovac::Dobro()
{
	p->PromeniIstim(r*((int)exp(1.0) + k), '@');
}

void Marsovac::Zlo()
{
	p->PromeniIstim(exp((exp(1.0) + r + k) / k), '~');
}
