// predstava.h - Klasa predstava.

#include "karta.h"
#include <iostream>
#include <string>
using namespace std;

class Predstava {
  string naslov;                       // Naslov.
  long datum;                          // Datum odrzavanja.
  Karta*** karte;                      // Matrica karata.

  int br_red, duz_red;                 // Broj redova i duzina redova.

  void kopiraj(const Predstava& p);    // Kopiranje u objekat.

  void premesti(Predstava& p) {        // Premestanje u objekat.
    naslov = p.naslov; datum = p.datum;
    karte = p.karte; p.karte = nullptr;
    br_red = p.br_red; duz_red = p.duz_red;
  }
  void brisi();                        // Oslobadjanje memorije.
public:                                             // Konstruktori:
  Predstava(string nas, long dat,                   // - novog objekta,
            int br_r, int duz_r);
  Predstava(const Predstava& p) { kopiraj(p); }     // - kopirajuci,

  ~Predstava() { brisi(); }                         // Destruktor.
  Predstava& operator=(const Predstava& p) {        // Dodela vrednosti:
    if (this != &p) { brisi(); kopiraj(p); }        // - kopirajuca,
    return *this;
  }
                                            // Vracanje:
  string vrati_naslov() const { return naslov; }     // - naslova,
  long vrati_datum() const { return datum; }         // - datuma,
  int vrati_br_red() const { return br_red; }        // - broja redova,
  int vrati_duz_red() const { return duz_red; }      // - duzine redova.
  bool operator+=(const Karta& k);                  // Dodavanje karte.
  float vrednost() const;                           // Vrednost svih karata.
  friend ostream& operator<<(ostream& it, const Predstava& p); // Pisanje.
};

