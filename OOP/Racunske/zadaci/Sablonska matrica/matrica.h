// Srdjan Rilak
// indeks: 11293
// Grupa C

//																		3

#include "iostream.h"

template <class T>
class Matrica {


public:

//	Matrica();
	Matrica(unsigned int noKolona, unsigned int noVrsta);
	Matrica(Matrica& rhs);
	virtual ~Matrica();

	void read();
	void saberi(Matrica& mat);
	T max(unsigned int k);

	friend ostream& operator<< (ostream& str, Matrica& rhs);

private:

	unsigned int kolona, vrsta;
	T** pool;

};

//																		1

template <class T>
Matrica<T>::Matrica(unsigned int noKolona, unsigned int noVrsta){

	kolona = noKolona;
	vrsta = noVrsta;

	pool = new T* [vrsta];

	unsigned int i;

	for (i=0; i<vrsta; i++)
		pool[i] = new T[kolona];
};

//																		2

template <class T>
Matrica<T>::Matrica(Matrica& rhs){

	kolona = rhs.kolona;
	vrsta = rhs.vrsta;

	pool = new T* [vrsta];

	unsigned int i, j;

	for (i=0; i<vrsta; i++)
		pool[i] = new T[kolona];

	for (i=0; i<vrsta; i++)
		for (j=0; j<kolona; j++)
			pool[i][j] = rhs.pool[i][j];
		
};


template <class T>
Matrica<T>::~Matrica(){

	unsigned int i;

	for (i=0; i<vrsta; i++)
		delete [] pool[i];

	delete [] pool;
};

//																		1

template <class T>
void Matrica<T>::read(){

	unsigned int i, j;

	for (i=0; i<vrsta; i++){

		cout << "Unosite elemente " <<i <<". vrste matrice:\n";

		for (j=0; j<kolona; j++) {

			cout << "Unesite " <<j <<". element: ";
			cin  >> pool[i][j];
		}
	}
};

//																		2


template <class T>
void Matrica<T>::saberi(Matrica& mat){

	if ( (vrsta!=mat.vrsta) || (kolona!=mat.kolona) )
		throw "Greska: Matrica se ne mogu sabrati!";

	unsigned int i, j;

	for (i=0; i<vrsta; i++)
		for (j=0; j<kolona; j++)
			pool[i][j] = pool[i][j] + mat.pool[i][j];
	
};


//																		1

template <class T>
T Matrica<T>::max(unsigned int k){

	if (k>=vrsta) throw "Greska: Prekoracenje broja kolona!";

	T pom = pool[k][0];

	unsigned int i;

	for (i=1; i<kolona; i++)
		if ( pom < pool[k][i] ) pom = pool[k][i];

	return pom;
};

//																		1


template <class T>
ostream& operator<< (ostream& str, Matrica<T>& rhs){

	unsigned int i, j;

	for (i=0; i<rhs.vrsta; i++){

		for (j=0; j<rhs.kolona; j++)
			cout << rhs.pool[i][j] << "  ";

		cout << "\n";
	}

	return str;

};

