// Vektor.h: interface for the Vektor class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_VEKTOR_H__84D3F892_A7A0_4ED6_A8C3_E935E15D16AB__INCLUDED_)
#define AFX_VEKTOR_H__84D3F892_A7A0_4ED6_A8C3_E935E15D16AB__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

class Vektor  
{
public:
	Vektor();
	virtual ~Vektor();
	Vektor( int gornjaGranica );
	Vektor( int donjaGranica, int gornjaGranica );
	Vektor( const Vektor& vektor );
	Vektor& operator=( const Vektor& desni );
	double& operator[]( int index );
	friend double operator*( const Vektor& levi, const Vektor& desni );
	enum Greska
	{
		NEKOREKTNE_GRANICE,
		POPUNJENA_MEMORIJA,
		VEKTOR_JE_PRAZAN,
		LOS_INDEX,
		RAZLICITE_VELICINE
	};

private:
	int dg;
	int gg;
	int velicina;
	double* niz;
	void kreiraj( int donjaGranica, int gornjaGranica);

};

#endif // !defined(AFX_VEKTOR_H__84D3F892_A7A0_4ED6_A8C3_E935E15D16AB__INCLUDED_)
