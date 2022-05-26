// podela1.cpp - Uredivanje niza brojeva metodom podele (quick sort).

inline void zameni(int& x, int& y)
{ int z = x; x = y; y = z; }

static int podeli(int a[], int n) {
	int& b = a[n-1], i = -1, j = n-1;
	while (i < j ) {
		do i++; while (a[i] < b);
		do j--; while (j>=0 && a[j]>b);
		zameni(a[i], (i<j) ? a[j] : b);
	}
	return i;
}

void uredi(int a[], int n) {
	if (n > 1) {
		int i = podeli(a, n);
		uredi(a, i);
		uredi(a+i+1, n-i-1);
	}
}