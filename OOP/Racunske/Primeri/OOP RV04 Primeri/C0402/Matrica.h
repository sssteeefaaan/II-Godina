#include <iostream>
using namespace std;

class Matrica  
{
public:
	Matrica();
	Matrica( int brVrsta, int brKolona);	
	Matrica( const Matrica& mat );
	
	virtual ~Matrica();
	Matrica pomnozi( const Matrica& m );

	friend istream& operator>>( istream& ulaz, Matrica& v);
	friend ostream& operator<<( ostream& ulaz, const Matrica& v);

private:
	int** a;
	int m;	// broj kolona
	int n;	//broj vrsta
};