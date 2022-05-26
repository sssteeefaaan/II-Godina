#include <iostream>
#include "Complex.h"
using namespace std;

class Vektor
{
	int n;
	Complex* niz;
	void zauzmiMemoriju(int n);
	void oslobodiMemoriju();
	void kopirajNiz(const Vektor& v);
public:
	Vektor( int velicina );
	Vektor( const Vektor& v );
	~Vektor();

	friend Vektor operator*( double levi,  Vektor& desni);	
	Vektor operator*(const Vektor& desni);

	friend istream& operator>>( istream& ulaz, Vektor& v);
	friend ostream& operator<<( ostream& izlaz, Vektor& v);

	Vektor& operator=( const Vektor& v );
	Vektor& operator=(int t);
	Vektor& operator=(Complex ct);
	Complex operator[](int n);
};