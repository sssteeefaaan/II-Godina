#pragma once
#include <iostream>
using namespace std;

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
	void push(int i);
	int pop();
	void write();
	
};
