#pragma once

template<class T, int m, int n>
class TemplateMatrix
{
	T** a;
public:

	TemplateMatrix(void)
	{
		a = new T*[m];

		for (int i = 0; i < n; i++)
		{
			a[i] = new T[n];			
		}

		
	}

	virtual ~TemplateMatrix(void)
	{	

		for (int i = 0; i < n; i++)
		{
			delete[] a[i];
		}

		delete[] a;
	}

	virtual T GetElement(int x, int y)
	{
		
		return a[x][y];
		
	}

	virtual void SetElement(int x, int y, T el)
	{
		
			a[x][y] = el;
		
	}

	
};


