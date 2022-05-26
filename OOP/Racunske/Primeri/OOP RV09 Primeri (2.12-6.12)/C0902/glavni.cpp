#include "Polje.h"

void main()
{
	Polje p;
	p.UcitajIzFajla("polje.txt");
	p.Stampaj();
	
	while (true)
	{
		int x, y, op;
		cin >> x >> y >> op;
		system("CLS");

		int res = p.IzvrsiOperaciju(x, y, op);
		p.Stampaj();
		if (res == 2)
		{
			cout << endl;
			p.StampajOtkrivenoPolje();
			return;
		}
	}
}