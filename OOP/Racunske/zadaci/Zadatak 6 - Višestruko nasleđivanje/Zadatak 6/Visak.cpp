// Visak.cpp: implementation of the Visak class.
//
//////////////////////////////////////////////////////////////////////

#include "Visak.h"

//////////////////////////////////////////////////////////////////////
// Construction/Destruction
//////////////////////////////////////////////////////////////////////

Visak::Visak(float r1, float H1, float r2, float H2)
: Valjak(r1,H1), Kupa(r2,H2)
{

}

Visak::~Visak()
{

}

float Visak::povrsina()
{
	return Valjak::povrsina() + Kupa::povrsina() - 2*3.14*Valjak::r*Valjak::r;
}

float Visak::zapremina()
{
	return Valjak::zapremina()+Kupa::zapremina();
}
