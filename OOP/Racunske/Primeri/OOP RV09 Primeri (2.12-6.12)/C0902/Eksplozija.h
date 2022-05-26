#pragma once
#include "osnovniobjekat.h"
class Eksplozija :
	public OsnovniObjekat
{
public:
	Eksplozija(void);
	~Eksplozija(void);
	Eksplozija(int mina, int brOkolnihMina) 
		: OsnovniObjekat('*', mina, brOkolnihMina)
	{
	}
	
	OsnovniObjekat* Operacija1()
	{
		return 0;
	}

	OsnovniObjekat* Operacija2()
	{
		return 0;
	}
};

