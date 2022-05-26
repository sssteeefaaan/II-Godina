#pragma once
#include "obojenikrug.h"

class ZeleniKrug : public ObojeniKrug
{
public:
	ZeleniKrug(void);
	ZeleniKrug(double polup) 
		: ObojeniKrug(0, 200, 0, polup)
	{
		//this->x = 45;
		
	}

	ZeleniKrug(ZeleniKrug& zk)
	{
		this->G = zk.G;
	}

	void operator+=(int zel)
	{
		G += zel;
		if (G > 255) G = 255;
	}

	virtual void promeniR(double r)
	{
		this->r -= r;
	};

	void stampaj()
	{

	}

	~ZeleniKrug(void);
};
