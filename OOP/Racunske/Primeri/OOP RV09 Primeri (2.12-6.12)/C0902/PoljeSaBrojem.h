#pragma once
#include "OsnovniObjekat.h"
class PoljeSaBrojem : public OsnovniObjekat
{
public:
	PoljeSaBrojem(void);
	~PoljeSaBrojem(void);

	PoljeSaBrojem(int mina, int brOkolnihMina) 
		: OsnovniObjekat(48 + brOkolnihMina, mina, brOkolnihMina)
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

