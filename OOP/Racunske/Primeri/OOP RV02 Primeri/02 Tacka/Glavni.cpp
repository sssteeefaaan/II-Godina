#include "Tacka.h"
#include <iostream>
using namespace std;

void main()
{
	Tacka t1;
	Tacka *pt;
	pt = new Tacka;

	float koorX, koorY;
	cout << "Unesite koordinate prve tacke." << endl;
	cin >> koorX >> koorY;
	t1.postaviNa( koorX, koorY );

	cout << "Unesite koordinate druge tacke." << endl;
	cin >> koorX >> koorY;
	pt->postaviNa( koorX, koorY );

	cout << "tacke su na rastojanju " << 
		t1.rastojanje( *pt ) << endl;

	// pt->rastojanje( t1 )

	t1.pomeriZa( 2.5, 2.5 );
	cout << "Prva tacka je sada na poziciji ( "
		<< t1.uzmiX() << "," << t1.uzmiY() << ")" << endl;
	
	delete pt;
}