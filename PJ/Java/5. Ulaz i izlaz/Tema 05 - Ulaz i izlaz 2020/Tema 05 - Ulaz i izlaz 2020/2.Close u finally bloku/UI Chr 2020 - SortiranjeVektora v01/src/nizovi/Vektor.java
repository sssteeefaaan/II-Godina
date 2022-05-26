// Recimo da smo zapis vektora u datoteci osmislili na sledeci nacin.
// Prvi podatak je tipa int i oznacava dimenziju (broj elemenata) vektora.
// U sledećem redu je podatak tipa float, to je prvi elemenat vektora.
// U svakom sledecem redu je sledeći float element vektora, i tako do kraja.
// Znaci jedan red u fajlu - jedan podatak.
// To smo mi tako odlučili. Ne mora uvek da bude tako.
// Vektor se može upisati u fajl i na neki drugi način, bitno je samo da
// tačno znamo kako smo osmislili taj način i da ga ispoštujemo u programu.

package nizovi;

import java.io.*;

public class Vektor {

	private int dim;
	private float[] niz;

	// ------------- ČITANJE CELOG VEKTORA IZ TEKSTUALNE DATOTEKE
	// ----------------
	public void citajIzTekstualne(String imeDatoteke) {
		FileReader dat = null; // datoteku za upis reprezentuje objekat
								// FileReader
		BufferedReader bDat = null; // ne radimo direktno sa FileReader
									// objektom, već sa baferovanim objektom
		try // učitavanje je kritično i ide u try bloku
		{
			// ime datoteke stiže kao argument ovog metoda
			dat = new FileReader(imeDatoteke);
			bDat = new BufferedReader(dat);

			String pom;
			pom = bDat.readLine(); // učitava jednu liniju iz tekstualne
									// datoteke
			// (u tom redu treba da piše dimenzija vektora koji treba da bude
			// učitan iz datoteke)

			// System.out.println("Učitao dužinu vektora: " + pom); // kontrolni
			// red

			// Ono što je učitano iz datoteke (prvi red u njoj) je dimenzija
			// vektora
			// koji treba da bude učitan, ali to sto je učitano je tipa String
			// jer je datoteka tekstualna. Prvo što treba da uradimo je da taj
			// podatak prevedemo u tip int, a za to će nam pomoći metod parseInt
			// iz wrapper klase Integer (videti odgovarajuće slajdove, tematska
			// celina 2 - Klase u Javi).
			dim = Integer.parseInt(pom, 10); // drugi argument je osnova brojnog
												// sistema

			// Sada kada imamo dimenziju, učitavamo odgovarajući broj redova iz
			// datoteke, svaki pretvaramo u float i upisujemo u niz.
			niz = new float[dim];
			for (int i = 0; i < dim; i++) {
				pom = bDat.readLine();
				niz[i] = Float.parseFloat(pom);
			}
		} catch (IOException e) {
			System.out.println("Greška: " + e.toString());
		} finally {
			// Da bi se objekat bDat sigurno zatvorio, ispravno je da se to
			// zatvaranje odradi u
			// finally bloku koji se izvršava svakako, čak i ako dođe do
			// izuzetka u prethodnom
			// try bloku.
			// Ovo zatvaranje može takođe da dovede do izuzetka pa mora da se
			// piše u posebnom
			// try-catch bloku.
			if (bDat != null) {
				try {
					bDat.close();
				} catch (IOException e) {
					System.out.println("Greška pri zatvaranju: " + e.toString());
				}
			}
		}
	}

