#include <iostream>
using namespace std;

class Vektor
{
	unsigned int n;
	int* niz;
public:
	Vektor( int velicina );
	~Vektor();
	int& vratiElement(int n);
	void in();
	void out();
	Vektor* saberi(Vektor* v2);    	
};