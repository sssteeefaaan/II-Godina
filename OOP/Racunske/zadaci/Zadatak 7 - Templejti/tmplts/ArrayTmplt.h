// ArrayTmplt.h: interface for the ArrayTmplt class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_ARRAYTMPLT_H__EC85BCE4_8332_4019_8D96_886ABEC6EA23__INCLUDED_)
#define AFX_ARRAYTMPLT_H__EC85BCE4_8332_4019_8D96_886ABEC6EA23__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
#include <iostream.h>

template <class T>
class ArrayTmplt  
{
public:
	// konstruktori
	ArrayTmplt()
	{
		itsSize = 10;
		pType = new T[itsSize];
		for(int i = 0; i < itsSize; i++)
		{
			pType[i] = 0;
		};
	}
	ArrayTmplt(int sz);
	ArrayTmplt(const ArrayTmplt &rhs)
	{
		itsSize = rhs.GetSize();
	
		pType = new T[itsSize];
		for(int i = 0; i < itsSize; i++)
		{
			pType[i] = rhs[i];
		}
	}
	// destruktor
	virtual ~ArrayTmplt(){delete[] pType;};

	// operatori
	ArrayTmplt& operator=( const ArrayTmplt& rhs);

	T& operator[](int offset) 
	{
		return pType[offset];
	}

	const T& operator[](int offset) const
	{
		return pType[offset];
	}

	// metoda za pristup promenljivoj itsSize
	int GetSize() const
	{
		return itsSize;
	}

	// prijateljska funkcija
	friend void Intrude(ArrayTmplt<T> arr);

	// prijateljski operator
	friend ostream& operator<< (ostream& izlaz, ArrayTmplt<T>& arr);

private:
	T* pType;
	int itsSize;	


};

template <class T>
ArrayTmplt<T>::ArrayTmplt(int sz)
{
	itsSize = sz;
	pType = new T[itsSize];
	for(int i = 0; i < itsSize; i++)
	{
		pType[i] = 0;
	}
}


template <class T>
ArrayTmplt<T>& ArrayTmplt<T>::operator =(const ArrayTmplt &rhs)
{
	if (this == rhs)
		return *this;

	delete[] pType;
	itsSize = rhs.GetSize();
	pType = new T[itsSize];
	for(int i = 0; i < itsSize; i++)
	{
		pType[i] = rhs[i];
	}

	return *this;

}

void Intrude(ArrayTmplt<int> arr)
{
	for(int i = 0; i < arr.itsSize; i++)
	{
		cout << arr[i] << "\t";
	}
	cout << endl;
}

template <class T>
ostream& operator << (ostream& izlaz, ArrayTmplt<T>& arr)
{
	for (int i = 0; i < arr.GetSize(); i++)
	{
		izlaz << "[" << i << "]" << arr[i] << endl;
	}
	return izlaz;
}


#endif // !defined(AFX_ARRAYTMPLT_H__EC85BCE4_8332_4019_8D96_886ABEC6EA23__INCLUDED_)
