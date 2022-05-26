#pragma once
#include <iostream>
using namespace std;


class Complex
{
	int re, im;
public:
	Complex(void);
	Complex(int r, int i)
	{
		re = r;
		im = i;
	}
	~Complex(void);

	friend ostream& operator<< (ostream& out, Complex& c);

	/*bool operator>(Complex& x)
	{
		return x.re > this->re;
	}*/
};

