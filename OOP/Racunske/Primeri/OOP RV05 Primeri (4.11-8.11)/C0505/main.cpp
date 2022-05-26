#include "Lavirint.h"

void main()
{
	cout << "c - pacman, d-duh, .-mala tacka, *-velika tacka, bilo sta drugo - zid";
	Lavirint l;	
	
	l.Ucitaj(_strdup("polje.txt"));
	l.Stampaj();
	cout << "w - gore, a-levo, s-dole, d-desno, x- kraj";
	while(true)
	{
		char c;
		cin >> c;
		if (c == 'x')
		{
			break;
		}
		l.MovePacman(c);
		l.Stampaj();
	}
}
