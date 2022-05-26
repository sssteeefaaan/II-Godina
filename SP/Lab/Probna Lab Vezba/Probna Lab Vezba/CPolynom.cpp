#include "CPolynom.h"
CPolynom::CPolynom(int order = 0)
{
	Zauzmi(order);
}
CPolynom::CPolynom(const CPolynom& Org)
{
	this->Zauzmi(Org.Red);
	for (int i = 0; i <= Red; i++)
		this->P[i] = Org.P[i];
}
CPolynom::~CPolynom()
{
	this->Obrisi();
}
void CPolynom::Zauzmi(int N)
{
	P = new double[(Red = N) + 1];
	for (int i = 0; i <= Red; i++)
		P[i] = 0;
}
void CPolynom::Obrisi()
{
	if (Red != 0)
		delete[] P;
}
void CPolynom::Coef(int exp, double coef)
{
	if (exp >= 0 && exp <= Red)
		P[exp] = coef;
	else
		cout << "Greska u stepenu." << endl;
}
double CPolynom::GetCoef(int exp)
{
	if (exp > Red || exp < 0)
		return 0;
	else
		return P[exp];
}
void CPolynom::Print()
{
	cout << "P = " << this->GetCoef(Red) << "x^" << Red;
	double N;
	for (int i = Red - 1; i >= 0; i--)
	{
		N = this->GetCoef(i);
		if (N != 0)
		{
			if (N > 0)
				cout << " + " << N;
			else if (N < 0)
				cout << " - " << fabs(N);
			if (i > 1)
				cout << "x^" << i;
			else
				if (i == 1)
					cout << "x";
		}
	}
	cout << endl;
}