// Kupa.cpp: implementation of the Kupa class.
//
//////////////////////////////////////////////////////////////////////

#include "Kupa.h"
#include <math.h>

//////////////////////////////////////////////////////////////////////
// Construction/Destruction
//////////////////////////////////////////////////////////////////////

Kupa::Kupa(float pp, float visina)
: Krug( pp ), H( visina )
{
	
}

Kupa::~Kupa()
{

}

float Kupa::povrsina()
{
	return Krug::povrsina()+3.14*r*sqrt(r*r+H*H);
}

float Kupa::zapremina()
{
	return Krug::povrsina()*H;
}
