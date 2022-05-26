#pragma once
#include <iostream>
using namespace std;

class RacionalanBroj  
{
private:
	int brojilac;
	int imenilac; 
public:
	bool operator<( const RacionalanBroj& r );
	friend istream& operator>>( istream& ulaz, RacionalanBroj& r);
	friend ostream& operator<<( ostream& izlaz, const RacionalanBroj& r);
	
};

