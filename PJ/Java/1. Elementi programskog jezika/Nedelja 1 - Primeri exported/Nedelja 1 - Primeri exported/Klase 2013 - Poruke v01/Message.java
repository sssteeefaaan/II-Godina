
class Poruka {
	
	// Atribut (podatak-clan) OBJEKATA:
	private String sadrzajPoruke;
	
	// Atribut (podatak-clan) KLASE:
	static public int brojPoruka=0;		// U startu nema poruka,
										// zato ga inicijalizujemo
										// nulom. To sami treba da
										// zakljucimo.
	
	// Metodi (funkcije-clanice) OBJEKATA:
	public void postaviSadrzajPoruke(String tekstNovePoruke)
	{
		sadrzajPoruke = tekstNovePoruke;
		brojPoruka++;
	}
	public void prikazi()
	{
		System.out.println(sadrzajPoruke);
	}
	
	// Metod (funkcija-clanica) main je uvek metod KLASE:
	public static void main(String[] args)
	{
		// Kreiramo tri poruke (tri objekta klase Poruka):
		Poruka p1 = new Poruka();
		Poruka p2 = new Poruka();
		Poruka p3 = new Poruka();
		
		// Postavimo svakoj poruci sadrzaj:
		p1.postaviSadrzajPoruke("Zdravo!");
		p2.postaviSadrzajPoruke("Ovo je...");
		p3.postaviSadrzajPoruke("...poruka!");
		
		// Prilikom postavljanja sadrzaja, brojac poruka (koji je
		// atribut klase, zajednicki za sve kreirane objekte) biva
		// povecan za jedan - svaki put kad poruci dodelimo sadrzaj
		// (to je drugi red u metodu postaviSadrzajPoruke).
		
		// Isto to, receno malo drugacije:
		// Kada postavimo sadrzaj objektu p1, onda objekat p1 pristupi
		// atributu brojPoruka i poveca ga za jedan.
		// Onda ga p2 poveca za jedan. Onda ga p3 poveca za jedan.
		// Svaki objekat klase Poruka moze da mu pristupi i da mu radi
		// sta hoce. I svaku promenu kod njega vide svi ostali objekti. 
		
		// Prikazujemo sadrzaj svake poruke:
		
		p1.prikazi();
		p2.prikazi();
		p3.prikazi();
		
		// Sada treba da prikazemo ukupan broj poruka:
		
		System.out.println(brojPoruka);
		
		// Ako smo sve dobro uradili, treba da bude prikazano 3.
		
	}
}
