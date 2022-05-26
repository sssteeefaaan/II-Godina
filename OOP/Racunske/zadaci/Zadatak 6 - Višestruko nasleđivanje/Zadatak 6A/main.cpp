#include "Olovka.h"
#include <iostream.h>

void main()
{
	Olovka o(2,5,3);
	cout << "povrsina tela: " << o.povrsina() << endl
		<< "zapremina tela: " << o.zapremina() << endl;
}