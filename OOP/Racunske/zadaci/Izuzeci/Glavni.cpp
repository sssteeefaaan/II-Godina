#include "Vektor.h"
#include <iostream.h>
#include "Izuzetak.h"

void main()
{
	try
	{
		Vektor vek1(10,2), vek2(11);
		cout << "Unesite elemente pvrog vektora" << endl;
		for ( int i=10; i<=20; i++ )
			cin >> vek1[i];
		cout << "Unesite elemente drugog vektora" << endl;
		for ( i=1; i<=11; i++ )
			cin >> vek2[i];
		cout << "Skalarni proizvod vektora je: " << vek1*vek2 << endl;
	}
	catch( Vektor::Greska greska )
	{
		switch ( greska )
		{
		case Vektor::NEKOREKTNE_GRANICE:
			cout << "Donja granica vektora je veca od gornje" << endl;
			break;
		case Vektor::POPUNJENA_MEMORIJA:
			cout << "Nije bilo mesta u din. zoni memorije" << endl;
			break;
		case Vektor::VEKTOR_JE_PRAZAN:
			cout << "Vektor je prazan" << endl;
			break;
		case Vektor::LOS_INDEX:
			cout << "Indeks je van dozvoljenih granica" << endl;
			break;
		case Vektor::RAZLICITE_VELICINE:
			cout << "Vektori ne mogu da se pomnoze" << endl;
			
		}
/*
	catch( Izuzetak greska )
	{
		greska.prikazi();
	}
*/
	}

}