// trougao2t.C - Ispitivanje klase trouglova.

#include "trougao2.h"
#include <iostream>
using namespace std;

int main() {
  cout << "Broj trouglova? "; int n; cin >> n;
  Trougao* niz = new Trougao [n];
  for (int i=0; i<n; ) {
    cout << i+1 << ". trougao? ";
    double a, b, c; cin >> a >> b >> c;
    if (Trougao::moze(a,b,c)) niz[i++] = Trougao(a, b, c);
      else cout << "*** Neprihvatljive stranice! ***\n";
  }
  for (int i=0; i<n-1; i++)
    for (int j=i+1; j<n; j++)
      if (niz[j].P() < niz[i].P())
        { Trougao pom = niz[i]; niz[i] = niz[j]; niz[j] = pom; }
  cout << "\nUredjeni niz trouglova:\n";
  for (int i=0; i<n; i++) {
    cout << i+1 << ": "; niz[i].pisi();
    cout << " P=" << niz[i].P() << endl;
  }
  delete [] niz;
}
