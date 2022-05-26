#pragma once
#include "OsnovniObjekat.h"
#include <fstream>
#include <iostream>
using namespace std;

class Polje
{
	int velicina;
	OsnovniObjekat*** matrica;
public:
	Polje(void);
	~Polje(void);
	void ObrisiMatricu();
	void UcitajIzFajla(char* imeFajla);
	int DaLiJeMina(int x, int y);
	void StampajOtkrivenoPolje();	
	void Stampaj();
	int IzvrsiOperaciju(int x, int y, int op, int minecheck = 0);
	int BrojNeotkrivenihPolja();
	void ProslediOperaciju(int x, int y);
};

