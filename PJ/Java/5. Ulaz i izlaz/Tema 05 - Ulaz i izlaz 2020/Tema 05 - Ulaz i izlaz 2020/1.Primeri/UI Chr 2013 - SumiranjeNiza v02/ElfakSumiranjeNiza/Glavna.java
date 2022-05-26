import java.io.*;

public class Glavna {

	public static void main(String[] args) {
		
		int i;	// trebace nam za petlje
		double sumaFloatova;	// trebace nam za sumiranje float niza
		float sumaDoublova;		// trebace nam za sumiranje double niza
		
		try
		{
			ulazizlaz.Citac tastatura = new ulazizlaz.Citac(new InputStreamReader(System.in));
			ulazizlaz.Citac fajl = new ulazizlaz.Citac(new FileReader("FloatNiz.txt"));
			
			
			System.out.print("Unesite dimenziju niza: ");
			int dimenzijaDoubleNiza = tastatura.citajInt();
			// kada imamo dimenziju, kreiramo lokalni niz
			double[] nizDoublova = new double [dimenzijaDoubleNiza];
			// onda ucitavamo podatke sa tastature u lokalni niz:
			for (i=0; i<dimenzijaDoubleNiza; i++)
			{
				System.out.print("Unesite elemenat broj "+(i+1)+": ");
				nizDoublova[i]=tastatura.citajDouble();
			}
			
			// sada iz fajla ucitavamo prvo podatak o dimenziji float niza
			// (zato sto smo odlucili da u fajlu prvi element bude dimenzija niza)
			// mogli smo i drugacije da organizujemo fajl, da smo hteli
			int dimenzijaFloatNiza=fajl.citajInt();
			// cim imamo dimenziju, kreiramo novi lokalni niz:
			float[] nizFloatova = new float[dimenzijaFloatNiza];
			// ucitamo elemente iz fajla u lokalni niz:
			for (i=0; i<dimenzijaFloatNiza; i++)
				nizFloatova[i]=fajl.citajFloat();
			
			// sumiranje i jednog i drugog:
			for (sumaFloatova=0, i=0; i<dimenzijaDoubleNiza; sumaFloatova += nizDoublova[i++]);	// sumiranje Doubleova
			for (sumaDoublova=0, i=0; i<dimenzijaFloatNiza; sumaDoublova += nizFloatova[i++]);	// sumiranje Floatova
			
			System.out.println("Suma elemenata niza ucitanog sa standardnog ulaza je: "+sumaFloatova);
			System.out.println("Suma el.niza ucitanog iz datoteke je "+sumaDoublova);
			
			tastatura.close();
			fajl.close();
		}
		catch (IOException ex)
		{
			System.out.println(ex.toString());
			
		}
	}
}