// ntougao.h: interface for the ntougao class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_NTOUGAO_H__8C8AC529_3003_49BD_AA88_631DD4B72DBA__INCLUDED_)
#define AFX_NTOUGAO_H__8C8AC529_3003_49BD_AA88_631DD4B72DBA__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#include <iostream.h>

class ntougao  
{
protected:
	int br_temena;
	float *duzina;
public:
	virtual float povrsina()=0;
	float obim();
	ntougao(int n);
	virtual ~ntougao();
	friend istream& operator>>( istream& in, ntougao& nt );

};

#endif // !defined(AFX_NTOUGAO_H__8C8AC529_3003_49BD_AA88_631DD4B72DBA__INCLUDED_)
