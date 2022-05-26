#pragma once
#include "krug.h"

class ObojeniKrug :	public Krug
{
protected:
	int R, G, B;
public:
	ObojeniKrug(void);
	ObojeniKrug(int r1, int g1, int b1, int poluprecnik) 
		: Krug(poluprecnik)
	{
		R = r1;
		G = g1;
		B = b1;
	}

	ObojeniKrug(const ObojeniKrug& ob)
		: Krug(ob)
	{
		this->R = ob.B;
	}

	ObojeniKrug(int r1)
	{
		R = G = B = r = r1;
	}
	virtual ~ObojeniKrug(void);

	void promeniR(double r)
	{
		this->r += r;
	};

	virtual void stampaj();
};
