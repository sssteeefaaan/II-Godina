#pragma once
#include "operacija.h"
class kalkulator
{
	int akumulator;
	char* naziv;
	operacija** stek;
	int brop;
	int top;
public:
	kalkulator();
	~kalkulator();
	kalkulator(char*,int);
	void brisi();  // ocisti stek
	void Do(operacija& novaOperacija);  // izvrsi operaciju i stavi je u stek
	void Undo();  // izbaci operaciju iz steka i izvrsi suprotnu operaciju
	void Print();
	void Redim();
};