#include "RacionalanBroj.h"


#include "RacionalanBroj.h"
#include "Greska.h"

//////////////////////////////////////////////////////////////////////
// Construction/Destruction
//////////////////////////////////////////////////////////////////////

bool RacionalanBroj :: operator<( const RacionalanBroj& r )
{
	if ( imenilac == 0 || r.imenilac == 0 )
		throw BROJ_NEDEFINISAN;
	if ( ( brojilac * r.imenilac ) < ( r.brojilac * imenilac ) )
		return true;
	return false;
}

istream& operator>>( istream& ulaz, RacionalanBroj& r)
{
	ulaz >> r.brojilac >> r.imenilac;
	return ulaz;
}

ostream& operator<<( ostream& izlaz, const RacionalanBroj& r)
{
	izlaz << r.brojilac << "/" << r.imenilac;
	return izlaz;
}
