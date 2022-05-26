import java.io.*;

public class Glavna {

	public static void main(String args[]) {

		byte niz[] = new byte[2];
		niz[0] = 10;
		niz[1] = 20;

		FileOutputStream fos = null;
		BufferedOutputStream bos = null;
		try {
			fos = new FileOutputStream("za_citanje.bin");
			bos = new BufferedOutputStream(fos);

			bos.write(1); // upis jednog bajta
			bos.write(niz); // upis niza bajtova
			// bos.close(); // Zatvaranje toka na ovom mestu nije sigurno jer ako se desi da
			// prethodni pozivi write() naredbe bace izuzetak ova naredba se neće uopšte izvršiti. 
		}
		catch (IOException ioe_pis) {
			System.out.println("Greška pri upisu: " + ioe_pis);
		}
		finally {
			// Da bi se objekat bos sigurno zatvorio, ispravno je da se to zatvaranje odradi u 
			// finally bloku koji se izvršava svakako, čak i ako dođe do izuzetka u prethodnom 
			// try bloku. 
			// Ovo zatvaranje može takođe da dovede do izuzetka pa mora da se piše u posebnom 
			// try-catch bloku. 
			if (bos != null) {
				try {
					bos.close();
				} catch (IOException ioe_zat) {
					System.out.println("Greška pri zatvaranju: " + ioe_zat);
				}
			}
		}

		FileInputStream fis = null;
		BufferedInputStream bis = null;
		try {
			fis = new FileInputStream("za_citanje.bin");
			bis = new BufferedInputStream(fis);

			int temp;
			// Metod read vraca vrednost -1 kada nema vise sta da se cita iz fajla.
			while ((temp = bis.read()) != -1) {
				System.out.println(temp);
			}
			// bis.close(); // Zatvaranje toka na ovom mestu nije sigurno jer ako se desi da
			// prethodni pozivi read() naredbe bace izuzetak ova naredba se neće uopšte izvršiti.
		} 
		catch (IOException ioe_cit) {
			System.out.println("Greška pri citanju: " + ioe_cit);
		}
		finally {
			// Da bi se objekat bis sigurno zatvorio, ispravno je da se to zatvaranje odradi u 
			// finally bloku koji se izvršava svakako, čak i ako dođe do izuzetka u prethodnom 
			// try bloku.
			// Ovo zatvaranje može takođe da dovede do izuzetka pa mora da se piše u posebnom 
			// try-catch bloku. 
			if (bis != null) {
				try {
					bis.close();
				} catch (IOException ioe_zat) {
					System.out.println("Greška pri zatvaranju: " + ioe_zat);
				}
			}
		}
	}
}
