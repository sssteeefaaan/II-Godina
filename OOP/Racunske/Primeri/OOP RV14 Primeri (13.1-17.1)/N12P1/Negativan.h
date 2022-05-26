#pragma once

#include"Polinom.h"

class NegativanCeoBroj
{
	int n;
public:
	NegativanCeoBroj()
	{
		n=-1;
	}

	NegativanCeoBroj(int x)
	{
		this->SetN(x);		
	}

	void SetN(int x)
	{
		n = x;
		if (x > -1)
			n = -1;
	}

	NegativanCeoBroj(float x)
	{
		int p;
		p=(int) x;
		this->SetN(p);
	}

	NegativanCeoBroj& operator=(float x)
	{
		this->SetN(x);
		return *this;
	}

	friend ostream& operator<<(ostream& izlaz,NegativanCeoBroj& x)
	{
		izlaz<<x.n;
		return izlaz;
	}

	friend istream& operator>>(istream& ulaz,NegativanCeoBroj& x)
	{
		ulaz>>x.n;
		if (x.n > -1)
		{
			throw Brojnijenegativan();
		}
		return ulaz;
	}

	NegativanCeoBroj& operator+(NegativanCeoBroj& x)
	{
		this->n=this->n+x.n;
		return *this;
	}
};