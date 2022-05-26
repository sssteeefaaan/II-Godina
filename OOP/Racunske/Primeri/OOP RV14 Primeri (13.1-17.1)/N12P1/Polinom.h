#pragma once
#include<iostream>
#include<fstream>
using namespace std;
#include"Izuzetak.h"

template <class Tip>
class Polinom
{
	Tip *Kf;
	int stepen;
public:
	Polinom(int x)
	{
		stepen=x;

		Kf=new Tip [stepen+1];
		
		for (int i=0;i<stepen+1;i++)
			Kf[i]=0;

	}

	void Postavi(int x,Tip p)
	{
		if (x<0 || x>stepen)
			throw Stepennepostoji();
		Kf[x]=p;
	}

	void Saberi(Polinom &x)
	{
		if (this->stepen>=x.stepen)
			for (int i=0;i<x.stepen+1;i++)
				this->Kf[i]=this->Kf[i]+x.Kf[i];
		else
		{
			for (int i=0;i<this->stepen+1;i++)
				this->Kf[i]=this->Kf[i]+x.Kf[i];
			for (i=this->stepen+1;i<x.stepen+1;i++)
				this->Kf[i]=x.Kf[i];
		}
		
	}
	friend ostream& operator<< (ostream& izlaz, Polinom<Tip> &x)
	{
		for (int i=0;i<x.stepen+1;i++)
			izlaz<<x.Kf[i]<<"x^"<<i<<"+";
		return izlaz;
	}
	friend istream& operator>>(istream& ulaz,Polinom<Tip> &x)
	{
		ulaz>>x.stepen;
		if(x.stepen<0)
			throw NegStepen();
		for (int i = 0; i < x.stepen + 1; i++)
		{
			bool nijeuspeo = true;
			while (nijeuspeo)
			{
				try
				{
					ulaz >> x.Kf[i];
					nijeuspeo = false;
				}
				catch (...)
				{
					cout << "!!!!";
				}
			}
		}
		return ulaz;
	}
	void Upisi(char* Dat)
	{
		ofstream f(Dat);
		if (!f.good())
			throw NeispravnoOtvaranje();
		f<<this->stepen<<" ";

		for (int i = 0; i < this->stepen + 1; i++)
		{
			f << this->Kf[i] << " ";
		}

		f.close();
	}
	void Procitaj(char* Dat)
	{
		ifstream f(Dat);
		if (!f.good())
			throw NeispravnoOtvaranje();
		f>>this->stepen;
		for(int i=0;i<this->stepen+1;i++)
			f>>this->Kf[i];
		f.close();
	}
};

