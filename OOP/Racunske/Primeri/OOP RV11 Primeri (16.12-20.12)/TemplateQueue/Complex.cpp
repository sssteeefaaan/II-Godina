#include "Complex.h"


Complex::Complex(void)
{
	re = 0;
	im = 0;
}


Complex::~Complex(void)
{
}

ostream& operator<< (ostream& out, Complex& c)
{
	out << c.re << "+i" << c.im;
	return out;
}
