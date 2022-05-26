// Animal.h: interface for the Animal class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_ANIMAL_H__4EB6F9EA_2481_4C11_9E40_483255F2A03F__INCLUDED_)
#define AFX_ANIMAL_H__4EB6F9EA_2481_4C11_9E40_483255F2A03F__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#include <iostream.h>

class Animal  
{
public:
	Animal(int wt);
	Animal();
	virtual ~Animal();

	int GetWeight() const;
	void SetWeight(int wt);
	void Display();

	friend ostream& operator << (ostream& izlaz, const Animal& an);

private:
	int itsWeight;

};

#endif // !defined(AFX_ANIMAL_H__4EB6F9EA_2481_4C11_9E40_483255F2A03F__INCLUDED_)
