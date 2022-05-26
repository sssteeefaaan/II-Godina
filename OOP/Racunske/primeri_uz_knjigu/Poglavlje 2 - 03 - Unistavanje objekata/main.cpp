#include <stdio.h>
#include "vozilo.h"


void main()
{
	vozilo bmw(250);		//koristi default konstruktor, tako da je max_brzina = 180
	vozilo *yugo;
	yugo = new vozilo();	//koristi default konstruktor, tako da je max_brzina = 180

	delete yugo;			// unistavanje objekta yugo
	// delete bmw;			// ovako nije moguce unistiti objekat bmw
	// kraj bloka naredbi - ovde se automatski unistava objekat bmw
}