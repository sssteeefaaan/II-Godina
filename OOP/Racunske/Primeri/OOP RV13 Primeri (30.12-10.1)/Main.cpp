#include "AssociatedArray.h"
#include "Complex.h"
#include <iostream>
using namespace std;

int main()
{
	try
	{
		AssociatedArray<int, double> a1(5);
		a1.Set(2, 4.5);
		a1.Set(1, 12.33);
		a1.Set(4, 13.25);

		a1.Print();

		cout << a1[2] << endl;

		a1.SortIndex();
		a1.Print();

		a1.Set(2, 7.7);
		a1.Set(3, 1.1);

		a1.SortValue();
		a1.Print();

		a1.SortIndex();
		a1.Print();

		a1.Set(-1, 44);
		//a1.Set(-9, 22);
		a1.Remove(3);
		a1.Set(2, 4.1);
		a1.Set(3, 8);
		//a1.Set(5, 11);

		a1.Print();

	}
	catch (exception& exc)
	{
		cout << exc.what() << endl;
	}


	try
	{
		Complex<int> arComplex[8] = { { 4, 5 }, { 1, 2 }, { 2, 4 }, { 7, 7 }, { 1, 1 }, { 4, 4 }, { 4, 1 }, { 8, 0 } };

		AssociatedArray<int, Complex<int> > a2(5);
		a2.Set(2, arComplex[0]);
		a2.Set(1, arComplex[1]);
		a2.Set(4, arComplex[2]);

		a2.Print();

		cout << a2[2] << endl;

		a2.SortIndex();
		a2.Print();

		a2.Set(2, arComplex[3]);
		a2.Set(3, arComplex[4]);

		a2.SortValue();
		a2.Print();

		a2.SortIndex();
		a2.Print();

		a2.Set(-1, arComplex[5]);
		a2.Remove(3);
		a2.Set(2, arComplex[6]);
		a2.Set(3, arComplex[7]);

		a2.Print();

	}
	catch (exception& exc)
	{
		cout << exc.what() << endl;
	}

	return 0;
}