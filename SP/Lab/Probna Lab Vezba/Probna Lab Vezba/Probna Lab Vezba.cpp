#include "CPolynom.h"

void main()
{
	CPolynom* P1 = new CPolynom(5);
	CPolynom* P2 = new CPolynom(7);

	for (int i = 0; i < 6; i++)
		P1->Coef(i, i*3);
	for (int i = 0; i < 8; i++)
		P2->Coef(i, (i * (-2)));

	P1->Print();
	P2->Print();

	CPolynom* Pz = CPolynom::Add(*P1, *P2);
	CPolynom* Pp = CPolynom::Mul(*P1, *P2);

	Pz->Print();
	Pp->Print();

	delete P1;
	delete P2;
	delete Pz;
	delete Pp;
}