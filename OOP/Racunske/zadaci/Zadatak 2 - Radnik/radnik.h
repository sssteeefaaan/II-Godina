#pragma once
#include <iostream>
using namespace std; 
#include <string>

class Radnik
{
private:
	char ime[30];
	char prezime[30];
	double kss;

public:
	static int br_radnika;
	static double cena_rada;
	static double cena_prevoza;

	static double prevoz();

	void input();
	void output();
};
