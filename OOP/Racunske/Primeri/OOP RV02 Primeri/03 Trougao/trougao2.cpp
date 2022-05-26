// trougao2.C - Definicije metoda klase trouglova.

#include "trougao2.h"
#include <iostream>
#include <cmath>
using namespace std;

double Trougao::P() const {                        // Povrsina trougla.
  double s = O() / 2;
  return sqrt(s * (s-a) * (s-b) * (s-c));
}

bool Trougao::citaj() {                            // Citanje trougla.
  double aa, bb, cc;
  cin >> aa >> bb >> cc;
  if (!moze(aa, bb, cc)) return false;
  a = aa; b = bb; c = cc;
  return true;
}

void Trougao::pisi() const {                       // Pisanje trougla.
  cout << "Troug(" << a << ',' << b << ',' << c << ')';
}
