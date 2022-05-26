#include <iostream>
using namespace std;
#include "MallardDuck.h"

void main()
{
	Duck a;
	a.Swim();
	a.Quack();

	MallardDuck b;
	b.Swim();
	b.Fly();
	b.Quack();

	Duck* d;
	d = &a;
	d->Swim();

	d = &b;
	d->Swim();
	
	MallardDuck* m;
	m = &b;
	m->Swim();
	m->Fly();

	Duck* f = new Duck(a);
	f->Draw();

	d = f;

	f = new MallardDuck(b);
	d->Swim();
	f->Swim();

	MallardDuck* fInit = new MallardDuck();
	Duck* md = (Duck*)fInit;
	delete fInit;
}