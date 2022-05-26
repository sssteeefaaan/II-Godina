// Visak.h: interface for the Visak class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_VISAK_H__D9749E47_3345_404F_B057_32E9FBF8EAC3__INCLUDED_)
#define AFX_VISAK_H__D9749E47_3345_404F_B057_32E9FBF8EAC3__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
#include "Valjak.h"
#include "Kupa.h"

class Visak : public Valjak, public Kupa 
{
public:
	float zapremina();
	float povrsina();
	Visak(float r1, float H1, float r2,float H2);
	virtual ~Visak();

};

#endif // !defined(AFX_VISAK_H__D9749E47_3345_404F_B057_32E9FBF8EAC3__INCLUDED_)
