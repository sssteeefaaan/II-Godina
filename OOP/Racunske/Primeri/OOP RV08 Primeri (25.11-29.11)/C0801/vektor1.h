// vektor1.h - Klasa vektora u prostoru.

#ifndef _vektor1_h_
#define _vektor1_h_

#include <iostream>
#include <cmath>
using namespace std;

class Vektor {
  double x, y, z;                                   // Komponente vektora.
public:
  Vektor () { x = y = z = 0; }                            // Konstruktori.
  Vektor (double xx, double yy, double zz)
    { x = xx; y = yy; z = zz; }
  virtual ~Vektor () {}                                   // Destruktor.
  double operator+ () const { return sqrt(x*x+y*y+z*z); } // Intenzitet.
  friend Vektor operator+ (const Vektor& v1, const Vektor& v2) // v1 + v2
    { return Vektor (v1.x+v2.x, v1.y+v2.y, v1.z+v2.z); }
  friend Vektor operator* (const Vektor& v, double s)          // v  * s
    { return Vektor (v.x*s, v.y*s, v.z*s); }
protected:
  virtual void pisi (ostream& d) const                         // Pisanje.
    { d << '(' << x << ',' << y << ',' << z << ')'; }
  friend ostream& operator<< (ostream& d, const Vektor& v)
    { v.pisi (d); return d; }
};

#endif
