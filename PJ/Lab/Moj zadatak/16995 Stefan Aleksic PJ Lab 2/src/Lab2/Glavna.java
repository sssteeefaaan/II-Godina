package Lab2;

import java.util.Scanner;

public class Glavna {

	public static void main(String[] args)
	{
		Scanner UnosM=new Scanner (System.in);
		
		System.out.println("Unesite naziv Agencije:");
		String S=UnosM.nextLine();
		Agencija A1=new Agencija(S);
		
		A1.Sort();
		A1.Prikazi();
	}
}
