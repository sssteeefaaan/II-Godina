#include "Element.h"
#include "HashTable.h"
#include <fstream>
#include <iostream>
#include <string>
using namespace std;

void main()
{
	HashTable* Applications2020 = new HashTable(80);	//8000
	string date, time, jmbg;
	ifstream input("Input.txt");

	if (input.good())
	{
		do
		{
			try {
				getline(input, date);
				getline(input, time);
				getline(input, jmbg);
				Applications2020->insert(date, time, jmbg);
			}
			catch (exception* e) {
				cout << "Exception occured: " << e->what() << endl;		//Jos uvek nisam usavrsio(naucio) exceptions, nemojte mnogo da zamerite.
			}															//Trebalo bi da sa "Table is full!" odmah izadje is while petlje.
		} while (input.peek() != EOF);
	}

	Applications2020->print();
	try {
		Applications2020->infoFor("15. Januar 2020. godine", "17:30 h");
		Applications2020->infoFor("20. Septembar 2020. godine", "13:40 h");
		Applications2020->infoFor("13. April 2020. godine", "08:10 h");
	}
	catch (exception* e)
	{
		cout << "Exception occured: " << e->what() << endl;
	}
	input.close();

	delete Applications2020;
}