// datum.h - Definicija klase kalendarskih datuma.

class Datum {
  static const short duz[][12],  // Brojevi dana po mesecima.
                     prot[][12]; // Protekli dani od pocetka godine.
  static const char *imeD[],     // Imena dana.
                    *imeM[];     // Imena meseci.
  short dan, mes, god;           // Komponente datuma.
public:
  static bool prestupna (short g);         // Da li je prestupna godina?
  bool prestupna () const { return prestupna (god); }   // ustanovi da li je godina prestupna. Ne moze da menja atribute objekta zbog const
  static bool moze (short d, short m, short g); // Da li je ispravan?
  void datum (short d, short m, short g);  // Stvaranje datuma.
  short uzmiDan () const { return dan; }   // Dohvatanje delova datuma.
  short uzmiMes () const { return mes; }
  short uzmiGod () const { return god; }
  void citaj ();                           // Citanje datuma.
  void pisi () const;                      // Pisanje datuma.
  int  danUGod () const;                   // Redni broj dana u godini.
  long ukDan () const;                     // Redni broj dana od 1.1.1.
  int  danUNed () const;                   // Redni broj dana u nedelji.
  int  duzMes () const;                    // Broj dana u mesecu.
  void sutra ();                           // Seledeci datum.
  void juce ();                            // Prethodni datum.
  void dodaj  (unsigned k);                // Dodavanje celog broja.
  void oduzmi (unsigned k);                // Oduzimanje celog broja.
  friend long razlika (Datum dat1, Datum dat2); // Razlika dva datuma.
  const char *imeDan () const;             // Ime dana. Zbog prvog constto sto f-ja vrati je nepromenljivo
  const char *imeMes () const;             // Ime meseca.
};

// Definicije metoda koje se ugradjuju neposredno u kod.

inline bool Datum::prestupna (short g)
  { return g%4==0 && g%100!=0 || g%400==0; }

inline bool Datum::moze (short d, short m, short g)
  { return g>0 && m>0 && m<=12 && d>0 && d<=duz[prestupna(g)][m-1]; }

#include <cstdlib>
using namespace std;

inline void Datum::datum (short d, short m, short g) {
  if (! moze (d, m, g)) exit (1);
  dan = d; mes = m; god = g;
}

inline int Datum::danUGod () const
  { return prot[prestupna()][mes-1] + dan; }

inline int Datum::danUNed () const { return (ukDan() + 6) % 7 + 1; }

inline int Datum::duzMes() const { return duz[prestupna()][mes - 1]; }

inline long razlika (Datum dat1, Datum dat2)
  { return dat1.ukDan () - dat2.ukDan (); }

inline const char* Datum::imeMes () const { return imeM[mes-1]; }

inline const char* Datum::imeDan () const { return imeD[danUNed()-1]; }
