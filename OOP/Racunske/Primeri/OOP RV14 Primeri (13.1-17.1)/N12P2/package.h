
#pragma once
#include <iostream>
using namespace std;

class package
{
	char naziv[30];
	float kolicina;
public:
	package();
	package(char* x, float n);
	void operator=(float n);
	friend ostream& operator<<(ostream& out, package& p);
	friend istream& operator>>(istream& in, package& p);
	bool operator>(float n);
};