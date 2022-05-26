// kanta.h - Klasa kanti.

#include "valjak1.h"

class Kanta: public Valjak {
  double puno;                                     // Napunjeni deo.
  Kanta(const Kanta&) {}                           // Ne sme da se kopira.
public:
  explicit Kanta(double rr=1, double hh=1, double pp=0): // Inicijali-
    Valjak(rr,hh), puno(pp<=V() ? pp : V()) {}           //   zacija.
  double ima () const { return puno; }             // Koliko ima tecnosti?
  double fali() const { return V() - puno; }       // Koliko tecnosti fali?
  bool puna  () const { return puno == V(); }      // Da li je puna?
  bool prazna() const { return puno == 0; }        // Da li je prazna?
 
  Kanta& operator+=(double dopuna) {                        // Dolivanje.
    puno = (puno+dopuna <= V()) ? puno+dopuna : V();
    return *this;
  }
  Kanta& operator-=(double odliv) {                         // Odlivanje.
    if (puno-odliv > 0) puno -= odliv; else puno = 0;
    return *this;
  }
  Kanta& operator=(Kanta& k) {                              // Presipanje.
    if (this != &k) {
      double prazno = fali();
      if (prazno >= k.puno) { puno += k.puno; k.puno = 0; }
        else { puno = V(); k.puno -= prazno; }
    }
    return *this;
  }
  friend ostream& operator<<(ostream& it, const Kanta& k) { // Pisanje.
    return it << '{' << static_cast<const Valjak&>(k) << ','
              << k.puno << '}';
  }
};
