// uredi1.cpp
// OOP zadatak 02.01
// Uredjenje (dinamickog) niza celih brojeva
// Zauzimanje prostora za niz celih brojeva
// Oslobadjanje prostora koji zauzima niz celih brojeva

#include <iostream>
using namespace std;

int main() {
	while (true) {
		int n;
		cout << "Uneti duzinu niza:  ";
		cin >> n;
		if (n <= 0) break;
		int* a = new int [n];
		cout << "Uneti niz celih brojeva: ";
		// for (int i=0; i<n; cin >> a[i++]);
		for (int i=0; i<n; i++) {
			cin >> a[i];
		}

		for (int i=0; i<n-1; i++) {
			int& b = a[i];      // b je u stvari a[i].
			for (int j=i+1; j<n; j++)
				if (a[j]<b) { int c=b; b=a[j]; a[j]=c; }
		}
		cout << "Uredjeni niz celih brojeva: ";
		// for (int i=0; i<n; cout << a[i++] << ' ');
		for (int i=0; i<n; i++) {
			cout << a[i] << ' ';
		}
		cout << endl;
		delete [] a;
	}
	return 0;
}
