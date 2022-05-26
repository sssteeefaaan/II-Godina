// Animal.cpp: implementation of the Animal class.
//
//////////////////////////////////////////////////////////////////////

#include "Animal.h"

//////////////////////////////////////////////////////////////////////
// Construction/Destruction
//////////////////////////////////////////////////////////////////////

Animal::Animal()
{
	itsWeight = 0;
}

Animal::Animal(int wt):itsWeight(wt)
{
}

Animal::~Animal()
{

}

int Animal::GetWeight() const
{
	return this->itsWeight;
}

void Animal::SetWeight(int wt)
{
	this->itsWeight = wt;
	return;
}

void Animal::Display()
{
	cout << this->itsWeight;
}

ostream& operator << (ostream& izlaz, const Animal& an)
{
	izlaz << an.GetWeight() << "\t";
	return izlaz;
}