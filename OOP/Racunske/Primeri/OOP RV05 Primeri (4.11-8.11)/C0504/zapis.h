// zapis.h - Klasa zapisa o artiklu.

#include <string>
#include <iostream>
using namespace std;

class Zapis {
  string naz, jed;                                // Naziv i jedinica mere.
  double kol, cen;                                // Kolicina i cena.
public:
  Zapis(string n, string j, double c)             // Stvaranje zapisa.
    { naz = n;  jed = j; kol = 0; cen = c; }
                                                  // Dohvatanje:
  string naziv() const { return naz; }            // - naziva,
  double kolicina() const { return kol; }         // - kolicine,
  string jed_mere() const { return jed; }         // - jedinice mere,
  double cena() const { return cen; }             // - cene.
  double vrednost() const { return cen * kol; }   // Izracunavanje vrednosti
  bool operator+=(double dk) {                    // Promena kolicine.
    if (kol + dk < 0) return false;
    kol += dk; return true;
  }
  friend ostream& operator<<(ostream& it, const Zapis& z) { // Pisanje.
    return it << z.naz << ": " << z.kol << z.jed << " x " 
              << z.cen << "din = " << z.vrednost() << "din"; 
  }
};

