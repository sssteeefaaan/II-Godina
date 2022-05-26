// tacka4.h - Klasa pokretnih tacaka.

#ifndef _tacka4_h_
#define _tacka4_h_

#include "pokretan.h"
#include "vektor1.h"
#include "brzina.h"

class Tacka: public Pokretan {
  static int ukId;   // Poslednje korisceni identifikator.
  const int id;      // Identifikator tacke.
  Vektor r;          // Vektor polozaja.
  Brzina v;          // Vektor brzine.
public:
  Tacka (const Vektor& rr=Vektor(),              // Nova tacka dobija novi 
         const Brzina& vv=Brzina())              //   identifikator.
    : r(rr), v(vv), id(++ukId) {}
  Tacka (const Tacka& T)                         // Kopija tacke dobija novi
    : r(T.r), v(T.v), id(++ukId) {}              //   identifikator.
  Tacka& operator= (const Tacka& T)              // Levom operandu se ne
    { r = T.r; v = T.v; return *this; }          //   menja identifikator.
  Pokretan& proteklo (double dt)                 // Promena polozaja zbog
    { r = r + v * dt; return *this; }            //   proteklog vremena.
  Vektor R () const { return r; }                // Trenutni polozaj.
  friend double rastojanje (const Tacka& T1, const Tacka& T2) // Rastojanje
    { return + (T1.r + T2.r * -1); }                          //   dve tacke.
  friend ostream&  operator<< (ostream& d, const Tacka& T)    // Pisanje.
    { return d << 'T' << T.id << T.r; }
};

#endif