// inventar.h - Klasa inventara.

#include "zapis.h"
#include <iostream>
#include <string>
using namespace std;

class Inventar {
  Zapis** niz;                                  // Niz pokazivaca na zapise.
  int kap, duz;                                 // Kapacitet i duzina niza.
  void kopiraj(const Inventar& inv);            // Kopiranje u objekat.

  void brisi();                                 // Oslobadjanje memorije.
public:
  Inventar(int k=10)                   // Stvaranje objekta.
    { niz = new Zapis* [kap = k]; duz = 0; }
  Inventar(const Inventar& inv)                 // Kopirajuci konstruktor.
    { kopiraj(inv); }

  ~Inventar() { brisi(); }                         // Destruktor.
  Inventar& operator=(const Inventar& inv) {       // Kopirajuca dodela
    if (this != &inv) { brisi(); kopiraj(inv); }   //   vrednosti.
    return *this;
  }

  int duzina() const { return duz; }               // Duzina niza.
                                                   // Dohvatanje zapisa:
  Zapis* operator[](string naziv);                 // - iz promenljivog,
  const Zapis* operator[](string naziv) const      // - iz nepromenljivog
    {return const_cast<Inventar&>(*this)[naziv]; } // objekta.
  bool operator+=(Zapis* z) {                      // Dodavanje zapisa.
    if (duz==kap || (*this)[z->naziv()]) return false;
    niz[duz++] = z; return true;
  }
                                                      // Iteratori:
  Zapis** begin() { return niz; }                     // - za promenljive
  Zapis** end() { return niz + duz; }                 //   inventare,
  const Zapis*const*const begin() const {return niz;} // - za nepromenljive
  const Zapis*const*const end() const {return niz + duz;}  //   inventare.
  double vrednost() const;                       // Vrednost svih artikala.
  friend ostream& operator<<(ostream& it, const Inventar& inv); // Pisanje.
};

