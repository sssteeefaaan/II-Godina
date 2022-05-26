#include <fstream.h>
#include "List.h"
#include <afx.h>


void main()
{
/*
	element* p = NULL;
	try
	{
		cout << p->info;
	}
	catch (...)
	{
		cout << "Exception.";
	}

*/

	List l;
	l.push(4);
	l.push(6);

	try
	{
		l.pop();
		l.write();
		l.pop();
		l.write();
		l.pop();
	}
	catch(...)
	{
		cout << "Exception! ";	
	}

}
