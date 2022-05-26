// karta.h - Klasa karata.

#include <iostream>
using namespace std;

class Karta {
  int red, sed;                            // Broj reda i sedista.
  float cena;                              // Cena karte.
public:
  Karta(int r, int s, float c)             // Stvaranje karte.
    { red = r; sed = s; cena = c; }
  int vrati_red() const { return red; }     // Vracanje broja reda.
  int vrati_sed() const { return sed; }     // Vracanje broja sedista.
  float vrati_cenu() const { return cena; } // Vracanje cene.
  friend ostream& operator<<(ostream& it, const Karta& k) // Pisanje.
    { return it << '(' << k.red << ',' << k.sed <<  ',' << k.cena << ')'; }
};

