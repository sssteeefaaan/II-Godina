#include <stdio.h>
#include "vozilo.h"


int main()
{
	vozilo bmw;		

	vozilo *yugo;
	yugo = new vozilo;

	bmw.ukljuci();

	printf ("\n\nKarakteristike bmw-a: \n");
	bmw.ispisiKarakteristike();

	printf ("\n\nKarakteristike yuga: \n");
	yugo->ispisiKarakteristike();

	delete yugo;
	return 0;

}