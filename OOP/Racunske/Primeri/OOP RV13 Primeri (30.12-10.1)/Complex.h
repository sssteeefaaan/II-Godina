#pragma once

#include <iostream>
using namespace std;

template<class T>
class Complex
{
	T real;
	T imag;

public:
	Complex();
	Complex(T r, T i);
	~Complex() {}

	double Moduo();
	bool operator <(Complex<T>& complex);

	friend ostream& operator << <>(ostream& ispis, Complex<T>& complex);
};

template <class T>
Complex<T>::Complex()
{
	imag = 0;
	real = 0;
}

template <class T>
Complex<T>::Complex(T r, T i)
{
	real = r;
	imag = i;
}

template <class T>
double Complex<T>::Moduo()
{
	return real*real + imag*imag;
}

template <class T>
bool Complex<T>::operator<(Complex<T>& complex)
{
	return Moduo() < complex.Moduo();
}

template <class T>
ostream& operator << (ostream& out, Complex<T>& complex)
{
	out << complex.real;
	if (complex.imag >= 0)
	{
		out << "+i";
	}
	else
	{
		out << "-i";
	}
	out << abs(complex.imag);
	//out << endl;

	return out;
}

