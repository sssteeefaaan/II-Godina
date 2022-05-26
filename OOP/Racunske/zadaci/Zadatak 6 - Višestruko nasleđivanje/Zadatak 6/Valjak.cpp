// Valjak.cpp: implementation of the Valjak class.
//
//////////////////////////////////////////////////////////////////////

#include "Valjak.h"

//////////////////////////////////////////////////////////////////////
// Construction/Destruction
//////////////////////////////////////////////////////////////////////

Valjak::Valjak(float pp, float visina)
: Krug( pp ), H( visina )
{
	
}

Valjak::~Valjak()
{

}

float Valjak::povrsina()
{
	return 2*Krug::povrsina()+obim()*H;
}

float Valjak::zapremina()
{
	return Krug::povrsina()*H;
}

