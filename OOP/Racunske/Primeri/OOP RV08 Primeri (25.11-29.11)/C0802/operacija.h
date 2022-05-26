#pragma once

class operacija 
{ 
protected:
	char* naziv;
	int drugioperand;
public:
	operacija(char *, int);
	virtual ~operacija();
	virtual operacija* suprotna() = 0;
	int vroperand();
	void stampa();	
	virtual int DoOperation(int op1)=0;
};	