/*

Na programskom jeziku C++ kreirati templejtsku (šablonsku) klasu MATRICA koja u privatnom delu sadrži dimenzije matrice i 
dinamicku matricu ciji su elementi proizvoljnog tipa. U javnom delu definisati: konstruktor, destruktor, operatorsku funkciju
 za pristup elementima matrice, funkcije za vracanje dimenzija matrice, funkciju kojom se ispituje da li matrica sadrži 
 proizvoljnu podmatricu (podmatrica je argument funkcije tipa MATRICA) i funkcije za unos i štampanje sadržaja matrice.
 Kreirati klasu STR koja u privatnom delu sadrži podatak tipa string, a u javnom konstruktor, funkciju za citanje i upis 
 stringa, destruktor i prijateljsku operatorsku funkciju za poredenje dva stringa. U glavnom programu definisati 4 objekta
 tipa MATRICA, za elemente tipa STR, a potom za elemente tipa int i štampati one matrice koje nisu podmatrice drugih matrica.

(Zadatak je resio Milos Radmanovic)

*/

#include "Matrica.h"


void main()
{
	MATRICA<STR> a1(2,2), a2(2,2), a3(1,1), a4(1,1);
	MATRICA<int> b1(2,2), b2(2,2), b3(1,1), b4(1,1);
	a1.Unos();	a2.Unos();	a3.Unos();	a4.Unos();
	b1.Unos();	b2.Unos();	b3.Unos();	b4.Unos();
	if (!a2.P(a1) && !a3.P(a1) && !a4.P(a1))  a1.Stampanje();
	if (!a1.P(a2) && !a3.P(a2) && !a4.P(a2))  a2.Stampanje();
	if (!a1.P(a3) && !a2.P(a3) && !a4.P(a3))  a3.Stampanje();
	if (!a1.P(a4) && !a2.P(a4) && !a2.P(a4))  a4.Stampanje();
	if (!b2.P(b1) && !b3.P(b1) && !b4.P(b1))  b1.Stampanje();
	if (!b1.P(b2) && !b3.P(b2) && !b4.P(b2))  b2.Stampanje();
	if (!b1.P(b3) && !b2.P(b3) && !b4.P(b3))  b3.Stampanje();
	if (!b1.P(b4) && !b2.P(b4) && !b2.P(b4))  b4.Stampanje();
}
