#include "trougao.h"
using namespace std;

void f1(trougao& t)
{
	cout << t.obim()<<endl;
}

void main()
{	
	//ntougao n; 
	//ntougao* s = new ntougao();

	ntougao* p;
	
	p = new trougao;

	cout << "unesite duzine stranica " << endl;

	cin >> *p;

	cout << "obim: " << p->obim() << endl;

	cout << "povrsina: " << p->povrsina() << endl;
	
	
	trougao t1;
	cout << "unesite stranice trougla" << endl;
	cin >> t1;
	f1(t1);

	t1.obim();
	t1.ntougao::obim();

	ntougao& nt = t1;
	cout << "obim: " << nt.obim()<< endl;;
	cout << "povrsina: " << nt.povrsina()<< endl;;


	delete p;
}