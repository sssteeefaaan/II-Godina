// Matrica.h: interface for the Matrica class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_MATRICA_H__1296BBDF_543E_4E01_9F33_D5401E2C8DD9__INCLUDED_)
#define AFX_MATRICA_H__1296BBDF_543E_4E01_9F33_D5401E2C8DD9__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

class Matrica  
{
public:
	Matrica pomnozi( const Matrica& m );
	void prikazi();
	void ucitaj();
	Matrica( const Matrica& mat );
	Matrica( int brVrsta, int brKolona);
	Matrica();
	virtual ~Matrica();

private:
	int** a;
	int m;	// broj kolona
	int n;	//broj vrsta
};

#endif // !defined(AFX_MATRICA_H__1296BBDF_543E_4E01_9F33_D5401E2C8DD9__INCLUDED_)
