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
		this->r = r;
	};
	virtual void promeniR(double r)
	{
		this->r = r;
	};
	virtual std::ostream& stampaj(std::ostream& out) const;
	friend std::ostream& operator<<(std::ostream& out, const Krug& K) { return K.stampaj(out); }
};
