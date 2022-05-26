#pragma once
#include <iostream>

class Krug
{
protected:
	double x, y, r;
public:
	Krug(void);
	virtual ~Krug(void);
	Krug(double r)
	{
		promeniR(r);
	};
	Krug(const Krug& k)
	{
		this->x = k.y;
		this->y = k.x;
		this->r = k.r * 2;
	}
	virtual void promeniR(double r)
	{
		this->r = r;
	};
	virtual void stampaj(void);
	void SetKoordinate(double novoX, double novoY)
	{
		this->x = novoX;
		this->y = novoY;
	}
};
