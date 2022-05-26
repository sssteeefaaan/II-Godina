// osobe.C - Metode klasa osoba, djaka i zaposlenih.

#include "osobe.h"

void Osoba::citaj() {
  cout << "Ime i prezime?     "; getline(cin, ime);
  cout << "Datum rodjenja?    "; getline(cin, datum);
  cout << "Adresa stanovanja? "; getline(cin, adresa);
}

void Osoba::pisi () const {
  cout << "Ime i prezime:     " << ime       << endl;
  cout << "Datum rodjenja:    " << datum     << endl;
  cout << "Adresa stanovanja: " << adresa    << endl;
}

void Djak::citaj() {
  Osoba::citaj();
  cout << "Naziv skole?       "; getline(cin, skola);
  cout << "Razred?            "; getline(cin, razred);
}

void Djak::pisi () const {
  Osoba::pisi();
  cout << "Naziv skole:       " << skola     << endl;
  cout << "Razred:            " << razred    << endl;
}

void Zaposlen::citaj() {
  Osoba::citaj();
  cout << "Naziv firme?       "; getline(cin, firma);
  cout << "Naziv odeljenja?   "; getline(cin, odeljenje);
}

void Zaposlen::pisi() const {
  Osoba::pisi();
  cout << "Naziv firme:       " << firma     << endl;
  cout << "Naziv odeljenja:   " << odeljenje << endl;
}
