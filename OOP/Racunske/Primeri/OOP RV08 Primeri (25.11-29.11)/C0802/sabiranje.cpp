#include "sabiranje.h"

sabiranje::sabiranje(char* novinaziv, int broj)
	: operacija(novinaziv, broj)
{
}

sabiranje::sabiranje(int broj)
	:operacija("sabiranje", broj)
{
}

sabiranje::~sabiranje()
{
}



