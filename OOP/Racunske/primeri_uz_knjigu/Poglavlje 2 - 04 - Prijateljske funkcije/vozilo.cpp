#include "vozilo.h"

#include <stdio.h>


// standardni (default) konstruktor
vozilo::vozilo()
{
	this->brzina = 0;
	this->max_brzina = 180;
	this->stanje = 0;
}


vozilo::vozilo(int max)
{
	this->brzina = 0;
	this->max_brzina = max;
	this->stanje = 0;
}

void vozilo::ukljuci()
{
	this->stanje = 1;
}

void vozilo::iskljuci()
{
	this->stanje = 0;
}

void vozilo::ubrzaj()
{
	if (this->brzina < this->max_brzina) this->brzina ++;
}

void vozilo::uspori()
{
	if (this->brzina > 0) this->brzina --;
}


void ispisiKarakteristike(vozilo& v)
{
	printf ("max. brzina: %d \n", v.max_brzina);
	printf ("trenutna brzina: %d \n", v.brzina);
	printf ("stanje motora: %d \n", v.stanje);
}
