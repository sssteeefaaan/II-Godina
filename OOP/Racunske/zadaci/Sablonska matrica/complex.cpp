// Srdjan Rilak
// indeks: 11293
// Grupa C

#include "complex.h"

//																		1

Complex::Complex()
{
	re=0;
	im=0;
};

//																		1

Complex::Complex(float r, float i){
	
	re=r;
	im=i;
};


Complex::~Complex(){};

//																		1
Complex Complex::operator+ (Complex& rhs){

	Complex pom;

	pom.re = re + rhs.re;
	pom.im = re + rhs.im;

	return pom;
};

//																		2
// char?
char Complex::operator< (Complex& rhs){

	//Uporedjuje kvadrate modula kompleksnih brojeva. Kako su
	//moduli uvek nenegativni, ovo je ekvivalentno poredjenju 
	//samih modula

	if ( (re*re + im*im) < (rhs.re*rhs.re + rhs.im*rhs.im) )
	return 1;
	else return 0;
};
	
//																		1

istream& operator>> (istream& str, Complex& rhs){

	str >> rhs.re >> rhs.im ;
	return str;
};

//																		1

ostream& operator<< (ostream& str, Complex& rhs){

	str << "(" <<rhs.re <<"," << rhs.im <<")";
	return str;
};

