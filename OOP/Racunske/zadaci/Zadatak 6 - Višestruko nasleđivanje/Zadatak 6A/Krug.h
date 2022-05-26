// Krug.h: interface for the Krug class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_KRUG_H__BB2B47BF_7057_4A6A_8C80_C77BAD1DE135__INCLUDED_)
#define AFX_KRUG_H__BB2B47BF_7057_4A6A_8C80_C77BAD1DE135__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

class Krug  
{
protected:
	float r;
public:
	float povrsina();
	float obim();
	Krug(float pp);
	virtual ~Krug();

};

#endif // !defined(AFX_KRUG_H__BB2B47BF_7057_4A6A_8C80_C77BAD1DE135__INCLUDED_)
