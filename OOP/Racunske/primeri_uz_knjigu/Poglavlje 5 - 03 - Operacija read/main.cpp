#include <io.h>
#include <fstream.h>
#include <string.h>

struct Radnik
{
	char ime[20];
	double plata;
};

void main()
{
	Radnik r;

	ifstream is( "plata.dat", ios::binary | ios::nocreate );
	if( is ) {  
	is.read( (char *) &r, sizeof(r) );
		cout << r.ime << ' ' << r.plata << endl;
	}
	else {
		cout << "Greska: Datoteka se ne moze otvoriti" << endl;
	}
	is.close();

}