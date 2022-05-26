// trougao.cpp: implementation of the trougao class.
//
//////////////////////////////////////////////////////////////////////

#include "trougao.h"
#include<math.h>

//////////////////////////////////////////////////////////////////////
// Construction/Destruction
//////////////////////////////////////////////////////////////////////

trougao::trougao():
ntougao(3)
{		
		

}

trougao::~trougao()
{

}
float trougao:: povrsina()
{ float p;
	float a=duzina[0];
		float b=duzina[1];
			float c=duzina[2];
			float s=(a+b+c)/2;
	p=sqrt(s*(s-a)*(s-b)*(s-c));

	return p;

}
