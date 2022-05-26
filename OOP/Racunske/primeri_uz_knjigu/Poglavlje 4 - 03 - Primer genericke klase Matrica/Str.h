#include <iostream.h>
#include <string.h>

class STR{
	char* s;
public:
	STR(){ s=new char[2];};
	STR(int i);
	~STR();
	friend istream& operator>>(istream& t,STR& s1);
	friend ostream& operator<<(ostream& t,STR& s2);
	friend int operator==(STR& s1,STR& s2);
};