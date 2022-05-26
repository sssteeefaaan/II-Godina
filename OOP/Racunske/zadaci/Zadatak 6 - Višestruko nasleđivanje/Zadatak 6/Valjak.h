// Valjak.h: interface for the Valjak class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_VALJAK_H__6B62B242_91D3_4E25_9476_32453DCCF61D__INCLUDED_)
#define AFX_VALJAK_H__6B62B242_91D3_4E25_9476_32453DCCF61D__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
#include "Krug.h"

class Valjak : public Krug  
{
protected:
	float H;
public:
	virtual float zapremina();
	virtual float povrsina();
	Valjak(float pp, float visina);
	virtual ~Valjak();

};

#endif // !defined(AFX_VALJAK_H__6B62B242_91D3_4E25_9476_32453DCCF61D__INCLUDED_)
