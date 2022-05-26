import java.util.Scanner;

public class Zimovanje extends Putovanje{
	private int cenaski;
	
	Zimovanje()
	{
		super();
		vrsta="Zimovanje";
		UnosSki();
	}
	void UnosSki()
	{
		System.out.println("Unesite cenu skipass-a:");
		Scanner UnosZ=new Scanner(System.in);
		this.cenaski=GetInt(UnosZ);
	}
	int Cena()
	{return super.Cena()+cenaski*trajanje;}
	void Info()
	{
		super.Info();
		System.out.println("Cena skipass-a iznosi: "+cenaski+"€");
		System.out.println("Ukupna cena putovanja: "+Cena()+"€");
	}
}
