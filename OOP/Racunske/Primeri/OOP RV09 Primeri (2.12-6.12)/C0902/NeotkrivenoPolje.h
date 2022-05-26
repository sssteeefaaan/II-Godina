#pragma once
#include "OsnovniObjekat.h"
#include "PraznoPolje.h"
#include "Eksplozija.h"
#include "PoljeSaBrojem.h"
#include "PoljeSaMinom.h"

class NeotkrivenoPolje : public OsnovniObjekat
{
public:
	NeotkrivenoPolje(void);
	virtual ~NeotkrivenoPolje(void);

	NeotkrivenoPolje(int m) 
		: OsnovniObjekat('O', m)
	{
	}

	NeotkrivenoPolje(int mina, int brOkolnihMina) 
		: OsnovniObjekat(48 + brOkolnihMina, mina, brOkolnihMina)
	{
	}

	OsnovniObjekat* Operacija1();
	OsnovniObjekat* Operacija2();
	
};

