#include <iostream.h>
#include <iomanip.h>

void primer_width()
{
   double values[] = { 1.23, 35.36, 653.7, 4358.24 };
   for( int i = 0; i < 4; i++ )
   {
      cout.width(10);
      cout << values[i] << '\n';
   }
}

void primer_fill()
{
   double values[] = { 1.23, 35.36, 653.7, 4358.24 };
	for( int i = 0; i < 4; i++ )
	{
	   cout.width( 10 );
	   cout.fill( '*' );
	   cout << values[i] << endl;
	}

}

void primer_setw()
{
   cout.fill( ' ' );	// vraca na standardnu vrednost, blanko
   cout << "\n\n\n\n";
   double values[] = { 1.23, 35.36, 653.7, 4358.24 };
   char *names[] = { "Zoot", "Jimmy", "Al", "Stan" };
   for( int i = 0; i < 4; i++ )
      cout << setw( 6 )  << names[i]
           << setw( 10 ) << values[i] << endl;

}


void main()
{
	primer_width();
	primer_fill();
	primer_setw();
}