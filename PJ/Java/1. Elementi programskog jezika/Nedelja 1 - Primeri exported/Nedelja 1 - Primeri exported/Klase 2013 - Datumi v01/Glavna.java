
public class Glavna {

	public static void main(String[] args) {
		
		Datum datum1 = new Datum();	// zagrade obavezno moraju da stoje
		Datum datum2 = new Datum();	// kada izme�u njih nema ni�ta, onda
									// se poziva default konstruktor
									// ali to ovde nije tema
		
		Datum.prestupna = false;	// recimo da NIJE prestupna, nebitno
		
		datum1.postavi(29,2);		// uneti datume po �elji
		datum2.postavi(15,1);		// (ovi su samo za primer)
		
// sa ovako unetim datumima, prvi datum ne�e pro�i, jer je re�eno da
// godina NIJE prestupna, pa ne postoji taj datun; program �e javiti da je
// une�en lo� podatak za datum (u slu�aju prvog datuma), i postavi�e 1.1.
// a drugi datum �e lepo prihvatiti... onda �e ih pore�ati po redu...
// i broja�e od 1.1. do 15.1. (�to je 14 dana)
		
		Datum.poredjaj(datum1, datum2);
		
		int brDana;
		brDana = Datum.brojDana(datum1, datum2);
		System.out.println("Broj dana je: "+brDana);		
	}
}
