#include "Transport.h"

void Transport::povecajDotokGoriva()
{
	this->brzina++;
}

void Transport::smanjiDotokGoriva()
{
	if (this->brzina > 0) this->brzina--;
}

void Transport::ubrzaj()
{
	povecajDotokGoriva();
}

void Transport::uspori()
{
	smanjiDotokGoriva();
}
