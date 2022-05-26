#pragma once
#include "Objekat.h"
#include "Tabla.h"


class Marsovac : public Objekat
{
public:
	Marsovac(Tabla* p, int i, int j);
	Marsovac(int i, int j) :Objekat(i, j)
	{
		c = 'm';
		energy = (int)exp((float)r*k);
	}
	void Dobro();
	void Zlo();

};

