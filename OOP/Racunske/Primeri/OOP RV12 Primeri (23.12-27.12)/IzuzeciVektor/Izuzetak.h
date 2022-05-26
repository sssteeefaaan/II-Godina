// Izuzetak.h: interface for the Izuzetak class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_IZUZETAK_H__6A000759_9B5B_4E71_B86F_C9230C5E6518__INCLUDED_)
#define AFX_IZUZETAK_H__6A000759_9B5B_4E71_B86F_C9230C5E6518__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

class Izuzetak  
{
	char poruka[50];
public:
	Izuzetak(char* poruka);
	virtual ~Izuzetak();
	void prikazi();

};

#endif // !defined(AFX_IZUZETAK_H__6A000759_9B5B_4E71_B86F_C9230C5E6518__INCLUDED_)
