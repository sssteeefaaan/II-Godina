#include "kalkulator.h"
#include "operacija.h"
#include <string>
#include <iostream>
using namespace std;

kalkulator::kalkulator()
{
	akumulator = 0;
	naziv = 0;
	stek = 0;
	top = 0;
}

kalkulator::kalkulator(char* novinaziv, int brop)
{
	akumulator = 0;
	top = 0;
	this->brop = brop;
	naziv=new char[strlen(novinaziv) + 1];
	strcpy(naziv, novinaziv);

	stek = new operacija*[brop];
	top = 0;
	for(int i = 0; i < brop; i++)
		stek[i] = 0;
}

kalkulator::~kalkulator()
{
	delete[] naziv;
	delete [] stek;	
};

void kalkulator::brisi()
{ 
	delete [] stek;

	for(int i = 0; i < brop; i++)
		stek[i] = 0;

	akumulator = 0;
	top = 0;
};

//void kalkulator::Do(operacija& novaoperacija)
//{
//	if (top < brop)
//	{	
//		this->akumulator = novaoperacija.DoOperation(this->akumulator);
//		this->stek[top] = &novaoperacija;
//		top++;
//	}
//
//	this->Print();
//		
//};

void kalkulator::Do(operacija& novaoperacija)
{
	if (top == brop)
	{	
		Redim();
	}

	this->akumulator = novaoperacija.DoOperation(this->akumulator);
	this->stek[top] = &novaoperacija;
	top++;

	this->Print();
		
};

void kalkulator::Redim()
{
	operacija** pomocniStek = new operacija*[this->brop];
	int stariBrOp = this->brop;
	for(int i = 0; i < stariBrOp; i++)
		pomocniStek[i] = this->stek[i];
	delete[] stek;

	this->brop *= 2;
	stek = new operacija*[brop];
	for(int i = 0; i < brop; i++)
		stek[i] = 0;

	for(int i = 0; i < stariBrOp; i++)
		this->stek[i] = pomocniStek[i];

	delete[] pomocniStek;
}

void kalkulator::Undo()
{
	if (top > 0)
	{	
		top--;
		operacija* toUndo = this->stek[top];
		this->akumulator = toUndo->suprotna()->DoOperation(this->akumulator);

		delete this->stek[top];
		this->stek[top] = 0;
	}
	this->Print();
		
};

void kalkulator::Print()
{
	cout << endl << "Br operacija " << this->brop << endl;
	cout << "Top " << this->top << endl<<endl;
	cout << "Akumulator " << this->akumulator << endl;

	for (int i = brop - 1; i >=0; i--)
	{
		if (this->stek[i] == 0)
			cout << "---" << endl;
		else
			this->stek[i]->stampa();
	}
}
	
