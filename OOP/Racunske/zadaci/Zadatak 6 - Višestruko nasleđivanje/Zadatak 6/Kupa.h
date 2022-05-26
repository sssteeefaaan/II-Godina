// Kupa.h: interface for the Kupa class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_KUPA_H__EBD64BD9_5CCD_44BD_9487_A3DFA54A2C85__INCLUDED_)
#define AFX_KUPA_H__EBD64BD9_5CCD_44BD_9487_A3DFA54A2C85__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#include "Krug.h"

class Kupa : public Krug  
{
protected:
	float H;
public:
	virtual float zapremina();
	virtual float povrsina();
	Kupa(float pp, float visina);
	virtual ~Kupa();

};

#endif // !defined(AFX_KUPA_H__EBD64BD9_5CCD_44BD_9487_A3DFA54A2C85__INCLUDED_)
