import java.util.Scanner;

public class Agencija{
	private String Naziv;
	private Putovanje[] Lista;
	private int N;
	
	Agencija(String S, int N)
	{
		Naziv=S;
		this.N=N;
		Lista=new Putovanje[N];
		Put();
	}
	void Put()
	{
		Scanner UnosA=new Scanner(System.in);
		int i=0,d;
		while(i<N)
		{
			System.out.println("Unesite vrstu putovanja:\nL-Letovanje\tS-Seminar\tZ-Zimovanje");
			String p=UnosA.nextLine();
			switch (p)
			{
			case ("L"):
				Lista[i++]=new Letovanje();
				break;
			case("Z"):
				Lista[i++]=new Zimovanje();
				break;
			case ("S"):
				System.out.println("Unesite broj tema seminara:");
				d=GetInt(UnosA);
				Lista[i++]=new Seminar(d);
				break;
			default:
				System.out.println("Greska. Pokusajte ponovo.");
				break;
			}
		}
	}
	void Prikazi()
	{
		System.out.println("Agencija \""+Naziv+"\"");
		System.out.println("------------------------------");
		for(int i=1;i<=N;i++)
		{
			System.out.println("Putovanje broj "+i+":");
			Lista[i-1].Info();
			System.out.println("------------------------------");
		}
	}
	public static int GetInt(Scanner A)
	{
		int a=A.nextInt();
		A.nextLine();
		return a;
	}
	void SortNeopadajuci()
	{
		int i,j,min,imin;
		Putovanje pom;
		for(i=0;i<N-1;i++)
		{
			min=Lista[i].Cena();
			imin=i;
			for(j=i+1;j<N;j++)
			{
				if(min>Lista[j].Cena())
				{
					min=Lista[j].Cena();
					imin=j;
				}
			}
			pom=Lista[i];
			Lista[i]=Lista[imin];
			Lista[imin]=pom;
		}
	}
	void SortNerastuci()
	{
		int i,j,max,imax;
		Putovanje pom;
		for(i=0;i<N-1;i++)
		{
			max=Lista[i].Cena();
			imax=i;
			for(j=i+1;j<N;j++)
			{
				if(max<Lista[j].Cena())
				{
					max=Lista[j].Cena();
					imax=j;
				}
			}
			pom=Lista[i];
			Lista[i]=Lista[imax];
			Lista[imax]=pom;
		}
	}
	
	public static void main(String[] args)
	{
		Scanner UnosM=new Scanner (System.in);
		
		System.out.println("Unesite naziv Agencije:");
		String S=UnosM.nextLine();
		System.out.println("Unesite koliko Agencija ima putovanja:");
		Agencija A1=new Agencija(S,GetInt(UnosM));
		
		A1.SortNerastuci();
		A1.Prikazi();
	}
}