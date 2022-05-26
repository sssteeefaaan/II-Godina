#pragma once
#include "Objekat.h"

class Objekat;

class Tabla
{
	Objekat*** m;
	int n;

public:
	Tabla(int n);
	void PromeniSusedima(int x, int i, int j);
	void PromeniIstim(int x, char c);
	void Brisi(int i, int j);	
	void Postavi(int i, int j, Objekat* novi);
	void Ispisi();
	void IspisiIVrednosti();
	void SviDobro();
	void SviZlo();
	void JedanDobro(int i, int j);
	void JedanZlo(int i, int j);
	int GetN()
	{
		return n;
	}
	bool DaLiPripadaTabli(int i, int j)
	{
		if (i < 0 || i > this->n - 1)
			return false;

		if (j < 0 || j> this->n - 1)
			return false;

		return true;
	}
	~Tabla();
	
};

