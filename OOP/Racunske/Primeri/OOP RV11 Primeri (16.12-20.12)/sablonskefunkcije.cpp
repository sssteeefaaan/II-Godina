#include <iostream>
using namespace std;

template <class Type>
Type min2 (Type a, Type b)
{
	return a < b ? a : b;
}

template <class Test>
Test max2 (Test a, Test b)
{
	return a > b ? a : b;
}

template <class Glorp, int size>
Glorp min(const Glorp (&r_array)[size])
{
/* Parametrizovana funkcija za pronalaženje minimalne vrednosti u nizu */

Glorp minival = r_array[0];
for(int i = 1; i < size; i++)
{
	if(r_array[i] < minival)
			minival = r_array[i];
}

return minival;
}

template <class Type, class T2, class T3>
void print (Type s, T2 a, T3 b)
{
	cout << s << endl << a << endl << b;
}

template <class Test>
Test max3 (Test a, Test b)
{
	return a > b ? a : b;
}


int main()
{
	// ok: min(int, int)
	cout << min2(10, 20) << endl;
	
	// ok: min(double, double)
	cout << min2(10.0, 20.0) << endl;

	cout << max2('s', 'd') << endl;

	cout << max2(true, false) << endl;

	print (23, 12.88, false);

	print (23, 23, 23);

	return 0;
}
