// predstavat.C - Ispitivanje klasa predstava i karata.

#include "predstava.h"
#include <iostream>
using namespace std;

int main() {
  Predstava p("Naslov", 20090308, 4, 6);
  p += Karta(0, 3, 800);
  p += Karta(3, 5, 200);
  p += Karta(2, 1, 500);
  cout << p << endl << p.vrednost() << endl;
}

