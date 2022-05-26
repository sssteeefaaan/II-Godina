#include "kalkulator.h"
#include "operacija.h"
#include "sabiranje.h"
#include "oduzimanje.h"
#include <iostream>
using namespace std;

void main()
{
	kalkulator c1("test", 4);
	c1.Do(*(new sabiranje(3)));
	c1.Undo();

	cout << " s - sabiranje, o - oduzimanje, u - undo, x - kraj" << endl;
	while(true)
	{
		char c;
		cin >> c;

		if (c == 'x')
			exit(0);

		if (c != 'o' && c != 's' && c != 'u')
		{
			c1.Print();
			continue;
		}

		if (c == 'u')
			c1.Undo();
		else
		{
			int t;
			cin >> t;

			operacija* nova;
			if (c == 'o')
				nova = new oduzimanje(t);
			else
				nova = new sabiranje(t);

			c1.Do(*nova);
		}
		
		
	}

}
