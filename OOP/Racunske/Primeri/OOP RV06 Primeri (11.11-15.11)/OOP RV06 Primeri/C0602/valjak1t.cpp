// valjak1t.C - Ispitivanje klase valjaka i kanti.

#include "kanta.h"
#include <iostream>
using namespace std;

int main() {
  Valjak v1(2, 3);     cout << "v1    : " <<  v1 << ' ' << v1.V() << endl;
  Kanta  k1(1, 3, 10); cout << "k1(10): " <<  k1 << ' ' << k1.V() << endl;
                       cout << "k1-=5 : " << (k1-=5) << endl;
                       cout << "k1+=4 : " << (k1+=4) << endl;
  Kanta  k2(0.6, 5);   cout << "k2(0) : " <<  k2 << ' ' << k2.V() << endl;
                       cout << "k2=k1 : " << (k2=k1) << endl;
                       cout << "k1    : " <<  k1 << endl;
  Valjak& uv = k1;     cout << "uv    : " <<  uv << ' ' << uv.V()  << endl;
  Valjak* pv = &k1;    cout << "*pv   : " << *pv << ' ' << pv->V() << endl;
  Kanta&  uk = k1;     cout << "uk    : " <<  uk << ' ' << uk.V()  << endl;
}
