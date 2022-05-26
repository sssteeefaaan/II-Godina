// trougao2.h - Definicija klase trouglova.

#include <cstdlib>
using namespace std;

class Trougao {
  double a, b, c;                                  // Stranice trougla.
public:
  static bool moze(double a, double b, double c) { // Da li su stranice
    return a>0 && b>0 && c>0 &&                    //   prihvatljive?
           a+b>c && b+c>a && c+a>b;
  }
  Trougao(double aa=1, double bb=1, double cc=1) { // Postavljanje
    if (!moze(aa, bb, cc)) exit(1);                //   koordinata.
    a = aa; b = bb; c = cc;
  }
  double dohvA() const { return a; }               // Dohvatanje stranica.
  double dohvB() const { return b; }
  double dohvC() const { return c; }
  double O() const { return a + b + c; }           // Obim trougla.
  double P() const;                                // Povrsina trougla.
  bool citaj();                                    // Citanje trougla.
  void pisi() const;                               // Pisanje trougla.
};
