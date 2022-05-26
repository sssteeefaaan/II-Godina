#include <iostream.h>

template <class T>
T max(T i, T j)
{
	return i>j ? i : j;
}

void main()
{

	// za slucaj celih brojeva navodimo kao argumente cele brojeve
	cout << "Maksimalni broj je: " << max (5, 8) << endl;

	// za slucaj realnih brojeva navodimo kao argumente realne brojeve
	cout << "Maksimalni broj je: " << max (3.324, 2.454) << endl;


}
