#include "List.h"
using namespace std;

void List::push(int i)
{
	element* tmp = new element;
	tmp->info = i;
	tmp->link = tail;
	tail = tmp;
};

int List::pop()
{

	int value = 12;
	element *tmp = tail;
	if (tail == 0)
		//value /= 0;
		throw 123;
		//throw "Empty";
		//throw new std::exception("test ex");
	tail = tail->link;
	value = tmp->info;
	delete tmp;
	return value;
}

void List::write()
{
	element* tmp = tail;
	while (tmp)
	{
		cout << "Element: " << tmp->info <<endl;
		tmp = tmp->link;
	}
}
