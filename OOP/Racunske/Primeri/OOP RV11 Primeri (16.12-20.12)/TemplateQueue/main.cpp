#include "TemplateQueue.h"
#include "TemplatePoint.h"
#include "Complex.h"
#include <iostream>
using namespace std;

void main()
{
	TemplatePoint<int> point1;

	TemplatePoint<Complex> point2;

	TemplatePoint<float> point3;

	

	//point1.SetX(12);
	//point2.SetX()

	TemplateStack<int, 4> a;
	a.add(4);
	a.add(11);
	a.add(12);
	a.add(888);
	a.sort();

	cout << a.remove() << endl;

	cout << a[0] << endl;

	TemplateStack<char, 3> chars;

	chars.add('s');
	chars.add('t');

	cout << chars.remove() << endl;

	cout << chars[0] << endl;

	TemplateStack<Complex, 3> b;

	b.add(*(new Complex(3,4)));
	b.add(*(new Complex(5,6)));
	b.add(*(new Complex(7,4)));
	//b.sort();
	cout << b.remove() << endl;

	TemplatePoint<int> s(2,3);



	TemplateStack<TemplatePoint<Complex>, 5> c;

	Complex xKoord = *(new Complex(6,4));
	Complex yKoord = *(new Complex(3,7));

	TemplatePoint<Complex> p(xKoord, yKoord);

	c.add(p);

	cout << p << endl;

}