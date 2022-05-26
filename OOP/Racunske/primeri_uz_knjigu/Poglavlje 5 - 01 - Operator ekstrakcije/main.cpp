#include <iostream.h>

void main()
{
	char ime[20];
	cout << "Unesite vase ime:";	// ispisuje poruku
	
	cin >> ime;	// korisnik unosi ime

	cout << "Vase ime je: " << ime << "\n";	// ispis unesenog imena

/*
NAPOMENA: operator pamti ulaz samo do prvog unesenog blanko znaka, ukoliko za ime unesete "Marko Markovic", 
dobicete samo "Marko"
*/
}
