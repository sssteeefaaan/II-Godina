#include "trougao.h"
#include <iostream.h>

void f1(trougao t)
{
	cout << t.obim()<<endl;
}

void main()
{
	ntougao* p;
	p = new trougao;
	cout << "unesite duzine stranica " << endl;
	cin >> *p;
	cout << "obim: " << p->obim() << endl;
	cout << "povrsina: " << p->povrsina() << endl;
	
	
	trougao t1;
	cout << "unesite stranice trougla" << endl;
	cin>>t1;
	f1(t1);
}