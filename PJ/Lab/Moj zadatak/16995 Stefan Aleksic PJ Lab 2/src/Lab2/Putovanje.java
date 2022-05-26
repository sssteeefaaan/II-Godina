package Lab2;
import java.util.Scanner;
import java.util.Collections;

public abstract class Putovanje implements Comparable<Putovanje> {
	protected String naziv;
	protected String poc;
	protected String vrsta;
	protected int trajanje;
	protected int cenasmestaja;
	protected int cenaputa;
	
	Putovanje()
	{
		Scanner UnosP=new Scanner (System.in);
		SetNaziv(UnosP);
		SetPoc(UnosP);
		SetTrajanje(UnosP);
		SetCenaS(UnosP);
		SetCenaP(UnosP);
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
	void SetNaziv(Scanner S)
	{

		System.out.println("Unesite naziv putovanja:");
		naziv=S.nextLine();
	}
	void SetPoc(Scanner S)
	{
		System.out.println("Unesite datum pocetka:");
		poc=S.nextLine();
	}
	void SetTrajanje(Scanner S)
	{
		System.out.println("Unesite trajanje (u danima) putovanja:");
		trajanje=GetInt(S);
	}
	void SetCenaS(Scanner S)
	{
		System.out.println("Unesite cenu smestaja po danu (u evrima):");
		cenasmestaja=GetInt(S);
	}
	void SetCenaP(Scanner S)
	{
		System.out.println("Unesite cenu prevoza (u evrima):");
		cenaputa=GetInt(S);
	}
	abstract int Cena();
	void Info()
	{
		System.out.println("Vrsta: "+vrsta+"\nNaziv: "+naziv+"\nPocetak: "+poc+"\nTrajanje: "+trajanje+" dana");
		System.out.println("Cena smestaja po danu: "+cenasmestaja+"€\nCena puta: "+cenaputa+"€");
	}
	public static int GetInt(Scanner A)
	{
		int a=A.nextInt();
		A.nextLine();
		return a;
	}
	public int compareTo(Putovanje P2)
	{
		if(this.Cena()<P2.Cena())
			return -1;
		else {
			if (this.Cena()==P2.Cena())
				return 0;
			else
				return 1;
		}
	}
}
