#include "Krug.h"

Krug::Krug(void)
{
}

Krug::~Krug(void) // nece li puci ovo? Ocigledno ne.... okej
{
}


std::ostream& Krug::stampaj(std::ostream& out) const
{
	return out << r;
}
