
class Datum {
	
	private int dan=1;					// atribut objekata
	private int mesec=1;				// atribut objekata
	static boolean prestupna=false;		// atribut (cele) klase
	
//	metod objekata za postavljanje vrednosti
	public void postavi (int d, int m)
	{
		if ((1<=m) && (m<= 12))	// jel valjan podatak za mesec?
		{
			// sada proveravamo da li je ispravan podatak za taj
			// mesec... a za to moramo da pozovemo u pomoc metod
			// duzinaMeseca - koji je definisan nize u kodu
			int duzina = duzinaMeseca(m);
			
			if ((1<=d) && (d<=duzina))	// da li podatak za
			{							// dan valja za taj mesec?
				this.dan = d;
				this.mesec = m;
				System.out.print("Postvio sam: ");
				this.stampaj();
			}
			else
				System.out.println("Loš podatak za DAN ("+d+"."+m+".), postavljam 1.1.");
		}
		else
			System.out.println("Loš podatak za MESEC, postavljam 1.1.");
	}
//	metod objekata za stampanje vrednosti objekta
	public void stampaj()
	{
		System.out.println(dan+"."+mesec+".");
	}
	
// metod KLASE koji vraca broj dana izmedju dva datuma
// princip: prvo poredjamo datume u odgovarajuci redosled, pozivom
// metoda poredjaj; onda brojimo od prvog januara do prvog datuma,
// i dobijemo broj dana do njega; na isti nacin izbrojimo dane do
// drugog od ta dva datuma; i metod vrati razliku izmedju ta dva
// broja dana (to je razmak u danima izmedju ta dva datuma:
	static int brojDana(Datum d1, Datum d2)
	{
		Datum.poredjaj(d1, d2);	// ovo ih stavlja u normalan redosled
//		d1.stampaj();			// provera
//		d2.stampaj();			// provera
		int brojac1 = 0;
		int brojac2 = 0;
		int i;
		// brojanje od 1.1. do prvog datuma
		for (i=0; i<d1.mesec; i++)
			brojac1 += Datum.duzinaMeseca(i);	// mesec po mesec
		for (i=0; i<d1.dan; i++)
			brojac1++;							// dan po dan
//		System.out.println("Broj dana do "+d1.dan+"."+d1.mesec+". je: "+brojac1+" (DANI)");
		// brojanje od 1.1. do drugog datuma
		for (i=0; i<d2.mesec; i++)
			brojac2 += Datum.duzinaMeseca(i);	// mesec po mesec
		for (i=0; i<d2.dan; i++)
			brojac2++;							// dan po dan
//		System.out.println("Broj dana do "+d2.dan+"."+d2.mesec+". je: "+brojac2);
		
		return brojac2 - brojac1;
	}
	
// metod KLASE koji vraca broj dana zadatog meseca
	static int duzinaMeseca(int mes)
	{
		int mesec = mes;	// pomocna promenljiva
		switch (mesec)
		{
		case 1:		// januar
		case 3:		// mart
		case 5:		// maj
		case 7:		// jul
		case 8:		// avgust
		case 10:	// oktobar
		case 12:	// decembar
			return 31;		// svi imaju 30 dana
		case 4:		// april
		case 6:		// jun
		case 9:		// septembar
		case 11:	// novembar
			return 30;		// svi imaju 31 dan
		case 2:		// ali februar je malo nezgodan...
			if (Datum.prestupna)	// pitamo promenljivu KLASE
				return 29;			// da li je godina prestupna,
			else					// i zavisno od toga vracamo
				return 28;			// broj dana za februar
		}
		return 0;	// u bilo kom drugom slucaju metod ce za duzinu
					// meseca vratiti nulu... ovu osobinu mozemo lepo
					// da iskoristimo u metodu za racunanje broja dana
					// od jednog datuma do drugog
	}

// metod KLASE koji redja dva datuma po redu
// uzima dva objekta klase Datum, i po potrebi im medjusobno razmenjuje
// vrednosti (posto se objekti klasa prenose po referenci, to znaci
// da ako im metod medjusobno zameni mesta, to se odrazava i na ostatak
// metoda koji je pozvao ovaj metod)
	static void poredjaj(Datum dat1, Datum dat2)
	{
		if (dat1.mesec > dat2.mesec)		// ako je mesec veci kod prvog
			Datum.zameniMesta(dat1, dat2);	// medjusobno razmenjuju vrednosti
		else									// a ako su im meseci jednaki
			if ((dat1.mesec) == (dat2.mesec))	// a dan veci kod prvog
				if (dat1.dan >= dat2.dan)		// opet razmenjuju vrednosti
					Datum.zameniMesta(dat1, dat2);
		// inace ostaju kakvi su bili
	}
	

	
/* varijanta metoda za medjusobnu razmenu datuma:

// metod KLASE koji medjusobno razmenjuje mesta dvojici datuma
	static void zameniMesta(Datum dat1, Datum dat2)
	{
		Datum pom = dat1;
		dat1 = dat2;
		dat2 = pom;
		pom = null;
	}
*/
	
//	 metod KLASE koji medjusobno razmenjuje mesta dvojici datuma	
	static void zameniMesta(Datum d1, Datum d2)
	{
		int pomDat, pomMes;
		
		pomDat = d1.dan;
		pomMes = d1.mesec;
		
		d1.dan = d2.dan;
		d1.mesec = d2.mesec;
		
		d2.dan = pomDat;
		d2.mesec = pomMes;
	}
}