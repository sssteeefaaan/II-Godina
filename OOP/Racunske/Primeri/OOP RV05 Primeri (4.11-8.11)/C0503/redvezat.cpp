// redvezat.C - Ispitivanje klase rednih veza otpornika.

#include "redveza.h"
#include <iostream>
using namespace std;

int main() {
  cout << "n? "; int n; cin >> n;
  Red_veza rv(n);
  for (int i=0; i<n; i++) {
    cout << "r,d? "; Otpornik r; cin >> r; rv += r;
  }
  while (rv.dohv_duz()) {
    cout << rv << '=' << rv.otp() << endl;
    for (Otpornik& r: rv) --r;
    rv.izbaci ();
  }
}

