#include "Complex.h"

Complex::Complex()
{
	real = imag = 0;
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
	cout << "realni=" << c.real << ",imaginarni=" << c.imag <<endl;
}

Complex Complex::operator- (Complex& a)
{	
	Complex b;
	b.real = this->real - a.real;
	b.imag = this->imag - a.imag;
	return b;
}

Complex Complex::operator* (Complex& a)		//	OVO AJDE UBOO
{	
	Complex b;
	b.real = this->real * a.real - this->imag * a.imag;
	b.imag = this->imag * a.real + this->real * a.imag;
	return b;
}

Complex operator/ (Complex& a, Complex& b)	//	HAHAHAHAH VRH
{
	Complex c;

	/*	PECO, PECO, ŠTA LI TI PIŠEŠ????
	c.real = a.real / b.real;
	c.imag = a.imag / b.imag;
	*/

	double modB = b.real * b.real + b.imag * b.imag;
	c.real = (a.real * b.real + a.imag * b.imag) / modB;
	c.imag = (a.imag * b.real - a.real * b.imag) / modB;

	return c;
}

Complex& Complex::operator++()
{
	this->real +=1;
	this->imag +=1;
	return *this;
}

Complex Complex::operator++( int n )
{
	Complex rezultat( *this );
	this->real+=1;
	this->imag+=1;
	return rezultat;
}

ostream& operator<<( ostream& izlaz, Complex& v)
{
	izlaz << v.imag << " + i" << v.real;
	izlaz << endl;
	return izlaz;
}

istream& operator>>( istream& ulaz, Complex& v)
{
	ulaz >> v.real >> v.imag;
	return ulaz;
}

Complex operator*(double levi, const Complex& desni)
{
	Complex c(levi*desni.real, levi*desni.imag);
	return c;
}

Complex& Complex::operator=(const Complex& v)
{
	if ( this != &v )
	{
		this->imag = v.imag;
		this->real = v.real;
	}
	return *this;
}

