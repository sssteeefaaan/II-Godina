#include "Duck.h"

int Duck::ActiveCount = 0;
int Duck::TotalCount = 0;


Duck::Duck(void)
{
	ActiveCount++;
	TotalCount++;
	id = TotalCount;
	power = 100;
	this->posX = 0;
	this->posY = 0;	

	cout <<"Duck. Konstruktor. Ukupno kreiranih:" << TotalCount << ". Aktivnih:" << ActiveCount<<endl;
}


Duck::~Duck(void)
{
	ActiveCount--;
	cout << "Duck. Destruktor. Ukupno kreiranih:" << TotalCount << ". Aktivnih:" << ActiveCount << endl;
}
