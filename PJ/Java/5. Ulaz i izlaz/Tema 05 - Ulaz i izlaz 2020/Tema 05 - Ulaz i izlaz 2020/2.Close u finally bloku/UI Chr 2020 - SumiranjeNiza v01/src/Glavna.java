import java.io.*;

public class Glavna {

	public static void main(String[] args) {
		ulazizlaz.TypeReader r = null;
		ulazizlaz.TypeReader r2 = null;
		try {
			r = new ulazizlaz.TypeReader(new InputStreamReader(System.in));
			r2 = new ulazizlaz.TypeReader(new FileReader("FNiz.txt"));

			System.out.print("Unesite dimenziju niza: ");
			int nd = r.readInt();
			int i;
			double[] nizd = new double[nd];

			for (i = 0; i < nd; i++) {
				System.out.print("Unesite element broj " + (i + 1) + ": ");
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
		} catch (IOException ex) {
			System.out.println(ex.toString());
		} finally {
			// Da bi se objekti r i r2 sigurno zatvorili, ispravno je da se to
			// zatvaranje odradi u
			// finally bloku koji se izvršava svakako, čak i ako dođe do
			// izuzetka u prethodnom
			// try bloku.
			// Ovo zatvaranje može takođe da dovede do izuzetka pa mora da se
			// piše u posebnim
			// try-catch blokovima.
			// Da bi se r2 sigurno zatvorio čak i ako se pri zatvaranju r javi
			// izuzetak za svako
			// zatvaranje pravimo poseban try-catch blok.
			if (r != null) {
				try {
					r.close();
				} catch (IOException e) {
					System.out.println("Greška pri zatvaranju: " + e.toString());
				}
			}
			if (r2 != null) {
				try {
					r2.close();
				} catch (IOException e) {
					System.out.println("Greška pri zatvaranju: " + e.toString());
				}
			}
		}
	}
}