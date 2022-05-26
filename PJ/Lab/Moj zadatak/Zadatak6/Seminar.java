import java.util.Scanner;

public class Seminar extends Putovanje{
	private String izlet[];
	private int N;
	private int odabir;
	
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
			System.out.println("Unesite "+i+". temu seminara:");
			izlet[i-1]=UnosS.nextLine();
		}
	}
	void Odaberi()
	{
		Scanner UnosS = new Scanner(System.in);
		System.out.println("Unesi broj teme koju zelis slusati:");
		for(int i=1;i<=N;i++)
			System.out.println(i+" - "+izlet[i-1]);
		odabir=GetInt(UnosS)-1;
	}
	int Cena()
	{return super.Cena();}
	void Info()
	{
		super.Info();
		System.out.println("Teme seminara: ");
		for(int i=1;i<=N;i++)
			System.out.println(i+"."+izlet[i-1]);
		System.out.println("Ukupna cena putovanja: "+Cena()+"€");
	}
}
