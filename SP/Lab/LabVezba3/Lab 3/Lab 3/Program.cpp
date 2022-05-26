#include "minHeap.h"
#include "binaryTree.h"

void main()
{
	try {
		//	1. Zadatak
		int numberOfLevels = 5;			//	Broj nivoa gomile
		minHeap::test(numberOfLevels);

		//	2. Zadatak
		long numberOfElements = 31;		//	Elementi ce biti upisani od 1 do numberOfElements
		int elementOne = 25;			//	Prvi i drugi element koji zelite da se trazi u stablu
		int elementTwo = 99;
		binaryTree::test(numberOfElements, elementOne, elementTwo);
	}
	catch (DSException* e)
	{
		std::cout << "Data structure error occured : " << e->what() << std::endl;
	}
	catch (std::exception& e)
	{
		std::cout << "Error occured :" << e.what() << std::endl;
	}
}