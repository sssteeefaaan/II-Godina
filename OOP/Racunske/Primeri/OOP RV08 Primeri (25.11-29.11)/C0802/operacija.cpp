#include "operacija.h"
#include <iostream>
using namespace std;

operacija :: operacija(char * novinaziv, int op)
{
	naziv = new char[strlen(novinaziv) + 1];
	strcpy(naziv, novinaziv);

	this->drugioperand = op;
}

operacija::~operacija()
{
	delete naziv;
}

int operacija::vroperand()
{
	return this->drugioperand;
};

void operacija::stampa()
{
	cout<<"operacija " << this->naziv << " " << this->drugioperand << "=>"<<"suprotna operacija " << this->suprotna()->naziv<<endl;
};



