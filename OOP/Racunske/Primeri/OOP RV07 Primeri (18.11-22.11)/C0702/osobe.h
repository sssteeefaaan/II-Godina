// osobe.h - Klase osoba, djaka i zaposlenih.

#include <string>
#include <iostream>
using namespace std;

class Osoba {
  string ime, datum, adresa;
public:
  Osoba() {}
  virtual void citaj();
  virtual void pisi() const;
};

class Djak: public Osoba {
  string skola, razred;
public:
  Djak(): Osoba() {}
  void citaj();
  void pisi () const;
};

class Zaposlen: public Osoba {
  string firma, odeljenje;
public:
  Zaposlen(): Osoba() {}
  void citaj();
  void pisi () const;
};
