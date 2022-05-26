#include "ZeleniKrug.h"
using namespace std;

void main()
{

	ObojeniKrug* ob = new ZeleniKrug(12);
	ob->stampaj();
	ob->SetKoordinate(2,2);
	ob->promeniR(12);
	ob->stampaj();
	//delete ob;

	ObojeniKrug ob2(*ob);

	//ZeleniKrug z(*ob2);
	ZeleniKrug z;
	ZeleniKrug z2(z);

	Krug** krugovi = new Krug*[10];	
	for(int i = 0; i < 10; i++)
	{
		cout << "i=" << i << endl;
		if (i%3 == 0)		
			krugovi[i] = new Krug(i);		
		else if (i%3 == 1)		
			krugovi[i] = new ObojeniKrug(i);		
		else		
			krugovi[i] = new ZeleniKrug(i);

		krugovi[i]->SetKoordinate(i - 1, i + 11);
		krugovi[i]->stampaj();
		krugovi[i]->promeniR(i%5);
		krugovi[i]->stampaj();
	}
	delete[] krugovi;
}

