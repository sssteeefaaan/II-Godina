#include "ObojeniKrug.h"

ObojeniKrug::ObojeniKrug(void)
{
}

ObojeniKrug::~ObojeniKrug(void)
{
}

std::ostream& ObojeniKrug::stampaj(std::ostream& out) const
{
	return out << "Boja (" << R << "," << G << "," << B << "), R=" << r << std::endl;
}