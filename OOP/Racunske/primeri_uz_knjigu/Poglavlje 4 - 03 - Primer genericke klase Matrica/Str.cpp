#include "Str.h"


STR::STR(int i)
{
	s=new char[i];
}
STR::~STR()
{
	delete [] s;
}
istream& operator>>(istream& t,STR& s1)
{
	return t>>s1.s;
}
ostream& operator<<(ostream& t,STR& s2)
{
	return t<<s2.s;
}
int operator==(STR& s1,STR& s2)
{
	if (strcmp(s1.s,s2.s)==0) return 1;
	else return 0;
}
