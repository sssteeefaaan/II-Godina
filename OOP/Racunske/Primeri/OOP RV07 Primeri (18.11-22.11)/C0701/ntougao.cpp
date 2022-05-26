#include "ntougao.h"

ntougao::ntougao(int n)
{
	br_temena=n;
	duzina=new float [n];
}

ntougao::~ntougao()
{
	delete [] duzina;
}

float ntougao::obim()
{
	float o=0;
	for (int i=0; i<br_temena; i++)
		o+=duzina[i];
	return o;
}

istream& operator>>( istream& in, ntougao& nt )
{
	for (int i=0; i<nt.br_temena; i++ )
		in >> nt.duzina[i];
	return in;
}
