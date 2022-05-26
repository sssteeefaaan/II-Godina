// tvozilo.h - Klasa teretnih vozila.

#ifndef _tvozilo_h_
#define _tvozilo_h_

#include "vozilo.h"

class TVozilo: public Vozilo {
  double teret;                                       // Tezina tereta.
public:
  TVozilo (double st, double t): Vozilo (st)          // Konstruktor.
    { teret = t; }
  char vrsta () const { return 'T'; }                 // Vrsta vozila.
  double tezina () const                              // Ukupna tezina.
    { return Vozilo::tezina () + teret; }
private:
  void pisi (ostream& d) const                        // Pisanje.
    { Vozilo::pisi (d); d << teret << ')'; }
};

#endif
