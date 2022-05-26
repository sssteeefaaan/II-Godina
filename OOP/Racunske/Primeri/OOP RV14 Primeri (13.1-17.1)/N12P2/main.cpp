//Napraviti šablonsku klasu ContainerRow koja kao elemente može imati različite tipove.ContainerRow može biti proizvoljne dužine.Od javnih funkcija klasa sadrži :
//•	konstruktor koji sve elemente  postavlja na 0
//•	funkciju koja postavlja određeni element na određenu vrednost(*)
//•	funkciju koja vraća ukupnu količinu materijala u ContainerRow objektu(*)
//•	prijateljsku operatorsku funkciju << koja štampa ContainerRow
//•	prijateljsku operatorsku funkciju >> koja učitava ContainerRow(*)
//•	funkciju koja upisuje ContainerRow u fajl
//•	funkciju koja učitava ContainerRow iz fajla(*)
//Napraviti klasu Package koja treba da modeluje kutiju koja sadrži naziv i količinu materijala koja može da ima vrednosti pozitivne vrednosti ili 0. Od funkcija, pomenuta klasa sadrži :
//•	podrazumevani konstruktor koji postavlja naziv materijala na prazan string i količinu na 0
//•	konstruktor koji postavlja naziv i količinu materijala u paketu(*)
//•	operator dodele koji dodeljuje vrednost realnog broja objektu tipa Package(*)
//•	prijateljsku operatorsku funkciju << koja štampa broj
//
//U glavnom program testirati sve funkcije klase ContainerRow za tipove podataka double i Package.
//
//U funkcijama označenim sa(*) predvideti obradu izuzetaka.
//

#include "package.h"
#include "kontejner.h"
#include <iostream>
using namespace std;
#include <fstream>

void main()
{
	try
	{

	kontejner<int> obj;
	cout<<"Unesi broj elemenata, i elemente redom za int tip"<<endl;
	cin>>obj;
	cout<<obj;

	cout<<"Unesi poziciju:"<<endl;
	int x;
	cin>>x;
	cout<<"Unesi vrednost za tu poziciju:"<<endl;
	int k;
	cin>>k;
	obj.postavi(x,k);

	cout<<obj;

	obj.stampajVisak(20);

	obj.upisiUTxt("proba.txt");

	kontejner<int> obj2;
	obj2.citajIzTxt("proba.txt");
	cout<<"Objekat2 ucitan iz TXT"<<endl<<obj2;
	

	cout<<"Kreiranje kolekcije package-a"<<endl;
	kontejner<package> o1;
	cout<<"Unesi broj elemenata kolekcije, zatim Ime i vrednost za svaki package"<<endl;
	cin>>o1;
	cout<<o1;
	
	
	cout<<"Unesi poziciju:"<<endl;
		// x;
	cin>>x;
	
	cout<<"Unesi vrednost za tu poziciju:"<<endl;
	package a;
	cin>>a;
	o1.postavi(x,a);
	

	cout<<o1;
	
	
	o1.stampajVisak(20);

	o1.upisiUTxt("proba1.txt");

	kontejner<package> o2;
	o2.citajIzTxt("proba1.txt");
	cout<<"Kolekcija o2, ucitana iz TXT"<<endl;
	cout<<o2;
	
	kontejner<package> o3;
	o3.citajIzTxt("proba1.txt");
	cout << "Kolekcija o2, ucitana iz TXT" << endl;
	cout << o3;
	}
	catch(char* izuzetak)
	{
		cout<<"Doslo je do prekida programa:"<<izuzetak;
	}
	catch (...)
	{

	}
	
}