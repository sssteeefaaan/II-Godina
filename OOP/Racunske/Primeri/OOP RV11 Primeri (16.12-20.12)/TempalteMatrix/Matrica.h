#include <iostream>
#include <string.h>
#include "Str.h"
using namespace std;


template <class Pod>
class MATRICA
{
	Pod **mat;
	int n,m;
public:
	MATRICA()
	{
		n = m = 0;
		mat = 0;		
	}
	MATRICA(int n1,int m1);
	~MATRICA();
	Pod& operator()(int i,int j);
	int Uzmi_n(){return n};
	int Uzmi_m(){return m};
	int P(MATRICA<Pod>& mat1); 
	void Unos();
	void Stampanje();
};

template <class Pod>
MATRICA<Pod>::MATRICA(int n1, int m1)
{
	int j;
	n=n1;
	m=m1;
	mat=new Pod*[n];
	for(j=0;j<n;j++)
		mat[j]=new Pod[m];
}

template <class Pod>
MATRICA<Pod>::~MATRICA()
{
	if (mat != 0)
	{
		int j;
		for(j=0;j<n;j++)
			delete [] mat[j];
		delete [] mat;
	}
}

template <class Pod>
Pod& MATRICA<Pod>::operator()(int i, int j)
{
	return mat[i][j];
}

template <class Pod>
int MATRICA<Pod>::P(MATRICA<Pod>& mat1)
{
	int u1,u2,i1,j1,i2,j2;
	u1=0; //u1 - uslov da je matrica mat1 podmatrica tekuce matrice
	if (mat1.n<=n && mat1.m<=m)
	{
		i1=0;
		while (i1<=n-mat1.n && !u1)
		{
			j1=0;
			while (j1<=m-mat1.m && !u1)
			{
				i2=0;
				u2=1; //u2 - uslov da ima slaganja u poredjenju mat1 i dela tekuce matrice
				while (i2<mat1.n && u2)
				{
					j2=0;
					while (j2<mat1.m && u2)
					{
						if (!(mat[i1+i2][j1+j2]==mat1.mat[i2][j2]))
							u2=0;
						j2++;
					}
					i2++;
					if (u2) 
						u1=1;
				}
				j1++;
			}
			i1++;
		}
	}
	return u1;
}


template <class Pod>
void MATRICA<Pod>::Unos()
{
	int j,k;
	cout<<"Unesi elemente matrice\n";
	for(j=0;j<n;j++)
		for(k=0;k<m;k++)
			cin>>mat[j][k];
	return;
}

template <class Pod>
void MATRICA<Pod>::Stampanje()
{
	int j,k;
	for(j=0;j<n;j++)
	{
		for(k=0;k<m;k++)
			cout<<mat[j][k]<<" ";
		cout<<"\n";
	}
	return;
}

