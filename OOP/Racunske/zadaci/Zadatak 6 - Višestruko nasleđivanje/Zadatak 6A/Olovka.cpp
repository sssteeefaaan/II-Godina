// Visak.cpp: implementation of the Visak class.
//
//////////////////////////////////////////////////////////////////////

#include "Olovka.h"

//////////////////////////////////////////////////////////////////////
// Construction/Destruction
//////////////////////////////////////////////////////////////////////

Olovka::Olovka(float r, float H1, float H2)
: Krug(r), Valjak(r,H1), Kupa(r,H2)
{

}

Olovka::~Olovka()
{

}

float Olovka::povrsina()
{
	return Valjak::povrsina() + Kupa::povrsina() - 2*3.14*Valjak::r*Valjak::r;
}

float Olovka::zapremina()
{
	return Valjak::zapremina()+Kupa::zapremina();
}
