#include <iostream.h>

class Datum
{
public:

   int dan, mesec, godina;
   Datum (int d, int m, int g){
	   dan = d; mesec = m; godina = g;
   }
   friend ostream& operator<< ( ostream& os, Datum& dt );	// preklapanje operatora <<
};

ostream& operator<< ( ostream& os, Datum& dt )
{

	os << dt.dan << "." << dt.mesec << "." << dt.godina;	
	return os;
}

void main()
{
   Datum dt(4,11,2004);
   cout << dt;	

}
