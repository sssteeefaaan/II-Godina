#pragma once
#include "operacija.h"


class oduzimanje :
	public operacija
{
public:
	oduzimanje(char*, int);
	~oduzimanje();
	oduzimanje(int);

	virtual int DoOperation(int op1);
	virtual operacija* suprotna();
	
};

