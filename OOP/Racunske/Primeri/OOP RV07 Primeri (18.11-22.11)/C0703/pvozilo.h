// pvozilo.h - Klasa putnickih vozila.

#ifndef _pvozilo_h_
#define _pvozilo_h_

#include "vozilo.h"

class PVozilo: public Vozilo {
  double srTez;                             // Srednja tezina putnika.
  int brPut;                                // Broj putnika.
public:
  PVozilo (double st, double srt, int bp): Vozilo (st)  // Konstruktor.
    { srTez = srt; brPut = bp; }
  char vrsta () const { return 'P'; }                   // Vrsta vozila.
  double tezina () const                                // Ukupna tezina.
    { return Vozilo::tezina () + srTez * brPut; }
private:
  void pisi (ostream& d) const                          // Pisanje.
    { Vozilo::pisi (d); d << srTez << ',' << brPut << ')'; }
};

#endif
