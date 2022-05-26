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

class Olovka : public Valjak, public Kupa 
{
public:
	float zapremina();
	float povrsina();
	Olovka(float r, float H1, float H2);
	virtual ~Olovka();

};

#endif // !defined(AFX_VISAK_H__D9749E47_3345_404F_B057_32E9FBF8EAC3__INCLUDED_)
