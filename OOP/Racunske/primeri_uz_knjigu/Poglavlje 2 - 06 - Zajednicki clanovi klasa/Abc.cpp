#include "Abc.h"

int Abc::a = 10;	// definisanje zajednickog atributa

int Abc::getA()
{
	//posto je staticka moze pristupati samo zajednickim (static) atributima
	return Abc::a;
	//return this->a;	// GRESKA, zajednicke metode nemaju pokazivace this
}

int Abc::getB(){
	return b;
}

void Abc::incA()
{
	// nije zajednicka (static) metoda, moze pristupati i zajednickim i pojedinacnim atribtuima
	Abc::a ++;

}

