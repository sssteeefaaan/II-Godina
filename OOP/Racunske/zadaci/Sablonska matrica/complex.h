// Srdjan Rilak
// indeks: 11293
// Grupa C

#include "iostream.h"


//																		2


class Complex {

private:

	float re, im;

public:

	Complex();
	Complex(float r, float i);
	virtual ~Complex();

	Complex operator+ (Complex& rhs);
	char operator< (Complex& rhs);
	
	friend istream& operator>> (istream& str, Complex& rhs);
	friend ostream& operator<< (ostream& str, Complex& rhs);

};
