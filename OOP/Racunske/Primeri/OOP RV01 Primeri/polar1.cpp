// polar1.cpp – Odredivanje polarnih koordinata tacke.

#include <math.h>

// Pomocu pokazivaca.
void polar(double x, double y, double* r, double* fi) {
	*r  = sqrt(x*x + y*y);
	*fi = (x==0 && y==0) ? 0 : atan2(y, x);
}

// Pomocu upucivaca (reference).
void polar(double x, double y, double& r, double& fi) {
	r  = sqrt(x*x + y*y);
	fi = (x==0 && y==0) ? 0 : atan2(y, x);
}

#include <iostream>
using namespace std;

int main() {
	while (true) {
		double x, y; cout << "\nx,y?  "; cin >> x >> y;
		if (x == 1e38) break;
		double r, fi;
		polar(x, y, &r, &fi);
		cout << "r,fi: " << r << ' ' << fi << endl;
		polar(x, y, r, fi);
		cout << "r,fi: " << r << ' ' << fi << endl;
	}
	return 0;
}
