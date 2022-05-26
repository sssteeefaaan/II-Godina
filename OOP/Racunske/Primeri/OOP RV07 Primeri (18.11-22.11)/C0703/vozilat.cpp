// vozilat.C - Ispitivanje klasa vozila.

#include "tvozilo.h"
#include "pvozilo.h"
#include <iostream>
using namespace std;

int main () {
  Vozilo* vozila[100]; int n = 0;
  while (true) {
    cout << "\nVrsta vozila (T,P,*)? "; char vrs; cin >> vrs;
  if (vrs == '*') break;
    switch (vrs) {
    case 't': case 'T':
      cout << "Sopstvena tezina?     "; double sTez;  cin >> sTez;
      cout << "Tezina tereta?        "; double ter;   cin >> ter;
      vozila[n++] = new TVozilo (sTez, ter);
      break;
    case 'p': case 'P':
      cout << "Sopstvena tezina?     ";               cin >> sTez;
      cout << "Sr. tezina putnika?   "; double srTez; cin >> srTez;
      cout << "Broj putnika?         "; int    brPut; cin >> brPut;
      vozila[n++] = new PVozilo (sTez, srTez, brPut);
      break;
    default:
      cout << "*** Nepoznata vrsta vozila!\n";
    }
  }
  cout << "\nNosivost mosta?       "; double nosivost; cin >> nosivost;
  cout << "\nMogu da predju most:\n";
  for (int i=0; i<n; i++)
    if (vozila[i]->tezina() <= nosivost)
      cout << *vozila[i] << " - " << vozila[i]->tezina() << endl;
  for (int i=0; i<n; delete vozila[i++]);
  delete [] vozila;
  return 0;
}
