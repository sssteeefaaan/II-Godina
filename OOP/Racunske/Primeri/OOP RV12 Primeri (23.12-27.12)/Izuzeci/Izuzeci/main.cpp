#include "List.h"
#include <iostream>
using namespace std;

#include <windows.h> // for EXCEPTION_ACCESS_VIOLATION
#include <excpt.h> 

int filter(unsigned int code, struct _EXCEPTION_POINTERS *ep) {

   puts("in filter.");

   if (code == EXCEPTION_ACCESS_VIOLATION) {

      puts("caught AV as expected.");

      return EXCEPTION_EXECUTE_HANDLER;

   }

   else {

      puts("didn't catch AV, unexpected.");

      return EXCEPTION_CONTINUE_SEARCH;

   };

} 

void main()
{
 //
	//element* p = 0;
	//__try
	//{
	//	int s = 5;
	//	s = s/ 0;
	//	cout << p->info;
	//}	
	//__except(filter(GetExceptionCode(), GetExceptionInformation()))
	//{
	//	cout << "Exception.";
	//}
	//

	List l;
	l.push(4);
	l.push(6);

	try
	{
		l.write();
		l.pop();
		l.write();
		l.pop();		
		l.pop();
		l.write();
		l.pop();
		l.write();
		l.pop();
		l.pop();
	}
	catch(std::exception *ex)
	{
		cout << ex->what();
	}
	catch (char* c)
	{
		cout << c;
	}
	catch(...)
	{
		cout << "Exception!";			
	}

	cout << "!!!!!!!!1" << endl;
	l.push(11);
	l.push(12);
}
