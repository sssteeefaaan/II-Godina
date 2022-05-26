#include "Objekat.h"
#include "Tabla.h"
#include <iostream>
using namespace std;

Tabla::Tabla(int n)
{
	this->n = n;
	m = new Objekat**[n];
	for (int i = 0; i < n; i++)
	{
		m[i] = new Objekat*[n];

		for (int j = 0; j < n; j++)
			m[i][j] = 0;
	}
}

void Tabla::PromeniSusedima(int x, int i, int j)
{
	for (int k=i-1;k<i+2;k++ )
		for (int l=j-1; l<j+2; l++)
			
			if (DaLiPripadaTabli(k,l) && !(k==i && l==j))
			{
				if (m[k][l] != 0)
				m[k][l]->Promeni(x);
			}
}

void Tabla::PromeniIstim(int x, char c)
{
	for (int i = 0; i < n; i++)
		for (int j = 0; j < n; j++)
			if (m[i][j] != 0) {
				if (m[i][j]->Karakter() == c)
				{
					m[i][j]->Promeni(x);
				}
			}
}

void Tabla::Brisi(int i, int j)
{
	delete m[i][j];
	m[i][j] = 0;
}

void Tabla::Postavi(int i, int j, Objekat* novi)
{
	if (!DaLiPripadaTabli(i, j))
		return;

	if (this->m[i][j] != 0)
		delete this->m[i][j];

	this->m[i][j] = novi;
}

void Tabla::Ispisi()
{
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
			if (m[i][j] != 0) 
			{
				cout << m[i][j]->Karakter() << ' ';
			}
			else
				cout << ' ' << ' ';
		cout << endl;
	}
	cout << endl;

	IspisiIVrednosti();

}

void Tabla::IspisiIVrednosti()
{
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
			if (m[i][j] != 0)
			{
				cout << m[i][j]->Karakter() << ' ' << m[i][j]->Energy() << ' ';
			}
			else
				cout << ' ' << ' ';
		cout << endl;
	}
	cout << endl;

}


void Tabla::SviDobro()
{
	for (int i = 0; i < n; i++)
		for (int j = 0; j < n; j++)
		{
			if (m[i][j]!=0)
			m[i][j]->Dobro();
		}
}

void Tabla::JedanDobro(int i, int j)
{
	if (!DaLiPripadaTabli(i, j))
		return;

	m[i][j]->Dobro();
}

void Tabla::JedanZlo(int i, int j)
{
	if (!DaLiPripadaTabli(i, j))
		return;

	m[i][j]->Zlo();
}

void Tabla::SviZlo()
{
	for (int i = 0; i < n; i++)
		for (int j = 0; j < n; j++)
		{
			if (m[i][j]!=0)
			m[i][j]->Zlo();
		}
}

Tabla::~Tabla()
{
	for (int i = 0; i < n; i++)
		for (int j = 0; j < n; j++)
		{
			delete m[i][j];
		}

	for (int i = 0; i < n; i++)
		delete[] m[i];
	delete[] m;
}
