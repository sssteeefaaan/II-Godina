
class Poruka {
	
	private String sadrzaj;
	public static int brojPoruka = 0;
	
	public Poruka (String pocetniSadrzaj)
	{
		sadrzaj = pocetniSadrzaj;
		brojPoruka++;
	}
	
	public void prikazi()
	{
		System.out.println(sadrzaj);
	}
	
	public static void main (String args[])
	{
		Poruka p1 = new Poruka("OVO");
		Poruka p2 = new Poruka("JE");
		Poruka p3 = new Poruka("PORUKA");
		
		p1.prikazi();
		p2.prikazi();
		p3.prikazi();
		
		System.out.println("Ukupan broj poruka je: " + brojPoruka);
		
	}

}
