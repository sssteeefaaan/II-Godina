#include <fstream.h>
#include <string.h>

struct Radnik
{
	char ime[30];
	double plata;
}
;
void main()
{
	Radnik r;
	strcpy(r.ime, "Marko Markovic");
	r.plata = 103.45;

	ofstream os("plata.dat", ios::binary);
	os.write((char*) &r, sizeof(r));	// obavezna je eksplicitna konverzija u char*
	os.close();
	cout << "Upis u datoteku je izvrsen" << endl;
}