package Lab2;
import java.util.Scanner;

public class Seminar extends Putovanje{
	private String izlet[];
	private int N;
	
	Seminar(int N)
	{
		super();
		vrsta="Seminar";
		this.N=N;
		izlet=new String[N];
		TemeSeminara();
	}
	void TemeSeminara()
	{
		Scanner UnosS=new Scanner(System.in);
		for(int i=1;i<=N;i++)
		{
			System.out.println("Unesite "+i+". destinaciju:");
			izlet[i-1]=UnosS.nextLine();
		}
	}
	int Cena()
	{return trajanje*cenasmestaja + cenaputa;}
	void Info()
	{
		super.Info();
		System.out.println("Destinacije: ");
		for(int i=1;i<=N;i++)
			System.out.println(i+"."+izlet[i-1]);
		System.out.println("Ukupna cena putovanja: "+Cena()+"€");
	}
}
