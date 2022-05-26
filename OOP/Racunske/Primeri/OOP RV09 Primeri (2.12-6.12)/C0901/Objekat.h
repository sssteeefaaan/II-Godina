#pragma once
#include <math.h>

class Tabla;

class Objekat
{
protected:
	char c;
	int r;
	int k;
	int energy;
	Tabla* p;

public:
	Objekat(Tabla* ptr, int i, int j);
	Objekat(int i, int j);
	virtual void Dobro() = 0;
	virtual void Zlo() = 0;
	void Promeni(int x);
	void Postavi(Tabla* ptr)
	{
		p = ptr;
	}
	char Karakter()
	{
		return c;
	}

	int Energy()
	{
		return energy;
	}

};



