// podelat.cpp - Ispitivanje funkcije za uredivanje niza metodom podele.

#include <stdlib.h>
#include <iostream>
using namespace std;

void uredi(int[], int);

int main() {
	while (true) {
		int n; cout << "\n\nDuzina niza? "; cin >> n;
		if (n <= 0) break;
		int* a = new int [n];
		cout << "\nPocetni niz:\n\n";
		for (int i=0; i<n; i++)
			cout << (a[i] = (int)(rand() / (RAND_MAX + 1.) * 10))
			<< ((i%30==29 || i==n-1) ? '\n' : ' ');
		uredi(a, n);
		cout << "\nUredjeni niz:\n\n";
		for (int i=0; i<n; i++)
			cout << a[i] << ((i%30==29 || i==n-1) ? '\n' : ' ');
		delete [] a;
	}
	return 0;
}