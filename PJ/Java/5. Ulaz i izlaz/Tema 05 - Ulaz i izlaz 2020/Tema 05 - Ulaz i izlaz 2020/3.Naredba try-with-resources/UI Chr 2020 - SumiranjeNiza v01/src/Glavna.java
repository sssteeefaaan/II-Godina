import java.io.*;

public class Glavna {

	public static void main(String[] args) {

		// Sve klase koje predstavljaju tokove podataka implementiraju interfejse 
		// AutoCloseable i Closeable pa njihove objekte možemo da kreiramo u 
		// "try-with-resources" naredbi. 
		// Moguće je kreirati i više nezavisnih objekata kao što su r i r2 u ovom primeru. 
		// Oni se onda zatvaraju pri završetku try bloka nezavisno jedan od drugog tj. čak i ako 
		// zatvaranje prvog objekta baci izuzetak nastaviće se izvršenje i zatvoriće se drugi objekat. 
		try (ulazizlaz.TypeReader r = new ulazizlaz.TypeReader(new InputStreamReader(System.in)); 
			 ulazizlaz.TypeReader r2 = new ulazizlaz.TypeReader(new FileReader("FNiz.txt"));) {

			System.out.print("Unesite dimenziju niza: ");
			int nd = r.readInt();
			int i;
			double[] nizd = new double[nd];

			for (i = 0; i < nd; i++) {
				System.out.print("Unesite element broj "+(i+1)+": ");
				nizd[i] = r.readDouble();
			}

			int nf = r2.readInt();
			float[] nizf = new float[nf];

			for (i = 0; i < nf; i++)
				nizf[i] = r2.readFloat();

			double sd;
			float sf;
			for (sd = 0, i = 0; i < nd; sd += nizd[i++])
				; // sumiranje Doubleova
			for (sf = 0, i = 0; i < nf; sf += nizf[i++])
				; // sumiranje Floatova

			System.out.println("Suma elemenata niza učitanog sa std. ulaza je: " + sd);
			System.out.println("Suma el.niza učitanog iz datoteke je " + sf);
		} 
		catch (IOException ex) {
			System.out.println(ex.toString());
		}
	}
}