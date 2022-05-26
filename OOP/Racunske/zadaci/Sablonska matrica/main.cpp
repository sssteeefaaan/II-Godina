/*
U C++-u napisati program za rad sa matricama. Kreirati generi?ku klasu Matrica, gde su privatni 
?lanovi dinami?ka matrica proizvoljnog tipa i njene dimenzije, a javni slede?e funkcije: 
"	konstruktor koji inicijalizuje dimenzije matrice, 
"	funkcija za unos elemenata matrice, 
"	funkcija za izra?unavanje zbira dve matrice (ukoliko su im dimenzije jednake),
"	funkcija za nalaženje maksimalnog elementa u k-toj vrsti (ulazni argument) matrice,
"	prijateljska operatorska funkcija << za štampanje matrice na standardni izlaz

Zatim definisati klasu Complex za predstavljanje kompleksnih brojeva koja u privatnom delu sadrži 
dva realna atributa koji predstavljaju realni i imaginarni deo kompleksnog broja, a u javnom: 
"	podrazumevani konstruktor, koji obe komponente broja postavlja na nulu, 
"	konstruktor koji obe komponente broja postavlja na zadate vrednosti,
"	operatorsku funkciju + za sabiranje  dva kompleksna broja 
"	operatorsku funkciju  < za poredjenje dva kompleksna broja 
"	prijateljsku operatorsku funkciju >>  za u?itavanje kompleksnog broja
"	prijateljsku operatorsku funkciju << za prikaz kompleksnog broja. 

U funkciji main kreirati matricu celih i matricu kompleksnih brojeva i sve funkcije klase Matrica 
testirati na jednom i drugom objektu.
*/

#include "complex.h"
#include "iostream.h"
#include "matrica.h"

int main(int paramCnt, char** paramStr){


	Matrica<Complex> a(2,3), b(2,3);
	Matrica<int> c(3,4), d(3,4);

	cout << "---RAD SA KOMPLEKSNIM MATRICAMA ---\n";
	cout << "Ucitajte prvu matricu: \n";
	a.read();
	cout << "Ucitajte drugu matricu: \n";
	b.read();

	cout << "\n--- Prva matrica je ---\n" << a;
	cout << "\n--- Druga matrica je ---\n" << b;

	a.saberi(b);

	cout << "\n---Njihov zbir je---\n" <<a <<"\n";

	cout <<  "Najveci broj u nultoj koloni zbira je: " << a.max(0) <<"\n";
	

	cout << "\n\n\n---RAD SA CELOBROJNIM MATRICAMA ---\n";
	cout << "Ucitajte prvu matricu: \n";
	c.read();
	cout << "Ucitajte drugu matricu: \n";
	d.read();

	cout << "\n--- Prva matrica je ---\n" << c;
	cout << "\n--- Druga matrica je ---\n" << d;

	c.saberi(d);

	cout << "\n---Njihov zbir je---\n" <<c <<"\n";

	cout <<  "Najveci broj u nultoj koloni zbira je: " << c.max(0) <<"\n";
	

return 0;}
