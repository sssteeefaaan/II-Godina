#pragma once
#include <iostream>
using namespace std;

class OsnovniObjekat
{
protected:
	char simbol;
	int mina;
	int brojOkolnihMina;
public:
	OsnovniObjekat(void);
	virtual ~OsnovniObjekat(void);

	OsnovniObjekat(char s, int m)
	{		
		PostaviVrednosti(s, m, 0);
	}

	OsnovniObjekat(char s, int m, int okolne)
	{
		PostaviVrednosti(s, m, okolne);
	}

	void PostaviVrednosti(char s, int m, int okolne)
	{
		this->simbol = s;
		this->mina = m;
		this->brojOkolnihMina = okolne;
	}

	void Print()
	{
		cout << simbol;
	}

	char VratiSimbol()
	{
		return simbol;
	}

	virtual OsnovniObjekat* Operacija1() = 0;
	virtual OsnovniObjekat* Operacija2() = 0;

	OsnovniObjekat* IzvrsiOperaciju(int index)
	{
		if (index == 1)
			return Operacija1();
		
		return Operacija2();
	}

	void PostaviBrojOkolnihMina(int nB)
	{
		this->brojOkolnihMina = nB;
	}

	int VratiBrojOkolnihMina()
	{
		return this->brojOkolnihMina;
	}

	int DaLiJeMina()
	{
		return this->mina;
	}
};

