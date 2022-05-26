#pragma once
#include <iostream>
using namespace std;

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
	Complex operator* (Complex& a);
	friend Complex operator* (double left, const Complex& a);
	Complex& operator=( const Complex& v );
	friend Complex operator/ (Complex& a, Complex& b);
	friend void stampaj(Complex& c);
	Complex& operator++(); // ++c
	Complex operator++( int n ); // c++

	friend istream& operator>>( istream& ulaz, Complex& v);
	friend ostream& operator<<( ostream& izlaz, Complex& v);
	friend Complex operator*( double levi, const Complex& desni);	
};