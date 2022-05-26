#pragma once
#include "OsnovniObjekat.h"
#include "NeotkrivenoPolje.h"
//#include "PraznoPolje.h"

class PoljeSaMinom
	: public OsnovniObjekat
{
public:
	PoljeSaMinom(void);
	~PoljeSaMinom(void);

	PoljeSaMinom(int mina, int brOkolnihMina) 
		: OsnovniObjekat('X', mina, brOkolnihMina)
	{
	}

	OsnovniObjekat* Operacija1();
	
	OsnovniObjekat* Operacija2();
	
};

