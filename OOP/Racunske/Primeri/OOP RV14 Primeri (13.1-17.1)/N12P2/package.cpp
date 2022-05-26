#include "package.h"
#include <string.h>
#pragma once

package::package()
{
	strcpy(naziv,"");
	kolicina=0;
}

package::package(char* x, float n)
{
	strcpy(naziv,x);
	if(n<0)
		throw "Pokusaj kreiranja objekta sa kolicinom manjom od 0";
	kolicina=n;
}

void package::operator =(float n)
{
	if(n<0)
		throw "Pokusaj kreiranja objekta sa kolicinom manjom od 0";
	kolicina=n;
}

ostream& operator<<(ostream& out, package& p)
{
	
	out<<p.naziv<<" "<<p.kolicina<<" ";
	return out;
}

istream& operator>>(istream& in, package& p)
{
	in>>p.naziv>>p.kolicina;
	if(p.kolicina<0)
		throw "Uneta kolicina manja od 0";
	return in;
}

bool package::operator >(float n)
{
	return kolicina>n;
}