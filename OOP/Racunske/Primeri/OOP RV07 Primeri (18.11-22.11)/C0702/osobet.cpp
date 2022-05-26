// osobet.C - Ispitivanje klasa osoba, djaka i zaposlenih.

#include "osobe.h"
#include <iostream>
using namespace std;

int main() {
  Osoba* ljudi[20]; int n=0;

  cout << "Citanje podataka o ljudima\n";
  while (true) { 
    cout << "\nIzbor (O=osoba, D=djak, Z=zaposlen, K=kraj)? ";
    char izbor; cin >> izbor; cin.get();
  if (izbor=='K' || izbor=='k') break;
 
    ljudi[n] = nullptr;
    switch (izbor) {
      case 'O': case 'o': ljudi[n] = new Osoba;    break;
      case 'D': case 'd': ljudi[n] = new Djak;     break;
      case 'Z': case 'z': ljudi[n] = new Zaposlen; break;
    }
    if (ljudi[n]) ljudi[n++]->citaj();
  }

  cout << "\nPrikaz procitanih podataka\n";
  for (int i=0; i<n; i++) { cout << endl; ljudi[i]->pisi(); }
}
