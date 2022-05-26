import java.util.Scanner;

public class Letovanje extends Putovanje {
	private int trajekt;
	private boolean trjkt;
	
	Letovanje()
	{
		super();
		vrsta="Letovanje";
		Trajekt();
	}
	void Trajekt()
	{
		Scanner UnosL=new Scanner(System.in);
		System.out.println("Da li je neophodan trajekt?\n1-Da, ili 0-Ne");
		if(GetInt(UnosL)==1)
		{
			this.trjkt=true;
			System.out.println("Unesite cenu trajekta:");
			this.trajekt=GetInt(UnosL);
		}
		else
			this.trjkt=false;
	}
	int Cena()
	{
		if (trjkt)
			return super.Cena()+trajekt;
		else
			return super.Cena();
	}
	void Info()
	{
		super.Info();
		if(trjkt)
			System.out.println("Putovanje zahteva trajekt.\nCena trajekta iznosi: "+trajekt+"€");
		else
			System.out.println("Putovanje ne zahteva trajekt.");
		System.out.println("Ukupna cena putovanja: "+Cena()+"€");
	}
}