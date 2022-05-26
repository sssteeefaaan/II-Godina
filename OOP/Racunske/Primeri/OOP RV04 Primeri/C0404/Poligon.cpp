#include "Poligon.h"
#include <math.h>
#include <iostream>
using namespace std;
Poligon::Poligon()
{
    n=0;
	x=0;
	y=0;
	z = 0;
}

Poligon::Poligon(int x)
{
    zauzmi(x);
}

void Poligon::zauzmi(int dim)
{
	n=dim;
	this->x = new int[n];
	this->y = new int[n];
	this->z = new int[n];
}

Poligon::~Poligon()
{
    obrisi();
}

void Poligon::obrisi()
{
	delete [] x;
    delete [] y;
	delete [] z;
}

Poligon::Poligon(const Poligon& w)
{
    this->kopiraj(w);
}

Poligon& Poligon::operator=(const Poligon& v)
{
	if ( this != &v )
	{
		obrisi();
		kopiraj(v);
	}
	return *this;
}

Poligon& Poligon::operator+(const Poligon& v)
{
	Poligon* rezultat = new Poligon;		// !!!!!!!!!!!!!!!!!!!!!!!
	rezultat->zauzmi(this->n + v.n);
	rezultat->kopirajSegment(0, *this, 0, n);
	rezultat->kopirajSegment(n, v, 0, v.n);

	return *rezultat;
}

void Poligon::kopiraj(const Poligon& w)
{
	zauzmi(w.n);
	kopirajSegment(0, w, 0, n);
    
}

void Poligon::kopirajSegment(int startIndex, 
					const Poligon& w, 
					int wStartIndex, 
					int wKrajIndex)
{
	int brojac = startIndex;
	int index = wStartIndex;

	while(index < wKrajIndex
		&& brojac < this->n)
	{
        x[brojac]=w.x[index]; 
        y[brojac]=w.y[index];
		z[brojac] = w.z[index];
		brojac++;
		index++;
	}
}

void Poligon::obim()
{ 
	double s;
    s=0;
    s+=sqrt((double)(x[0]-x[n-1])*(x[0]-x[n-1])+(y[0]-y[n-1])*(y[0]-y[n-1]));
    for(int i=0; i<n-1; i++)
	{
        double segment = sqrt((double)(x[i+1]-x[i])*(x[i+1]-x[i])+(y[i+1]-y[i])*(y[i+1]-y[i]));
		cout << segment << endl;
		s+= segment;
	}
    cout<<s<<endl;
}
void Poligon::ucitaj()
{
	if (n > 0)
	{
		for(int i=0; i<n;i++)
			cin>>x[i]>>y[i]>>z[i];			
	}
}

void Poligon::prikazi()
{
	if (n > 0)
	{
		for(int i=0; i<n; i++)
			cout<<x[i]<< ", " <<y[i]<<", "<<z[i]<<endl;
	}
	cout << endl;
}