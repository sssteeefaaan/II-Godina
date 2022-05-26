#include <iostream>
#include <fstream>
#include "Tabla.h"
#include "Ruza.h"
#include "Ajkula.h"
#include "Marsovac.h"
using namespace std;

void Ucitaj(ifstream& f, Tabla& tabla)
{
	char c;
	for (int i = 0; i < tabla.GetN(); i++)
		for (int j = 0; j < tabla.GetN(); j++)
		{
			f >> c;
			switch (c)
			{
			case '@': tabla.Postavi(i, j, new Ruza(&tabla, i, j)); break;
			case '~': tabla.Postavi(i, j, new Ajkula(&tabla, i, j)); break;
			case 'm': tabla.Postavi(i, j, new Marsovac(&tabla, i, j)); break;
			case 'o':  break;
			}
		}
}

int main()
{
	ifstream f("fajl.txt");
	int n;
	f >> n;
	Tabla p(n);
	Ucitaj(f, p);
	f.close();

	cout << "Nakon ucitavanja" << endl;
	p.Ispisi();

	p.JedanZlo(0, 0);
	cout << "Nakon p.JedanZlo(0, 0);" << endl;
	p.Ispisi();

	p.SviZlo();
	cout << "Nakon p.SviZlo()" << endl;
	p.Ispisi();

	p.SviZlo();
	cout << "Nakon p.SviZlo()" << endl;
	p.Ispisi();

	p.SviDobro();
	cout << "Nakon p.SviDobro()" << endl;
	p.Ispisi();
	
	
	p.SviDobro();
	cout << "Nakon p.SviDobro()" << endl;
	p.Ispisi();
	
	p.SviZlo();
	cout << "Nakon p.SviZlo()" << endl;
	p.Ispisi();
	system("pause");
	return 0;
}