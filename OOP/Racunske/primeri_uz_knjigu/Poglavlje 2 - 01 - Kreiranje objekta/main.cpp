#include <stdio.h>
#include "vozilo.h"


void main()
{
	vozilo bmw;			//koristi default konstruktor, tako da je max_brzina = 180

	vozilo *yugo;
	yugo = new vozilo();	//koristi default konstruktor, tako da je max_brzina = 180

	bmw.ukljuci();

	printf ("\n\nKarakteristike bmw-a: \n");
	bmw.ispisiKarakteristike();

	printf ("\n\nKarakteristike yuga: \n");
	yugo->ispisiKarakteristike();

}