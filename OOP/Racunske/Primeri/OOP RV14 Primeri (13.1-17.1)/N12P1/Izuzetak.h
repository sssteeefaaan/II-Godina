#pragma once
#include <iostream>
using namespace std;
#include<string.h>

class Izuzetak
{
protected:
	char* tekst;
public:
	Izuzetak()
	{
		
	}
	virtual ~Izuzetak()
	{
		delete tekst;
	}
	friend ostream& operator<<(ostream& izlaz,Izuzetak& x)
	{
		izlaz<<x.tekst;
		return izlaz;
	}
};

class Stepennepostoji:public Izuzetak
{
public:
	Stepennepostoji()
	{
		tekst = strdup("Stepen nije ispravan");
	}
};
class NegStepen:public Izuzetak
{
public:
	NegStepen()
	{
		tekst = strdup("Stepen je negativan");
	}
};
class NeispravnoOtvaranje:public Izuzetak
{
public:
	NeispravnoOtvaranje()
	{
		tekst = strdup("Datoteka nije otvorena");
	}
};
class Brojnijenegativan:public Izuzetak
{
public:
	Brojnijenegativan()
	{
		tekst = strdup("Broj nije negativan");
	}
};