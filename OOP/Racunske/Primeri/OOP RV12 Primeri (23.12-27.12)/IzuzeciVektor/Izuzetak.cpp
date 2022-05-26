// Izuzetak.cpp: implementation of the Izuzetak class.
//
//////////////////////////////////////////////////////////////////////

#include "Izuzetak.h"
#include <string.h>
#include <iostream>
using namespace std;

//////////////////////////////////////////////////////////////////////
// Construction/Destruction
//////////////////////////////////////////////////////////////////////

Izuzetak::Izuzetak(char* poruka)
{
	strcpy( this->poruka, poruka );
}

Izuzetak::~Izuzetak()
{

}

void Izuzetak::prikazi()
{
	cout << poruka;
}
