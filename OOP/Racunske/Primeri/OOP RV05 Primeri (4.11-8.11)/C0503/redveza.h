// redveza.h - Klasa rednih veza otpornika.

#include "otpornik.h"
#include <iostream>
#include <cstdlib>
using namespace std;

class Red_veza {
  Otpornik* niz;                                // Niz otpornika.
  int kap, duz;                                 // Kapacitet i duzina niza.
  void kopiraj(const Red_veza& rv);             // Kopiranje u objekat.
  void premesti(Red_veza& rv) {                 // Premestanje u objekat.
    niz = rv.niz; rv.niz = nullptr;
    kap = rv.kap; duz = rv.duz;
  }
  void brisi() { delete [] niz; }               // Oslobadjanje memorije.
public:
  Red_veza (int k=2) {                 // Stvaranje objekta.
    niz = new Otpornik [kap = k];
    duz = 0;
  }
  Red_veza(const Red_veza& rv) { kopiraj(rv); } // Kopirajuci konstruktor.  
  ~Red_veza() { brisi(); }                      // Destruktor.
  Red_veza& operator=(const Red_veza& rv) {     // Kopirajuca dodela
    if (this != &rv) { brisi(); kopiraj(rv); }  //   vrednosti.
    return *this;
  }
                                         // Dohvatanje:
  int dohv_kap() const { return kap; }          // - kapaciteta veze,
  int dohv_duz() const { return duz; }          // - duzine veze.
  Red_veza& operator+=(const Otpornik& r) {     // Dodavanje otpornika.
    if (duz == kap) exit(1);
    niz[duz++] = r;
    return *this;
  }                                             // Pristup elementu veze:
  Otpornik& operator[](int i) {                 // - promenljivog objekta,
    if (i<0 || i>=duz) exit(2);
    return niz[i];
  }
  const Otpornik& operator[](int i) const {     // - nepromenljivog objekta.
    if (i<0 || i>=duz) exit(2);
    return niz[i];
  }                                       // Pokazivac na pocetak i kraj:
  Otpornik* begin() { return niz; }                      // - promenljivog
  Otpornik* end() { return niz + duz; }                  //   objekta,
  const Otpornik*const begin() const { return niz; }     // - nepromenljivog
  const Otpornik*const end() const { return niz + duz; } //   objekta.
  double otp() const;                     // Otpornost veze.
  Red_veza& izbaci();                     // Izbacivanje nultih otpornosti.
  friend ostream& operator<<(ostream& it, const Red_veza& rv);  // Pisanje.
};

