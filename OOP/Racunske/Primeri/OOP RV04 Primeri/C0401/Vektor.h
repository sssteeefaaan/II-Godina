#include <iostream>

using namespace std;

class Vektor
{
	unsigned int n;
	int* niz;
public:
	Vektor( int velicina );

	Vektor( const Vektor& v );
	~Vektor();
	Vektor& operator=( const Vektor& v );
	int& operator[](int n);

	void in();
	void out();
	Vektor* saberi(Vektor v2);    	
	Vektor saberi(Vektor* v2);
};