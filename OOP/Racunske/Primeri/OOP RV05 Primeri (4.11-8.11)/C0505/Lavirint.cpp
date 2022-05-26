#include "Lavirint.h"


Lavirint::Lavirint(void)
{
	this->vrste = 5;
	this->kolone = 5;
	init();
}

void Lavirint::init()
{
	mojPacmanX = 0;
	mojPacmanY = 0;
	this->elementi = new PacmanObject**[vrste];

	for (int i = 0; i < vrste; i++)
	{
		this->elementi[i] = new PacmanObject*[kolone];
	}

	for (int i = 0; i < vrste; i++)
	{
		for (int j = 0; j < kolone; j++)
		{
			this->elementi[i][j] = 0;
		}
	}
}


Lavirint::~Lavirint(void)
{	
	clear();	
}

void Lavirint::clear()
{
	for (int i = 0; i < vrste; i++)
	{
		delete[] this->elementi[i];
	}

	delete[] this->elementi;
}
