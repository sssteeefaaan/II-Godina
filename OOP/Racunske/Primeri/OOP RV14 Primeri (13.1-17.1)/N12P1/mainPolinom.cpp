//Napraviti šablonsku klasu Polinom koja kao koeficijente može imati različite tipove.Polinom može biti proizvoljnog stepena.Od javnih funkcija klasa sadrži :
//•	konstruktor koji sve koeficijente postavlja na 0
//•	funkciju koja postavlja koeficijent uz navedeni stepen(*)
//•	funkciju koja sabira dva polinoma(*)
//•	prijateljsku operatorsku funkciju << koja štampa polinom
//•	prijateljsku operatorsku funkciju >> koja učitava polinom(*)
//•	funkciju koja upisuje polinom u fajl
//•	funkciju koja učitava polinom iz fajla(*)
//Napraviti klasu NegativanCeoBroj koja treba da omogući unos samo negativnih celih brojeva.Sadrži atribut koji pamti taj broj, a od funkcija :
//•	podrazumevani konstruktor koji postavlja broj na - 1
//•	konstruktor koji kao parameter ima ceo broj(*)
//•	konstruktor koji za dati realan broj izvrši konverziju i upamti negativan ceo broj
//•	operator dodele koji dodeljuje vrednost realnog broja na isti način kao i prethodno definisani konstruktor
//•	prijateljsku operatorsku funkciju << koja štampa broj
//
//U glavnom program testirati sve funkcije klase Polinom za tipove podataka double i NegativanCeoBroj.
//
//U funkcijama označenim sa(*) predvideti obradu izuzetaka.
//
//


#include"Negativan.h"

void main(void)
{
	try
	{
		NegativanCeoBroj ncb2(12);
		NegativanCeoBroj ncb((float)-0.7);
		float* f = new float[2]; // 3.5);
		f[0] = 3.5;
		f[1] = 3.9;
		double* t = (double*)f;
		cout << *t;
		Polinom<double> x(3);
		Polinom<int> x2(12);
		x.Postavi(1,4.3);
		x.Upisi("Text.txt");
		Polinom<double> y(3);
		y.Procitaj("Text.txt");
	}
	catch (Izuzetak& x)
	{
		cout<<x;
	}
	try
	{
		Polinom<NegativanCeoBroj> x(3);
		cin >> x;
		x.Postavi(5,-10);
		x.Upisi("Text.txt");
		Polinom<NegativanCeoBroj> y(3);
		y.Procitaj("Text.txt");
	}
	catch (Izuzetak& x)
	{
		cout<<x;
	}
}
