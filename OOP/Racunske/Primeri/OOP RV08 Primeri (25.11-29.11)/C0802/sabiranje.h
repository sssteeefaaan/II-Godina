#pragma once
#include "operacija.h"
#include "oduzimanje.h"
class sabiranje : public operacija
{
public:
	sabiranje(char*, int);
	~sabiranje();
	sabiranje(int);

	virtual int DoOperation(int op1)
	{
		return this->drugioperand + op1;
	}

	virtual operacija* suprotna()
	{
		return new oduzimanje(this->drugioperand);
	}
};