// otpornik.h - Klasa otpornika.

#include <iostream>
using namespace std;

class Otpornik {
  double r, dr;              // Otpornost i korak promene.
public:
  Otpornik(double rr=1000, double ddr=1) // Stvaranje objekta.
    { r = rr; dr = ddr; }
  double otp() const { return r; }       // Dohvatanje otpornosti.
  Otpornik& operator++()                 // Povecanje otpornosti.
    { r += dr; return *this; }
  Otpornik& operator--() {               // Smanjivanje otpornosti.
    r -= dr; if (r < 0) r = 0;
    return *this;
  }
  friend istream& operator>>(istream& ut, Otpornik& r)       // Citanje.
    { return ut >> r.r >> r.dr; }
  friend ostream& operator<<(ostream& it, const Otpornik& r) // Pisanje.
    { return it << "R(" << r.r << ',' << r.dr << ')'; }
};

