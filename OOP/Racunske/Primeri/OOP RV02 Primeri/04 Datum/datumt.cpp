// datumt.cpp - Ispitivanje klase kalendarskih datuma.

#include "datum.h"
#include <iostream>
using namespace std;

int main () {
 Datum dat1, dat2;
 cout << "Danasnji datum? "; dat1.citaj ();
 cout << "Datum rodjenja? "; dat2.citaj ();
 dat1.pisi ();
 cout << " je " << dat1.imeDan() << ", "
                << dat1.danUGod() << ". dan u godini.\n"
      << "Rodili ste se u " << dat2.imeDan() << " i imate "
                            << razlika(dat1,dat2) << " dana.\n";
 return 0;
}
