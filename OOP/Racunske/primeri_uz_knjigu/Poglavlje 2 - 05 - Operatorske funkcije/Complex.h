#include <stdio.h>

class Complex  
{
public:
   double real;
	double imag;
public:
	Complex();
	Complex(double r, double i);
	Complex operator! ();
	Complex operator- (Complex& a);
	friend Complex operator/ (Complex& a, Complex& b);
	friend void stampaj(Complex& c);
};
