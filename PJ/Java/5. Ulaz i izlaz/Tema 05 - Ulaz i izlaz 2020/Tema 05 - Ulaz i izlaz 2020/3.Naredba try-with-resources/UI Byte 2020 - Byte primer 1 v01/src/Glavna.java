import java.io.*;

public class Glavna {

	public static void main(String args[]) {

		byte niz[] = new byte[2];
		niz[0] = 10;
		niz[1] = 20;

		// Sve klase koje predstavljaju tokove podataka implementiraju interfejse 
		// AutoCloseable i Closeable pa njihove objekte možemo da kreiramo u 
		// "try-with-resources" naredbi. 
 		try (BufferedOutputStream bos = new BufferedOutputStream(
				new FileOutputStream("za_citanje.bin"))) {

			bos.write(1); // upis jednog bajta
			bos.write(niz); // upis niza bajtova
			// Resursi kreirani na ovaj način u "try-with-resources" bloku se automatski 
			// zatvaraju pri izlasku iz try bloka pa ne treba sami da pozivamo close() metode.    
		}
		catch (IOException ioe_pis) {
			System.out.println("Greška pri upisu: " + ioe_pis);
		}

		// Sve klase koje predstavljaju tokove podataka implementiraju interfejse 
		// AutoCloseable i Closeable pa njihove objekte možemo da kreiramo u 
		// "try-with-resources" naredbi.
		try (BufferedInputStream bis = new BufferedInputStream(
				new FileInputStream("za_citanje.bin"))) {
			int temp;
			// Metod read vraca vrednost -1 kada nema vise sta da se cita iz fajla.
			while ((temp = bis.read()) != -1) {
				System.out.println(temp);
			}
			// Resursi kreirani na ovaj način u "try-with-resources" bloku se automatski 
			// zatvaraju pri izlasku iz try bloka pa ne treba sami da pozivamo close() metode.		
		} 
		catch (IOException ioe_cit) {
			System.out.println("Greška pri citanju: " + ioe_cit);
		}
	}
}
