#include "Element.h"
#include "HashTable.h"
#include <fstream>
#include <iostream>
#include <string>
using namespace std;

void main()
{
	HashTable* Pasosi = new HashTable(80);	//8000
	string date, time, jmbg;
	ifstream input("Input.txt");
	if (input.good())
	{
		while (input.peek() != EOF)
		{
			getline(input, date);
			getline(input, time);
			getline(input, jmbg);
			Pasosi->insert(date, time, jmbg);
		}
	}
	
	Pasosi->print();
	Pasosi->infoFor("12. Mart 2020. godine", "11:30 h");
	Pasosi->infoFor("13. April 2020. godine", "08:10 h");
	input.close();

	return;
}