#include <math.h>
#include <iostream>
using namespace std;

void polar(double x, double y, double* r, double* fi)
{
	*r = sqrt(x*x + y*y);
	*fi = (x==0 && y==0) ? 0 : atan2(y,x);
}

void polar(double x, double y, double& r, double& fi)
{
	r = sqrt(x*x + y*y);
	fi = (x==0 && y==0) ? 0 : atan2(y,x);
}

int main()
{
	double x, y;
	cin >> x >> y;

	double r, fi;
	polar(x,y, &r, &fi);

	cout << r << " " << fi << endl;

	polar(2*x, 2*y, r, fi);
	cout << r << " " << fi << endl;

}