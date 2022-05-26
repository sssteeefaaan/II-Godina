#pragma once
class Base
{
	char* name;
public:
	Base()
	{
		name = 0;
	}

	Base(int n);
	virtual ~Base(); //virtual

	virtual void NameOf();  // Virtual
    void InvokingClass();   // Nonvirtual
};


