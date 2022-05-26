
#include "Tacka.h"
#include <math.h>

void Tacka::postaviNa( float novoX, float novoY )
{
	x = novoX;
	y = novoY;
	return;
}


void Tacka::pomeriZa( float deltaX, float deltaY )
{
	x += deltaX;
	y += deltaY;
}

float Tacka::rastojanje( const Tacka& t )
{
	return ( sqrt( ( x-t.x)*(x-t.x) + ( y-t.y)*(y-t.y) ) );
}

