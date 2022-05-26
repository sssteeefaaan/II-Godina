#include <stdio.h>
#include "vozilo.h" 

void main()
{
	// postoje dve operacije koje su "deljive" - i za obe je main() prijateljska funkcija

	vozilo bmw(230), ferrari(340);	// bmw-ova max. brzina je 230, a ferrarijeva 340

	if (uporediBrzine(bmw, ferrari)) printf("Bmw je brzi\n"); // ukoliko je rezultat f-je 1 onda je prvi brzi (BMW)
	else printf ("Ferrari je brzi\n");

	ispisiKarakteristike(ferrari);
}