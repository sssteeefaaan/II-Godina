#include "NeotkrivenoPolje.h"


NeotkrivenoPolje::NeotkrivenoPolje(void)
{
}


NeotkrivenoPolje::~NeotkrivenoPolje(void)
{
}

OsnovniObjekat* NeotkrivenoPolje::Operacija1()
{
	if (this->mina)
		return new Eksplozija(this->DaLiJeMina(), 
								this->VratiBrojOkolnihMina());

	if (this->brojOkolnihMina == 0)
		return new PraznoPolje(this->DaLiJeMina(), 
								this->VratiBrojOkolnihMina());
	else
		return new PoljeSaBrojem(this->DaLiJeMina(), 
								this->VratiBrojOkolnihMina());
}

OsnovniObjekat* NeotkrivenoPolje::Operacija2()
{
	return new PoljeSaMinom(this->DaLiJeMina(), 
							this->VratiBrojOkolnihMina());		
}
