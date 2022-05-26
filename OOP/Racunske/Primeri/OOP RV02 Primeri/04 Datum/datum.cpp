// datum.cpp - Definicije uz klasu kalendarskih datuma.

#include "datum.h"
#include <iostream>
using namespace std;

const short Datum::duz[][12]  =       // Brojevi dana po mesecima.
              {{31,28,31,30,31,30,31,31,30,31,30,31},
               {31,29,31,30,31,30,31,31,30,31,30,31}},
            Datum::prot[][12] =      // Brojevi dana od poèetka godine.
              {{0,31,59,90,120,151,181,212,243,273,304,334},
               {0,31,60,91,121,152,182,213,244,274,305,335}};
const char *Datum::imeD[] = {"ponedeljak", "utorak", "sreda", "cetvrtak",
                             "petak", "subota", "nedelja"},
           *Datum::imeM[] = {"januar", "februar", "mart", "april", "maj",
                             "jun", "jul", "avgust", "septembar",
                             "oktobar", "novembar", "decembar"};

void Datum::citaj () {
  short d, m, g;
  while (true) {
    cin >> d >> m >> g;
  if (moze (d,m,g)) break;
    printf ("\n*** Neispravan datum, unesite ponovo: ");
  }
  datum (d, m, g);
}

void Datum::pisi () const {
  cout << dan/10 << dan%10 << ". " << imeM[mes-1] << ' ' << god << '.';
}

long Datum::ukDan () const {
  short g = god - 1;
  return g*365L + g/4 - g/100 + g/400 + danUGod();
}

void Datum::sutra () {
  if (dan < duzMes()) dan++;
  else {
    dan = 1;
    if (mes < 12) mes++;
    else { mes = 1; god++; }
  }
}


void Datum::juce () {
  if (dan > 1) dan--;
  else {
    if (mes > 1) mes--;
    else { mes = 12; god--; }
    dan = duzMes();
  }
}

void Datum::dodaj  (unsigned k) { for (unsigned i=0; i<k; i++) sutra (); }

void Datum::oduzmi (unsigned k) { for (unsigned i=0; i<k; i++) juce  (); }
