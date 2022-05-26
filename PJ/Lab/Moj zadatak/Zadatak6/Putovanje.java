import java.util.Scanner;

public abstract class Putovanje {
	protected String naziv;
	protected String poc;
	protected String vrsta;
	protected int trajanje;
	protected int cenasmestaja;
	protected int cenaputa;
	
	Putovanje()
	{
		Scanner UnosP=new Scanner (System.in);
		System.out.println("Unesite naziv putovanja:");
		naziv=UnosP.nextLine();
		System.out.println("Unesite datum pocetka:");
		poc=UnosP.nextLine();
		System.out.println("Unesite trajanje putovanja:");
		trajanje=GetInt(UnosP);
		System.out.println("Unesite cenu smestaja po danu:");
		cenasmestaja=UnosP.nextInt();
		System.out.println("Unesite cenu prevoza:");
		cenaputa=UnosP.nextInt();
	}
	Putovanje(int a)
	{
		naziv="Neodredjeno";
		poc="Neodredjeno";
		vrsta="Neodredjeno";
		trajanje=a;
		cenasmestaja=a;
		cenaputa=a;
	}
	int Cena()
	{return trajanje*cenasmestaja + cenaputa;}
	void Info()
	{
		System.out.println("Vrsta: "+vrsta+"\nNaziv: "+naziv+"\nPocetak: "+poc+"\nTrajanje: "+trajanje+" dana");
		System.out.println("Cena smestaja po danu: "+cenasmestaja+"€\nCena puta: "+cenaputa+"€");
	}
	public int GetInt(Scanner in)
	{
		int a=in.nextInt();
		in.nextLine();
		return a;
	}
}
