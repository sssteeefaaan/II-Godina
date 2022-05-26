
public class Glavna {

	public static void main(String[] args) {
		
		Datum datum1 = new Datum();	// zagrade obavezno moraju da stoje
		Datum datum2 = new Datum();	// kada izmeðu njih nema ništa, onda
									// se poziva default konstruktor
									// ali to ovde nije tema
		
		Datum.prestupna = false;	// recimo da NIJE prestupna, nebitno
		
		datum1.postavi(29,2);		// uneti datume po želji
		datum2.postavi(15,1);		// (ovi su samo za primer)
		
// sa ovako unetim datumima, prvi datum neæe proæi, jer je reèeno da
// godina NIJE prestupna, pa ne postoji taj datun; program æe javiti da je
// unešen loš podatak za datum (u sluèaju prvog datuma), i postaviæe 1.1.
// a drugi datum æe lepo prihvatiti... onda æe ih poreðati po redu...
// i brojaæe od 1.1. do 15.1. (što je 14 dana)
		
		Datum.poredjaj(datum1, datum2);
		
		int brDana;
		brDana = Datum.brojDana(datum1, datum2);
		System.out.println("Broj dana je: "+brDana);		
	}
}
