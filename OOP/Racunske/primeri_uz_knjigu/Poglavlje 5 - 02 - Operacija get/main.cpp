#include <iostream.h>
#include <fstream.h>

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
	cin.get(naziv, 10);	// ulaz od maksimalno 10 znakova ce smestiti u promenljivu naziv
	cout << "Naziv filma:" << naziv << endl;

};

void main()
{

	primer_za_get_1();	// primer sa citanjem iz datoteke
	primer_za_get_2();	// primer sa unosom sa tastature
}