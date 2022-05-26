// pokretant.C - Ispitivanje klase pokretnih tacaka.

#include "tacka4.h"
#include "vektor1.h"
#include "brzina.h"
#include <iostream>
#include <fstream>
using namespace std;

int main() {
	ifstream inputFile("podaci.txt");
	cout << "Broj tacaka? "; int n; inputFile >> n;
	Tacka** tacke = new Tacka*[n];
	for (int i = 0; i < n; i++) {
		cout << "Koordinate temena " << i << "? ";
		double x, y, z; inputFile >> x >> y >> z;
		cout << "Komponente brzine? ";
		double vx, vy, vz; inputFile >> vx >> vy >> vz;
		tacke[i] = new Tacka(Vektor(x, y, z), Brzina(vx, vy, vz));
	}

	cout << "\nBroj koraka? "; int k; inputFile >> k;
	cout << "Trajanje koraka? "; double dt; inputFile >> dt;
	const Tacka org;
	cout << "ORG   " << org << "\n\n";

	for (int i = 0; i < k; i++) {
		for (int j = 0; j < n; tacke[j++]->proteklo(dt));
		double min = rastojanje(org, *tacke[0]); int m = 0;
		for (int j = 1; j < n; j++) {
			double d = rastojanje(org, *tacke[j]);
			if (d < min) { min = d; m = j; }
		}
		cout << i << ' ' << *tacke[m] << ' ' << min << endl;
	}
	system("pause");
	return 0;
}
