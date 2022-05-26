#include <fstream>
#include <string>
#include <iostream>
using namespace std;

void PrimerSaKorsicenjemGotoveKlase()
{
	string theNames = "Edsger Dijkstra: Made advances in algorithms, the semaphore (programming).\n";
	theNames.append("Donald Knuth: Wrote The Art of Computer Programming and created TeX.\n");
	theNames.append("Leslie Lamport: Formulated algorithms in distributed systems (e.g. the bakery algorithm).\n");
	theNames.append("Stephen Cook: Formalized the notion of NP-completeness.\n");

	// probajte prvo bez moda, pa sa modom, pa bez
	ofstream ofs("theNames.txt");
//	ofstream ofs("theNames.txt", ios::app);

	if (!ofs) {
		cout << "Error opening file for output" << endl;
		return;
	}
	ofs << theNames << endl;
	ofs.close();	
}

// preuzeto sa https://www.geeksforgeeks.org/file-handling-c-classes/
void PrimerSaUpisomICitanjemViseLinijaUFajl()
{
	// Kreiramo fajl sa fstream-om
	fstream fio;

	string line;

	// by default openmode za fajlove je ios::in|ios::out mode 
	// Za nadovezivanje koristite ios:app 
	// fio.open("sample.txt", ios::in|ios::out|ios::app) 
	// ios::trunc mod brise prethodni sadrzaj
	fio.open("sample.txt", ios::trunc | ios::out | ios::in);
		
	while (fio) {

		// citamo red po red sa cin-a
		getline(cin, line);

		// unos -1 je kraj nase petlje
		if (line == "-1")
			break;

		// upisemo uneti red u fajl 
		fio << line << endl;
	}

	// Posto se petlja izvrsila do EOF (End of File) 
	// moramo da vratimo pointer na pocetak fajla
	// procitajte sta je ios:beg :)
	fio.seekg(0, ios::beg);

	while (fio) {

		// citamo red iz fajla 
		getline(fio, line);

		// odstampamo na cout
		cout << line << endl;
	}

	// Close the file 
	fio.close();
}

void PrimerSaSeekpITellp()
{
	long position;
	ofstream file;
	file.open("myfile.txt");

	// za fstream se preporucuje postavljanje moda
	/*fstream file;
	file.open("myfile.txt", ios::out);*/

	// upisimo sadrzaj u fajl
	file.write("this is an apple", 16);
	position = file.tellp();

	// postavimo position pointer 
	file.seekp(position - 7);
	file.write(" sam", 4);
	file.close();
}

void ObrisiNtuLinijuIzFajla(const char *file_name, int n)
{
	// ifstream otvara fajl u read (in) modu
	ifstream is(file_name);

	// ofstream otvara fajl u write (out) modu
	ofstream ofs;
	ofs.open("temp.txt", ofstream::out);

	// citamo karakter po karakter 
	char c;
	int line_no = 1;
	while (is.get(c))
	{
		// kada naletimo na novi red povecamo broj linija 
		if (c == '\n')
			line_no++;

		// posaljemo na izlaz sadrzaj koji ne zelimo da brisemo 
		if (line_no != n)
			ofs << c;
	}

	// zatvorimo fajlove 
	ofs.close();
	is.close();

	// obrisemo originalni fajl 
	remove(file_name);

	// promenimo ime novom fajlu u ime originalnog fajla 
	rename("temp.txt", file_name);
}

int main()
{
	PrimerSaKorsicenjemGotoveKlase();

	PrimerSaUpisomICitanjemViseLinijaUFajl();

	PrimerSaSeekpITellp();

	ObrisiNtuLinijuIzFajla("loremipsum.txt", 3);
}