#include <iostream>
#include <fstream>
#include <io.h>
#include <string.h>
#include <iomanip>
using namespace std;

void primer1()
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

void primer_za_get_1()
{
	char str1[40], str2[50];
	char c;
	cout << "**********************\n Citanje iz datoteke \n**********************\n\n";
	ifstream f("test.txt", ios::in);
	if (f) {
		f.get(str1, 40);	// prvih 40 procitanih karaktera ce smestiti u promenljivu naziv
		f.get(c);	// sledeci znak procitak iz datoteke ce smestiti u promenljivu c, a pokazivac u datoteci ce se 
					// pomeriti za jedno mesto unapred
		f.get(str2, 50, '.');
		
		cout << "Procitani niz znakova:" << str1 << endl;
		cout << "Procitani znak:" << c << endl;
		cout << "Drugi procitani niz znakova:" << str2 << endl;

	}
	f.close();
};

void primer_za_get_2()
{
	char naziv[20];
	cout << "\n\n**********************\n Unos sa tastature \n**********************\n";
	cout << "\nUnesite naziv omiljenog filma:";
	cin.ignore();  // da se ignorisu ako je bilo \n u stream-u
	cin.get(naziv, 10);	// ulaz od maksimalno 10 znakova ce smestiti u promenljivu naziv
	cout << "Naziv filma:" << naziv << endl;

};

struct Radnik
{
	char ime[30];
	double plata;
};

void primerRead()
{
	Radnik r;

	ifstream is( "plata.dat", ios::binary | ios::in );
	if( is ) {  
		int l;
		is.read((char *)&l, sizeof(int));
		cout << l <<endl;

	while(is.read( (char *) &r, sizeof(r) ))
		cout << r.ime << ' ' << r.plata << endl;
	}
	else {
		cout << "Greska: Datoteka se ne moze otvoriti" << endl;
	}
	is.close();

}


void primer_width()
{
   double values[] = { 1.23, 35.36, 653.7, 4358.24 };
   for( int i = 0; i < 4; i++ )
   {
      cout.width(10);
      cout << values[i] << '\n';
   }
}

void primer_fill()
{
   double values[] = { 1.23, 35.36, 653.7, 4358.24 };
	for( int i = 0; i < 4; i++ )
	{
	   cout.width( 10 );
	   cout.fill( '*' );
	   cout << values[i] << endl;
	}

}

void primer_setw()
{
   cout.fill( ' ' );	// vraca na standardnu vrednost, blanko
   cout << "\n\n\n\n";
   double values[] = { 1.23, 35.36, 653.7, 4358.24 };
   char *names[] = { "Zoot", "Jimmy", "Al", "Stan" };
   for( int i = 0; i < 4; i++ )
      cout << setw( 6 )  << names[i]
           << setw( 10 ) << values[i] << endl;

}

void primerwrite()
{
	Radnik r;
	strcpy(r.ime, "Marko Markovic");
	r.plata = 103.47;

	ofstream os("plata.dat", ios::binary);
	int s = 4;
	os.write((char*) &s, sizeof(s));

	os.write((char*) &r, sizeof(r));	// obavezna je eksplicitna konverzija u char*
	os.write((char*) &r, sizeof(r));
	os.write((char*) &r, sizeof(r));
	os.write((char*) &r, sizeof(r));
	os.close();
	cout << "Upis u datoteku je izvrsen" << endl;

}

void main()
{	

	primer1();

	primer_za_get_1();

	primer_za_get_2();

	primerRead();
	
	primer_width();

	primer_fill();

	primer_setw();

	primerwrite();
}

