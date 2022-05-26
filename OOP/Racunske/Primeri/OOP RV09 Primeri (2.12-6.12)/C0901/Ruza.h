#pragma once
#include "Objekat.h"
#include "Tabla.h"


class Ruza :public Objekat
{
public:
	Ruza(Tabla* ptr, int i, int j);
	Ruza(int i, int j) :Objekat(i, j)
	{
		c = '@';
		energy = 10;
	}
	void Dobro();
	void Zlo();
};