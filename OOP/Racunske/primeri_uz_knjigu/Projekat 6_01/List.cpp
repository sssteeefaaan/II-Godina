#include "List.h"

List::push(int i)
{
	element* tmp = new element;
	tmp->info = i;
	tmp->link = tail;
	tail = tmp;
};

int List::pop()
{

	int value;
	element *tmp = tail;
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
