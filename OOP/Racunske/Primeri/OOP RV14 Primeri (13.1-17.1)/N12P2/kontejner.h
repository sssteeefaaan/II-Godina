#include <iostream>
using namespace std;
#include <fstream>

template<class T>
class kontejner
{
	int duzina;
	T* niz;
	T pom;
	public:
		kontejner();
		~kontejner();

		void postavi(int i,T& x);
		void stampajVisak(float n);

		friend istream& operator>> <>(istream& in, kontejner<T>& n);
		friend ostream& operator<< <>(ostream& out, kontejner<T>& n);

		void upisiUTxt(char* naziv);
		void citajIzTxt(char* naziv);

		int getDuzina() {return duzina;};
		T& getNiz(int i) {return niz[i];};

};

template<class T>
kontejner<T>::~kontejner()
{
	if(duzina>0)
		delete[] niz;
}
template<class T>
kontejner<T>::kontejner()
{
	duzina=0;
	niz=0;
}

template<class T>
void kontejner<T>::postavi(int i, T& x)
{
	if(i<0 || i>=duzina-1)
		throw "Prekoracenje!";
	else
		niz[i]=x;
}

template<class T>
void kontejner<T>::stampajVisak(float n)
{
	int k;
	k=0;
	cout<<"Visak imaju:"<<endl;
	for(int i=0;i<duzina;i++)
		if(niz[i]>n)
		{
			k++;
			cout<<niz[i]<<endl;
		}
	if(k==0)
		cout<<" Nijedan clan nema vise od navedene vrednosti"<<endl;
	
}

template<class T>
istream& operator>>(istream& in, kontejner<T>& n)
{
	in>>n.duzina;
	if(n.duzina<0)
		throw "Uneta duzina manja od 0";

	n.niz=new T[n.duzina];	
	for(int i=0;i<n.duzina;i++)
		in>>n.niz[i];
	return in;
}

template<class T>
ostream& operator<<(ostream& out, kontejner<T>& n)
{	
	out<<endl<<"Imate kontejner od:"<<n.duzina<<" clanova."<<endl;
	
	for(int i=0;i<n.duzina;i++)
		out<<n.niz[i]<<" ";
	out<<endl;
	
	return out;

}


template<class T>
void kontejner<T>::upisiUTxt(char* naziv)
{
	ofstream izlaz(naziv);
	izlaz<<duzina<<endl;

	for(int i=0;i<duzina;i++)
		izlaz<<niz[i]<<" ";
	izlaz.close();
}

template<class T>
void kontejner<T>::citajIzTxt(char* naziv)
{
	ifstream ulaz(naziv);
	if(!ulaz.is_open())
		throw "Greska pri otvaranju TXT datoteke";

	if(duzina>0)
		delete[] niz;
	ulaz>>duzina;

	niz=new T[duzina];
	for(int i=0;i<duzina;i++)
	{
		ulaz>>niz[i];
		if(!ulaz.good())
			throw "Greska pri citanju elementa";
	}
	ulaz.close();



}