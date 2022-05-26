#pragma once
#include "Objekat.h"
#include "Tabla.h"


class Ajkula :public Objekat
{
public:
	Ajkula(Tabla* ptr, int i, int j);
	Ajkula(int i, int j) :Objekat(i, j)
	{
		c = '~';
		energy = 80;
	}
	void Dobro();
	void Zlo();
};