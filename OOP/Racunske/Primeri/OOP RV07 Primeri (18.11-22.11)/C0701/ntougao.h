#include <iostream>
using namespace std;

class ntougao  
{
protected:
	int br_temena;
	float *duzina;
public:
	virtual float povrsina()=0;
	float obim();
	ntougao(int n);
	virtual ~ntougao();
	friend istream& operator>>( istream& in, 
								ntougao& nt );

};

