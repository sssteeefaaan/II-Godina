#include <stdio.h>
#include "Abc.h"

void stampajA(Abc& c)
{
	printf("Vrednost a je %d\n", c.getA());
}

void main()
{
	Abc c, c2, c3;

	stampajA(c);		// inicijalna vrednost a je 10 (definisano u Abc.cpp)

	c.incA();			// povecava a za 1, a=11
	c2.incA();			// povecava a za 1, a=12
	c3.incA();			// povecava a za 1, a=13

	stampajA(c3);		// a=13

}