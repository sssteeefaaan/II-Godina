template <class T, int k>
class Vektor 
{
	T element [k];
public:
	int duzina;		// duzina vektora, tj. broj elemenata

public:
	Vektor();
	T& operator[] (int i);	// deklaracija operatora []
};





// definicija funkcije mora biti u istoj datoteci gde je i definicija klase. Ukoliko bi se smestila u zasebnu datotetku, 
// prevodilac bi javio gresku

template <class T, int k>
Vektor<T, k>::Vektor ()
{
	duzina = k;
	for (int i = 0; i < k; i++) element[i] = 0;
}

// definicija operatora [], omogucava pristup elementima klase Vektor kao i kod obicnog niza (npr. vek[3])
// vraca upucivac na T (T&), inace bi javljao gresku, npr. u liniji: celi[4] = 4;
template <class T, int k>
T& Vektor<T, k>::operator[] (int i) 
{
	return element[i];
}
