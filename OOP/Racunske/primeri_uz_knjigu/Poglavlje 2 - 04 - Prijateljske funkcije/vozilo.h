
class vozilo  
{
	int brzina;
	int stanje;
public:
	int max_brzina;
public:
	vozilo();
	vozilo(int max);
	void iskljuci();
	void ukljuci();
	void ubrzaj();
	void uspori();
	friend bool uporediBrzine(vozilo& v1, vozilo& v2) {
		if (v1.max_brzina > v2.max_brzina) return 1;
		else return 0;
	};
	friend void ispisiKarakteristike(vozilo& v);
};

