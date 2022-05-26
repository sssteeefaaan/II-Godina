// Recimo da smo zapis vektora u datoteci osmislili na sledeci nacin.
// Prvi podatak je tipa int i oznacava dimenziju (broj elemenata) vektora.
// U sledecem redu je podatak tipa float, to je prvi elemenat vektora.
// U svakom sledecem redu je sledeci float element vektora, i tako do kraja.
// Znaci jedan red u fajlu - jedan podatak.
// To smo mi tako odlucili. Ne mora uvek da bude tako.
// Vektor se moze upisati u fajl i na neki drugi nacin, bitno je samo da
// tacno znamo kako smo osmislili taj nacin i da ga ispostujemo u programu.

package nizovi;
import java.io.*;

public class Vektor {
	
	private int dim;
	private float [] niz;
	
// ------------- CITANJE CELOG VEKTORA IZ TEKSTUALNE DATOTEKE ----------------
	public void citajIzTekstualne (String imeDatoteke)
	{
		FileReader dat;		// datoteku za upis reprezentuje objekat FileReader
		try					// ucitavanje je kriticno i ide u try bloku
		{
			dat = new FileReader(imeDatoteke);	// ime datoteke stize kao argument
			BufferedReader bDat;				// ovog metoda
			bDat = new BufferedReader (dat);
			
			String pom;
			pom = bDat.readLine();	// ucitava jednu liniju iz tekstualne datoteke
									// (u tom redu treba da pise dimenzija vektora
									// koji treba da bude ucitan iz datoteke)...
									// to smo mi tako odlucili.
			
//			System.out.println("Ucitao duzinu vektora: " + pom); // kontrolni red
			
			// ono sto je ucitano iz datoteke (prvi red u njoj) je dimenzija vektora
			// koji treba da bude ucitan... ali to sto je ucitano je tipa String,
			// jer je datoteka tekstualna. Prvo sto treba da uradimo je da taj
			// podatak prevedemo u tip int, a za to ce nam pomoci metod parseInt
			// iz wrapper klase Integer (videti odgovarajuce slajdove, tematska
			// celina 2 - Klase u Javi).
			dim = Integer.parseInt(pom, 10);	// drugi argument je osnova
												// brojnog sistema koji nam treba
			
			// sada kada imamo dimenziju, ucitavamo odgovarajuci broj redova iz
			// datoteke, svaki pretvaramo u float i upisujemo u niz:
			niz = new float[dim];
			for (int i=0; i<dim; i++){
				pom = bDat.readLine();
				float fpom = Float.parseFloat(pom);
				niz[i] = fpom;
			}
			bDat.close();
		}
		catch(IOException e)
		{
			System.out.println("Greska: "+e.toString());
		}
	}
	
// ------------ UPIS U TEKSTUALNU DATOTEKU ------------------
	public void writeText(String fileName)
	{
		FileWriter dat;		//datoteku za citanje reprezentuje objekat klase FileWriter
		try
		{
			dat = new FileWriter(fileName);	
			BufferedWriter bDat;			
			bDat = new BufferedWriter(dat);
			
			// sada treba da upisemo dimenziju u prvi red fajla... ali dimenzija je int,
			// a u fajl treba da upisemo tekst, znaci tip String. Moramo da konvertujemo
			// int u String. Za to nam sluzi metod valueOf klase String:
			String pomstr = new String();
			pomstr = String.valueOf(dim);
			bDat.write(pomstr);	// sada dimenziju konvertovanu u String upisujemo
			bDat.newLine();		// i prelazimo u novi red u fajlu
			
			for (int i=0; i<dim; i++)	// sada pomocu petlje upisujemo ceo vektor, red po red
			{
				bDat.write(String.valueOf(niz[i]));	// upisuje element vektora pretvoren u String
//				System.out.println("Upisao sam u "+fileName+": "+String.valueOf(niz[i]));  // kontrolni red
				bDat.newLine();						// nov red
			}
			bDat.close();
		}
			
			catch (IOException e)
			{
				System.out.println("Greska: "+e.toString());
			}
		}

//----------- CITANJE IZ BINARNE DATOTEKE ---------------
	public void read (String fileName)
	{
		FileInputStream dat;
		try // try this, muthafucka
		{
			dat = new FileInputStream (fileName);
			BufferedInputStream bDat;
			bDat = new BufferedInputStream(dat);
			
			DataInputStream dataDat;
			dataDat = new DataInputStream(bDat);
			
			dim = dataDat.readInt();
			niz = new float[dim];
			
			for (int i=0; i<dim; i++)
				niz[i] = dataDat.readFloat();
			
			dataDat.close();
		}
		catch (IOException e)
		{
			System.out.println("Greska: "+e.toString());
		}
	}
	
// ---------------- UPIS U BINARNU DATOTEKU --------------------
	public void write (String fileName)
	{
		FileOutputStream dat;
		try
		{
			dat = new FileOutputStream(fileName);
			
			BufferedOutputStream bDat;
			bDat = new BufferedOutputStream(dat);
			
			DataOutputStream dataDat;
			dataDat = new DataOutputStream(bDat);
			
			dataDat.writeInt(dim);	// upisuje prvo dimenziju vektora
			
			for (int i=0; i<dim; i++)
			{
				dataDat.writeFloat(niz[i]);	// upis u faj, broj po broj
			}
			
			dataDat.close();
		}
		catch (IOException e)
		{
			System.out.println("Greska: " + e.toString());
		}
	}

	public void sort()
	{
		for (int i=0; i<dim-1; i++)
		{
			int indexMinimalnog = i;
			
			for (int j=i+1; j<dim; j++)
			{
				if (niz[j]<niz[indexMinimalnog]) indexMinimalnog = j;
			}
				float pom = niz[indexMinimalnog];
				niz [indexMinimalnog] = niz [i];
				niz[i] = pom;
		}
	}
	
	// Opciono - jedan metod koji stampa vektor na ekran, ako zatreba:
	public void stampajVektor()
	{
		for (int i=0; i<dim; i++)
			System.out.println(niz[i]);
	}
}