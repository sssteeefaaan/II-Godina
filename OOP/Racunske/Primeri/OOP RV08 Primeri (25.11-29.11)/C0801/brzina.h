// brzina.h - Klasa brzina.

#ifndef _brzina_h_
#define _brzina_h_

#include "vektor1.h"

class Brzina: public Vektor {
  void pisi (ostream& d) const { d << 'v'; Vektor::pisi(d); } // Pisanje.
public:
  Brzina (): Vektor() {}                                 // Konstruktori.
  Brzina (double x, double y, double z): Vektor (x, y, z) {}
};

#endif
