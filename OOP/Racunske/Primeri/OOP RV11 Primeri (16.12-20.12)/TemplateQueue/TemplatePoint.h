#pragma once
#include <iostream>
using namespace std;

template <class T>
class TemplatePoint
{
	T x;
	T y;
public:

	TemplatePoint(void)
	{
		
	}

	virtual ~TemplatePoint(void)
	{
	}

	TemplatePoint(T aps, T ord)
	{
		x = aps;
		y = ord;;
	}

	T& GetX()
	{
		return x;
	}

	T& GetY()
	{
		return y;
	}

	void SetX(T& aps)
	{
		x = aps;
	}

	void SetY(T& ord)
	{
		y = ord;
	}

	friend ostream& operator<< <>(ostream& out, TemplatePoint<T>& c);
};

template<class T>
ostream& operator<< (ostream& out, TemplatePoint<T>& c)
{
	out << c.GetX() << ", " << c.GetY() << endl;
	return out;
};

