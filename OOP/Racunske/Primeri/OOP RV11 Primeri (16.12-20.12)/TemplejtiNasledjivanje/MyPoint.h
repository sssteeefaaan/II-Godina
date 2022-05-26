#pragma once
class MyPoint
{
protected:
	double x, y;
public:

	MyPoint(void)
	{
		x= y = 0;
	}

	MyPoint(double apc, double ord)
	{
		x = apc;
		y = ord;
	}

	double GetX()
	{
		return x;
	}

	double GetY()
	{
		return y;
	}

	virtual ~MyPoint(void)
	{
	}
};

template<class T>
class testClass : MyPoint
{
	testClass()
	{
		x = 14;
		y = 22;
	}
};

