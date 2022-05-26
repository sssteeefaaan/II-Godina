#include "Animal.h"
#include "ArrayTmplt.h"

int main()
{
	ArrayTmplt<int> intArray; 
	ArrayTmplt<Animal> zoo;
	Animal* pAnimal;

	for (int i = 0; i < intArray.GetSize(); i++)
	{
		intArray[i] = i*2;

		pAnimal = new Animal(i*3);
		zoo[i] = *pAnimal;
		delete pAnimal;
	}

	for (i = 0; i < intArray.GetSize(); i++)
	{
		cout << "intArray[" << i << "]:\t";
		cout << intArray[i] << "\t\t";
		cout << "zoo[" << i << "]:\t";
		zoo[i].Display();
		cout << endl;
	}

	Intrude(intArray);

	cout << zoo[3];
	cout << "zoo:" << zoo << endl;
	return 0;
}