// trougao.h: interface for the trougao class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_TROUGAO_H__D2F01F77_8A61_4113_9412_3ECFB944E9FE__INCLUDED_)
#define AFX_TROUGAO_H__D2F01F77_8A61_4113_9412_3ECFB944E9FE__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#include "ntougao.h"

class trougao : public ntougao  
{
public:
	trougao();
	virtual ~trougao();
	float povrsina();

};

#endif // !defined(AFX_TROUGAO_H__D2F01F77_8A61_4113_9412_3ECFB944E9FE__INCLUDED_)
