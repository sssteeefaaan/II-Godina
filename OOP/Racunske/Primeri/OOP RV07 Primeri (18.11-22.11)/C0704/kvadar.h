// kvadar3.h - Klasa kvadara.

#ifndef _kvadar3_h_
#define _kvadar3_h_

#include "predmet.h"

class Kvadar: public Predmet {
  double a, b, c;
public:
  Kvadar (double ss=1, double aa=1, double bb=1, double cc=1) // Konstr.
    : Predmet (ss) { a = aa; b = bb; c = cc; }
  double V () const { return a * b * c; }                // Zapremina.
private:
  void citaj (istream& dd)                               // Citanje.
    { Predmet::citaj (dd); dd >> a >> b >> c; }
  void pisi  (ostream& dd) const {                       // Pisanje.
    dd << "kvadar["; Predmet::pisi(dd); 
    dd << ',' << a << ',' << b << ',' << c << ']';
  }
};

#endif