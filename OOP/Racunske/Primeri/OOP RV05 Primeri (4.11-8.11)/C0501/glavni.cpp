#include "Vektor.h"
#include <iostream>
#include <fstream>

using namespace std;

void main()
{
	Vektor a(5);
	
	ifstream uldat("polje.txt");

	if (uldat.good())
	{
		uldat >> a;
		uldat.close();
		cout << a;
	}

	ofstream izldat("polje2.txt");

	if (izldat.good())
	{
		izldat << a;
		izldat.close();		
	}

}
