// sfera1.h - Klasa sfera.

#ifndef _sfera1_h_
#define _sfera1_h_

#include "predmet.h"

class Sfera: public Predmet {
  double r;
public:
  Sfera (double ss=1, double rr=1)                       // Konstruktor.
    : Predmet (ss) { r = rr; }
  double V() const { return 4./3 * r*r*r * 3.14159; }    // Zapremina.
private:
  void citaj (istream& dd)                               // Citanje.
    { Predmet::citaj (dd); dd >> r; }
  void pisi  (ostream& dd) const                         // Pisanje.
    { dd << "sfera ["; Predmet::pisi(dd); dd << ',' << r << ']'; }
};

#endif