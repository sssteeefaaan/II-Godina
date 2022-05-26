#include <stdio.h>
#include "Complex.h"

void main()
{
	Complex a(10,5), b, c(2, 3);
	stampaj(a);

	b = !a;			//b = a.operator! ();
	stampaj(b);
	
	b = a - c;		// b = a.operator- (c);
	stampaj(b);

	c = a / b;		
	stampaj(c);
}
