#include <iostream.h>
#include "Vektor.h"

void main()
{
	Vektor<int, 12> celi;		// vektor celih brojeva
	Vektor<float, 10> realni;	// vektor realnih brojeva
	int i;

	celi[4] = 4;
	realni[2] = (float) 3.4;

	cout << "Vektor celih brojeva\n";
	// stampa vrednosti vektora celih brojeva
	for (i = 0; i < celi.duzina; i++) cout << celi[i] << endl;
	
	cout << "Vektor realnih brojeva\n";
	// stampa vrednosti vektora realnih brojeva
	for (i = 0; i < realni.duzina; i++) cout << realni[i] << endl;

}