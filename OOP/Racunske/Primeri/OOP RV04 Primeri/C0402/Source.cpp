#include "Matrica.h"

void main()
{
	Matrica a(2, 3), b(3, 4);

	cout << "ucitajte elemente prve matrice" << endl;
	cin >> a;

	cout << "unesite elemente druge matrice" << endl;
	cin >> b;

	cout << "proizvod matrica je: " << endl;
	Matrica& c = a.pomnozi(b);
	cout << c;

	cout << a.pomnozi(b); // rezultat mnozenja se ne pamti u posebnom objektu
}