	// ------------ UPIS U TEKSTUALNU DATOTEKU ------------------
	public void writeText(String fileName) {
		FileWriter dat = null; // datoteku za čitanje reprezentuje objekat klase
								// FileWriter
		BufferedWriter bDat = null; // ne radimo direktno sa FileWriter
									// objektom, već sa baferovanim objektom
		try {
			dat = new FileWriter(fileName);
			bDat = new BufferedWriter(dat);

			// Sada treba da upišemo dimenziju u prvi red fajla, ali dimenzija
			// je tipa int,
			// a u fajl treba da upišemo tekst, znači tip String. Moramo da
			// konvertujemo
			// int u String. Za to nam služi metod valueOf klase String.
			String pomstr = new String();
			pomstr = String.valueOf(dim);
			bDat.write(pomstr); // Dimenziju konvertovanu u String upisujemo
			bDat.newLine(); // i prelazimo u novi red u fajlu.

			for (int i = 0; i < dim; i++) // U petlji upisujemo ceo vektor, red
											// po red
			{
				bDat.write(String.valueOf(niz[i])); // Upisuje element vektora
													// pretvoren u String
				bDat.newLine(); // novi red
				// System.out.println("Upisao sam u
				// "+fileName+":"+String.valueOf(niz[i]));
				// kontrolni red

			}
		} catch (IOException e) {
			System.out.println("Greska: " + e.toString());
		} finally {
			// Da bi se objekat bDat sigurno zatvorio, ispravno je da se to
			// zatvaranje odradi u
			// finally bloku koji se izvršava svakako, čak i ako dođe do
			// izuzetka u prethodnom
			// try bloku.
			// Ovo zatvaranje može takođe da dovede do izuzetka pa mora da se
			// piše u posebnom
			// try-catch bloku.
			if (bDat != null) {
				try {
					bDat.close();
				} catch (IOException e) {
					System.out.println("Greška pri zatvaranju: " + e.toString());
				}
			}
		}
	}

	// ----------- ČITANJE IZ BINARNE DATOTEKE ---------------
	public void read(String fileName) {
		FileInputStream dat;
		BufferedInputStream bDat;
		DataInputStream dataDat = null;
		try {
			dat = new FileInputStream(fileName);
			bDat = new BufferedInputStream(dat);
			dataDat = new DataInputStream(bDat);

			dim = dataDat.readInt();
			niz = new float[dim];

			for (int i = 0; i < dim; i++)
				niz[i] = dataDat.readFloat();
		} catch (IOException e) {
			System.out.println("Greska: " + e.toString());
		} finally {
			// Da bi se objekat bDat sigurno zatvorio, ispravno je da se to
			// zatvaranje odradi u
			// finally bloku koji se izvršava svakako, čak i ako dođe do
			// izuzetka u prethodnom
			// try bloku.
			// Ovo zatvaranje može takođe da dovede do izuzetka pa mora da se
			// piše u posebnom
			// try-catch bloku.
			if (dataDat != null) {
				try {
					dataDat.close();
				} catch (IOException e) {
					System.out.println("Greška pri zatvaranju: " + e.toString());
				}
			}
		}
	}

	// ---------------- UPIS U BINARNU DATOTEKU --------------------
	public void write(String fileName) {
		FileOutputStream dat;
		BufferedOutputStream bDat;
		DataOutputStream dataDat = null;
		try {
			dat = new FileOutputStream(fileName);
			bDat = new BufferedOutputStream(dat);
			dataDat = new DataOutputStream(bDat);

			dataDat.writeInt(dim); // upisuje prvo dimenziju vektora

			for (int i = 0; i < dim; i++) {
				dataDat.writeFloat(niz[i]); // upis u faj, broj po broj
			}
		} catch (IOException e) {
			System.out.println("Greska: " + e.toString());
		} finally {
			// Da bi se objekat dataDat sigurno zatvorio, ispravno je da se to
			// zatvaranje odradi u
			// finally bloku koji se izvršava svakako, čak i ako dođe do
			// izuzetka u prethodnom
			// try bloku.
			// Ovo zatvaranje može takođe da dovede do izuzetka pa mora da se
			// piše u posebnom
			// try-catch bloku.
			if (dataDat != null) {
				try {
					dataDat.close();
				} catch (IOException e) {
					System.out.println("Greška pri zatvaranju: " + e.toString());
				}
			}
		}
	}

	public void sort() {
		for (int i = 0; i < dim - 1; i++) {
			int indexMinimalnog = i;

			for (int j = i + 1; j < dim; j++) {
				if (niz[j] < niz[indexMinimalnog])
					indexMinimalnog = j;
			}
			float pom = niz[indexMinimalnog];
			niz[indexMinimalnog] = niz[i];
			niz[i] = pom;
		}
	}

	// Opciono - jedan metod koji štampa vektor na ekran, ako zatreba:
	public void stampajVektor() {
		for (int i = 0; i < dim; i++)
			System.out.println(niz[i]);
	}
}