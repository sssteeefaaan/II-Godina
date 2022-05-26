#pragma once
#include <iostream>
#include <math.h>
using namespace std;
class CPolynom
{
private:
	double* P;
	int Red;

public:
	CPolynom(int order);
	CPolynom(const CPolynom& Org);
	~CPolynom();
	const inline int GetRed()
	{
		return Red;
	}
	void Zauzmi(int N);
	void Obrisi();
	void Coef(int exp, double coef);
	double GetCoef(int exp);
	static CPolynom*Add(CPolynom P1, CPolynom P2)
	{
		int N = (P1.GetRed() >= P2.GetRed()) ? P1.GetRed() : P2.GetRed();
		CPolynom* PZ = new CPolynom(N);
		for (int i = 0; i <= N; i++)
			PZ->Coef(i, (P1.GetCoef(i) + P2.GetCoef(i)));
		return PZ;
	}
	static CPolynom* Mul(CPolynom P1, CPolynom P2)
	{
		int N = P1.GetRed() + P2.GetRed();
		CPolynom* PP = new CPolynom(N);
		for (int i = 0; i <= P1.GetRed(); i++)
			for (int j = 0; j <= P2.GetRed(); j++)
				PP->Coef(i + j, (P1.GetCoef(i) * P2.GetCoef(j)) + PP->GetCoef(i + j));
		return PP;
	}
	void Print();
};

