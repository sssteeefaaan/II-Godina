// RacionalanBroj.h: interface for the RacionalanBroj class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_RACIONALANBROJ_H__047ED016_31B9_4E66_B7FF_3A3735F48E9B__INCLUDED_)
#define AFX_RACIONALANBROJ_H__047ED016_31B9_4E66_B7FF_3A3735F48E9B__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#include <iostream.h>

class RacionalanBroj  
{
private:
	int brojilac;
	int imenilac; 
public:
	bool operator<( const RacionalanBroj& r );
	friend istream& operator>>( istream& ulaz, RacionalanBroj& r);
	friend ostream& operator<<( ostream& izlaz, const RacionalanBroj& r);
	
};

#endif // !defined(AFX_RACIONALANBROJ_H__047ED016_31B9_4E66_B7FF_3A3735F48E9B__INCLUDED_)
