#include "Base.h"
#include <iostream>
using namespace std;

void Base::NameOf()
{
    cout << "Base::NameOf\n";
}

void Base::InvokingClass()
{
    cout << "Invoked by Base\n";
}

Base::Base(int n)
{
	name = new char[n];
}

Base::~Base()
{
	if (name != 0)
		delete [] name;
}

