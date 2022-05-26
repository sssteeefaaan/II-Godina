// inventar.C - Metode i funkcije uz klasu inventara.

#include "inventar.h"
using namespace std;

void Inventar::kopiraj(const Inventar& inv) {   // Kopiranje u objekat.
  niz = new Zapis* [kap = inv.kap];
  duz = inv.duz;
  int i = 0; for(const Zapis* pz: inv) niz[i++] = new Zapis(*pz);
}

void Inventar::brisi() {                        // Oslobadjanje memorije.
  for (Zapis* pz: *this) delete pz;
  delete [] niz;
}

Zapis* Inventar::operator[](string naziv) {     // Dohvatanje zapisa
  for (Zapis* pz: *this)                        //   (promenljivog objekta).
    if (pz->naziv() == naziv) return pz;
  return nullptr;
}

double Inventar::vrednost() const {             // Vrednost svih artikala.
  double v = 0;
  for (const Zapis* pz: *this) v += pz->vrednost();
  return v;
}

ostream& operator<<(ostream& it, const Inventar& inv) { // Pisanje.
  for (const Zapis* pz: inv) it << *pz << endl;
  return it << "==============================\n"
            << "UKUPNO:   " << inv.vrednost() << "din" << endl;
}

