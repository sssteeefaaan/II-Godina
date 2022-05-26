#include <iostream.h>

class Datum
{
public:

   int dan, mesec, godina;
   friend istream& operator>> ( istream& is, Datum& dt );	// preklapanje operatora >> 
};

istream& operator>> ( istream& is, Datum& dt )
{

	is >> dt.dan >> dt.mesec >> dt.godina;	// npr: 4 <enter> 11 <enter> 2003 <enter> 
	return is;
}

void main()
{
   Datum dt;
   cin >> dt;

   cout << "Dan:" << dt.dan << "\nMesec:" << dt.mesec << "\nGodina:" << dt.godina;
}
