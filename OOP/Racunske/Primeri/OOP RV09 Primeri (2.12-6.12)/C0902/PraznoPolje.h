#pragma once
#include "OsnovniObjekat.h"
class PraznoPolje : public OsnovniObjekat
{
public:
	PraznoPolje(void);
	~PraznoPolje(void);

	PraznoPolje(int mina, int brOkolnihMina) : OsnovniObjekat(' ', mina, brOkolnihMina)
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

