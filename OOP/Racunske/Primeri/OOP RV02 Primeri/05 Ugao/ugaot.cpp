// ugaot.C - Ispitivanje klase uglova.

#include "ugao.h"
#include <iostream>
using namespace std;

int main () {
  Ugao u1, u2;
  cout << "Prvi  ugao [rad]? "; u1.citaj ();
  cout << "Drugi ugao [rad]? "; u2.citaj ();
  Ugao* sr = u1.dodaj (u2).pomnozi (0.5);
  cout << "Srednja vrednost= "; sr->pisi();      cout << ' ';
                                sr->pisiStep (); cout << endl;
  delete sr;
  return 0;
}
