// inventart.C - Ispitivanje klasa zapisa i inventara.

#include "inventar.h"
#include <iostream>
using namespace std;

int main() {
  Inventar inv(8);
  inv += new Zapis("kruska", "kg",  95);
  inv += new Zapis("mleko" ,  "l",  75);
  inv += new Zapis("kabl"  ,  "m", 120);
  *inv["kruska"] += 8;
  *inv["mleko"]  += 35;
  *inv["kabl"]   += 155;
  cout << inv;
}

