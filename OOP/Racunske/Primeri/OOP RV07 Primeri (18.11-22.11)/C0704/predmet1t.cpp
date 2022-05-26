// predmet1t.C - Ispitivanje klasa predmeta.

#include "sfera.h"
#include "kvadar.h"
#include <iostream>
using namespace std;

int main () {
  Predmet* p[100] = {0}; double q = 0; int i, n = 0;
  while (true) {
    char tip; cin >> tip;
  if (tip == '.') break;
    switch (tip) {
    case 's': case 'S': p[n] = new Sfera;  break;
    case 'k': case 'K': p[n] = new Kvadar; break;
    }
    if (p[n]) {
      cin >> *p[n];
      cout << *p[n] << " (q=" << p[n]->q() << ")\n";
      q += p[n++]->q ();
    }
  } 
  if (n) q /= n;
  cout << "\nqsr= " << q << "\n\n";
  for (int i=0; i<n; i++)
    if (p[i]->q() > q) cout << *p[i] << " (q=" << p[i]->q() << ")\n";
  return 0;
}
