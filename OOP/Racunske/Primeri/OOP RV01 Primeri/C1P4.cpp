/*POINTER

    Its not necessary to initialize the pointer at the time of declaration. Like
    Code:

       
    int a = 10;
    int *P = &a; //It is not necessary

    Another way is :
    Code:

    int a  = 10;
    int *P;
    P =  &a;

    You can create the array of Pointer.
    You can assign NULL to the pointer like

    Code:

    int *P = NULL; //Valid

    You can use pointer to pointer.

REFERENCE

    Its necessary to initialize the Reference at the time of declaration. Like
    Code:

    int &a = 10;
    int &a;   //Error here but not in case of Pointer.

    You can not create the Array of reference.
    You can not assign NULL to the reference like

    Code:

    int &a = NULL; //Error

    You can not use reference to reference.
	
	*/
	
	#include <math.h>
#include <iostream>
using namespace std;

int main()
{
	int ival = 1024;
	cout << ival << endl;
	int ival2 = ival + 1;
	cout << ival2 << endl;

	int *pint;
	pint = &ival;

	*pint = *pint +1;
	cout << ival << endl;

	int *pint2 = new int(10);
	int *pia = new int[10];

	int **ppi = &pint2;
	int *pi2 = *ppi;

	int ia[10];

	int* pocetak = &ia[0];
	int* kraj = &ia[10];

	while (pocetak != kraj)
	{
		*pocetak = (**ppi)--;
		pocetak++;
	}

	cout << **ppi << endl;
	cout << *pi2 << endl;

	delete pint2;
	delete[] pia;

	int& refVal = ival;
	cout << refVal << endl;

	int *pi = &ival;
	int *&ptrVal2 = pi;

	cout << *ptrVal2 << endl;
}
