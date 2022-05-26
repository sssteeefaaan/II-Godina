#pragma once

#include <iostream>
using namespace std;

template <class T1, class T2>
class Element
{
	T1 index;
	T2 value;
public:
	Element() { index = T1(); value = T2(); };
	Element(T1 ind, T2 val) { index = ind; value = val; };
	virtual ~Element() {};

	T2 GetValue() { return value; };

	bool operator != (T1& ind) { return ind != index; };
	Element<T1, T2>& operator = (T2 val) { value = val; return *this;  };

	friend ostream& operator << (ostream& out, Element<T1, T2>& element) { out << element.index << " " << element.value;  return out; };

	bool operator > (Element<T1, T2>& element) { return index > element.index; };
	bool operator < (Element<T1, T2>& element) { return value < element.value; };
};

template <class T1, class T2>
class AssociatedArray
{
private:
	int count;
	int size;
	Element<T1, T2>* arElements;

public:
	//AssociatedArray();
	AssociatedArray(int sz);
	virtual ~AssociatedArray();

	void Set(T1 ind, T2 val);
	void Remove(T1 ind);

	void Print();

	T2 operator[] (T1 ind);

	void SortIndex();
	void SortValue();
};

template <class T1, class T2>
AssociatedArray<T1, T2>::AssociatedArray(int sz)
{
	size = sz;
	count = 0;
	arElements = new Element<T1, T2>[size];
}

template <class T1, class T2>
AssociatedArray<T1, T2>::~AssociatedArray()
{
	delete[] arElements;
}


template <class T1, class T2>
void AssociatedArray<T1, T2>::Set(T1 ind, T2 val)
{
	int i = 0;
	for (; i < count && arElements[i] != ind; i++);

	if (i < count)
	{
		arElements[i] = val;
	}
	else
	{
		if (count >= size)
		{
			throw exception("Prekoracenje!");
		}

		arElements[count] = Element<T1, T2>(ind, val);
		count++;
	}
}


template <class T1, class T2>
void AssociatedArray<T1, T2>::Remove(T1 ind)
{
	int i = 0;
	for (; i < count && arElements[i] != ind; i++);

	if (i == count)
	{
		throw exception("Trazeni element ne postoji!");
	}

	for (; i < count - 1; i++)
	{
		arElements[i] = arElements[i+1];
	}
	count--;
}


template <class T1, class T2>
void AssociatedArray<T1, T2>::Print()
{
	cout << endl << "Elementi clanovi niza su" << endl;
	for (int i = 0; i < count; i++)
	{
		cout << arElements[i] << endl;
	}
	cout << endl;
}


template <class T1, class T2>
T2 AssociatedArray<T1, T2>::operator[](T1 ind)
{
	int i = 0;
	for (; i < count && arElements[i] != ind; i++);

	if (i == count)
	{
		throw exception("Trazeni element ne postoji!");
	}

	return arElements[i].GetValue();
}

template <class T1, class T2>
void AssociatedArray<T1, T2>::SortIndex()
{
	for (int i = 0; i < count - 1; i++)
	{
		int imin = i;
		for (int j = i+1; j < count; j++)
		{
			if (arElements[imin] > arElements[j])
			{
				imin = j;
			}
		}
		if (i != imin)
		{
			Element<T1, T2> tmp = arElements[i];
			arElements[i] = arElements[imin];
			arElements[imin] = tmp;
		}
	}
}

template <class T1, class T2>
void AssociatedArray<T1, T2>::SortValue()
{
	for (int i = 0; i < count - 1; i++)
	{
		int imin = i;
		for (int j = i+1; j < count; j++)
		{
			if (arElements[j] < arElements[imin])
			{
				imin = j;
			}
		}
		if (i != imin)
		{
			Element<T1, T2> tmp = arElements[i];
			arElements[i] = arElements[imin];
			arElements[imin] = tmp;
		}
	}
}

