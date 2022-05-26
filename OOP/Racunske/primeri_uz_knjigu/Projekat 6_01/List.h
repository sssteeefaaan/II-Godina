#include <iostream.h>

struct element
{
	int info;
	element* link;
};


class List
{
	element* tail;

public:
	List():tail(0){};
	push(int i);
	int pop();
	void write();

};