#include "XOMatrix.h"
#include <iostream>
#include "MyPoint.h"
using namespace std;
void main()
{
	TemplateMatrix<int,4,4> a;
	
	SquareTemplateMatrix<char, 6> c;
	c.SetElement(2,3,'c');
	cout << c.GetElement(2,3);

	SquareTemplateMatrix<int, 4> sq2;

	TemplateMatrix<int, 4, 4>* pt = &sq2;
	pt = &a;

	SquareTemplateMatrix<int, 3> sq3;
	pt = &sq3;

	pt->GetElement(1,1);

	TemplateMatrix<MyPoint,3,3>* b = new XOMatrix();

	b->SetElement(0,0, *(new MyPoint(1.3, 2.3)) );

	cout << b->GetElement(0,0).GetX() << b->GetElement(0,0).GetY();
	
	delete b;
}