#include "Complex.h"

Complex::Complex()
{
	real = 0;
	imag = 0;
}

Complex::Complex(double r, double i)
{
	real = r;
	imag = i;
}

Complex Complex::operator! ()
{
	Complex c(- this->real, - this->imag);
	return c;
}

void stampaj(Complex& c)
{
	printf ("realni=%f, imaginarni=%f \n", c.real, c.imag);
}

Complex Complex::operator- (Complex& a)
{
	// b = t - a
	Complex b;
	b.real = this->real - a.real;
	b.imag = this->imag - a.imag;
	return b;
}

Complex operator/ (Complex& a, Complex& b)
{
	Complex c;
	c.real = a.real / b.real;
	c.imag = a.imag / b.imag;
	return c;
}


