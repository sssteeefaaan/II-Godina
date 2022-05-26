// predstava.C - Metode i funkcije uz klasu predstava.

#include "predstava.h"

void Predstava::kopiraj(const Predstava& p) { // Kopiranje u objekat.
  naslov = p.naslov; datum  = p.datum;
  br_red = p.br_red; duz_red = p.duz_red;
  karte  = new Karta** [br_red];
  for (int i=0; i<br_red; i++) {
    karte[i] = new Karta* [duz_red];
    for (int j=0; j<duz_red; j++)
      karte[i][j] = p.karte[i][j] ? new Karta(*p.karte[i][j]) : nullptr;
  }
}
 
void Predstava::brisi() {                     // Oslobadjanje memorije.
  for (int i=0; i<br_red; i++) {
    for (int j=0; j<duz_red; delete karte[i][j++]);
    delete [] karte[i];
  }
  delete [] karte;
}

Predstava::Predstava(string nas, long dat, int br_r, int duz_r) {
  naslov = nas; datum = dat;                  // Konstruktor novog objekta.
  br_red = br_r; duz_red = duz_r;
  karte = new Karta** [br_red];
  for (int i=0; i<br_red; i++) {
    karte[i] = new Karta* [duz_red];
    for (int j=0; j<duz_red; karte[i][j++]=nullptr);
  }
}

bool Predstava::operator+=(const Karta& k) {  // Dodavanje karte.
  int red = k.vrati_red(), sed = k.vrati_sed();
  if (red<0 || red>=br_red || sed<0 || sed>=duz_red || karte[red][sed])
    return false;
  karte[red][sed] = new Karta(k);
  return true;
}

float Predstava::vrednost() const {           // Vrednost svih karata.
  float v = 0;
  for (int i=0; i<br_red; i++)
    for (int j=0; j<duz_red; j++)
      if (karte[i][j]) v += karte[i][j]->vrati_cenu();
  return v;
}

ostream& operator<<(ostream& it, const Predstava& p) { // Pisanje.
  for (int i=0; i<p.br_red; i++) {
    for (int j=0; j<p.duz_red; j++)
      it << (p.karte[i][j] ? '#' : '_') << ' ';
    it << endl;
  }
  return it;
}

