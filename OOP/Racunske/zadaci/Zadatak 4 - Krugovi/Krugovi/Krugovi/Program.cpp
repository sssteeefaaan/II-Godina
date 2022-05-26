#include "ZeleniKrug.h"
using namespace std;

void main()
{
	Krug* kn, *ko, *kz;
	kn = new Krug(23.3);
	ko = new ObojeniKrug(34, 67, 23, 13.98);
	kz = new ZeleniKrug(23.3);
	cout << *kn << endl << *ko << endl << *kz;
	delete kn;
	delete ko;
	delete kz;

}