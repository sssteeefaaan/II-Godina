#include "PoljeSaMinom.h"


PoljeSaMinom::PoljeSaMinom(void)
{
}


PoljeSaMinom::~PoljeSaMinom(void)
{
}

OsnovniObjekat* PoljeSaMinom::Operacija1()
{
	return 0;
}

OsnovniObjekat* PoljeSaMinom::Operacija2()
{
	return new NeotkrivenoPolje(this->DaLiJeMina(), this->VratiBrojOkolnihMina());		
}