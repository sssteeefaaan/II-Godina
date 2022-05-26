// redveza.C - Metode i funkcije uz klasu rednih veza otpornika.

#include "redveza.h"

double Red_veza::otp() const {               // Otpornost veze.
  double R = 0;
  for (Otpornik r: *this) R += r.otp();
  return R;
}

void Red_veza::kopiraj(const Red_veza& rv) { // Kopiranje u objekat.
  niz = new Otpornik [kap = rv.kap];
  duz = rv.duz;
  int i = 0; for (Otpornik r: rv) niz[i++] = r;
}

Red_veza& Red_veza::izbaci() {            // Izbacivanje nultih otpornosti.
  int j=0;
  for (Otpornik r: *this)
    if (r.otp()) niz[j++] = r;
  duz = j;
  return *this;
}

ostream& operator<<(ostream& it, const Red_veza& rv) {    // Pisanje.
  int i = 0;
  for (Otpornik r: rv) {
    if (i++) it << '+';
    it << r;
  }
  return it;
}

