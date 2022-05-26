// ugao.h - Definicija klase uglova.

#include <iostream>
using namespace std;

const double FAKTOR = 3.14159265358979323 / 180;

class Ugao {
  double ugao;                           // Ugao u radijanima.
  void postavi(int stp, int min, int sek)   //  - na osnovu stepeni.
  {
	  ugao = ((sek / 60. + min) / 60 + stp) * FAKTOR;
  }
public:                                  // Konstruktori:
  Ugao (double u=0)                      //  - podrazumevani i
    { ugao = u; }                        //    konverzije,
  Ugao (int stp, int min, int sek)   //  - na osnovu stepeni.
   { postavi(stp, min, sek); }
  
  double rad () const { return ugao; }             // Radijani.
  int stp () const {                               // Stepeni.
    return ugao / FAKTOR;
  }
  int min () const {                               // Minuti.
    return int (ugao / FAKTOR * 60) % 60;
  }
  int sek () const {                               // Sekunde.
    return int (ugao / FAKTOR * 3600) % 60;
  }
  void razlozi (int& st, int& mi, int& se) const { // Sve tri komponente
    st = stp (); mi = min (); se = sek () ;        //   odjednom
  }
  Ugao dodaj (Ugao& u)                   // Dodavanje ugla.
  { Ugao ugao(u.ugao + this->ugao);
	return ugao; 
  }
  Ugao* pomnozi (double a)               // Mnozenje realnim brojem.
    { Ugao* ret = new Ugao(ugao *= a); return ret; }
  void citaj () { cin >> ugao; }         // Citanje u radijanima.
  void citajStep () {                    // Citanje u stepenima.
    int stp, min, sek; cin >> stp >> min >> sek;
    postavi (stp, min, sek);
  }
  void pisi () const { cout << ugao; }   // Pisanje u radijanima;
  void pisiStep () const {               // Pisanje u stepenima.
    cout << '(' << stp() << ':' << min() << ':' << sek() << ')';
  }
};