#include "List.h"
#include <iostream>
using namespace std;

void main()
{
	List<int>* A =new List<int>();
	A->AddFirst(56);
	A->AddLast(57);
	A->AddLast(58);
	A->AddLast(60);
	A->AddFirst(30);
	cout << "Lista A:" << endl;
	A->PrintAll();
	A->UpdateInfo(30, 80);
	cout << "Lista A:" << endl;
	A->PrintAll();
	A->UpdateInfo(80, 40);
	cout << "Lista A." << endl;
	A->PrintAll();
	A->UpdateInfo(58, 10);
	cout << "Lista A." << endl;
	A->PrintAll();
	delete A;
}