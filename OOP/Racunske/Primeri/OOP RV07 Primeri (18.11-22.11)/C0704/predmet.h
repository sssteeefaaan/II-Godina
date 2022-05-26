// predmet1.h - Apstraktna klasa predmeta.

#ifndef _predmet1_h_
#define _predmet1_h_

#include <iostream>
using namespace std;

class Predmet {
  double sigma;        // Specificna tezina.
public:
  Predmet (double ss=1) { sigma = ss; }                  // Konstruktor.
  virtual double V () const =0;                          // Zapremina.
  double q () const { return V () * sigma; }             // Tezina.
protected:
  virtual void citaj (istream &dd) { dd >> sigma; }      // Citanje.
  virtual void pisi (ostream &dd) const { dd << sigma; } // Pisanje.
  friend istream& operator>> (istream& dd, Predmet &pp)  // Uopsteno citanje
    { pp.citaj (dd); return dd; }                        //      i
  friend ostream& operator<< (ostream& dd, const Predmet &pp) // pisanje.
    { pp.pisi (dd); return dd;}
};

#endif
