#include "oduzimanje.h"
#include "sabiranje.h"

oduzimanje::oduzimanje(char* novinaziv, int broj)
	: operacija(novinaziv, broj)
{
}

oduzimanje::oduzimanje(int broj)
	:operacija("oduzimanje", broj)
{
}

oduzimanje::~oduzimanje()
{
}

 int oduzimanje::DoOperation(int op1)
{
	return op1 - this->drugioperand;
}

operacija* oduzimanje::suprotna()
{
	return new sabiranje(this->drugioperand);
}
