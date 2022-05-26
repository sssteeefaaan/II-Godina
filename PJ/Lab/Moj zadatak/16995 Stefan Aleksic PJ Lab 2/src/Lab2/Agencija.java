package Lab2;
import java.util.ArrayList;
import java.util.Scanner;

public class Agencija{
	private String Naziv;
	private ArrayList<Putovanje> Lista;
	
	public Agencija(String S)
	{
		Naziv=S;
		Lista=new ArrayList<>();
		Put();
	}
	void Put()
	{
		Scanner UnosA=new Scanner(System.in);
		int d;
		boolean i=true;
		while(i)
		{
			System.out.println("Unesite vrstu putovanja:\nL-Letovanje\tS-Seminar\tZ-Zimovanje\t K-Kraj");
			String p=UnosA.nextLine();
			switch (p)
			{
			case ("L"):
				Lista.add(new Letovanje());
				break;
			case("Z"):
				Lista.add(new Zimovanje());
				break;
			case ("S"):
				System.out.println("Unesite broj destinacija seminara:");
				d=Putovanje.GetInt(UnosA);
				Lista.add(new Seminar(d));
				break;
			case ("K"):
				i=false;
				break;
			default:
				System.out.println("Greska. Pokusajte ponovo.");
				break;
			}
		}
	}
	void Prikazi()
	{
		System.out.println("------------------------------");
		System.out.println("Agencija \""+Naziv+"\"");
		System.out.println("------------------------------");
		int i=1;
		for(Putovanje x : Lista)
		{
			System.out.println("Putovanje broj "+(i++)+":");
			x.Info();
			System.out.println("------------------------------");
		}
	}
	
	void Sort()
	{
		Lista.sort(null);
	}
}