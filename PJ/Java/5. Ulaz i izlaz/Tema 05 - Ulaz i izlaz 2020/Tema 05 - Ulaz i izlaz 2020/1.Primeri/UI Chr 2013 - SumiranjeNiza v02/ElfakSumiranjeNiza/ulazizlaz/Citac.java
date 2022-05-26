package ulazizlaz;
import java.io.*;

public class Citac extends BufferedReader {

	int max;		// broj podataka u ucitanom redu
	int current;	// redni broj podatka u ucitanom redu koji
					// ce sledeci biti isporucen
	
	String linijaRazbijenaNaNiz[];
	
	public Citac(Reader s)
	{
		super(s);
	}
	
// pojasnjenje konstruktora: argument s je tipa FileReader, znaci taj objekat
// biva dodeljen kao argument konstruktoru klase BufferedReader (to je superklasa,
// znaci super(s) prosledjuje objekat klase FileReader konstruktoru klase
// BufferedReader... kao da smo napisali:
// BufferedReader nesto = new BufferedReader(s)
// gde je s u stvari new FileReader("imeFajla") - a tako i jeste u main metodu
	
// ----- privatna funkcija koja ucitava liniju iz ulaznog toka, za lokalne potrebe ovde -----
	
	private void ucitajLiniju()
	{
		try
		{
			String s;
			s = readLine();						// readLine je metod klase Reader
			linijaRazbijenaNaNiz=s.split(" ");	// split razbija jednu liniju na pojedinacne podstringove
												// (kao argument mu dajemo delimiter, znak koji oznacava
												// razmak - to najcesce bude space, ili zarez, ili tab, ali
												// moze biti stagod izaberemo)
			
			max = linijaRazbijenaNaNiz.length;	// length je javni atribut koji sadrzi duzinu
			current = 0;						// niza (broj elemenata)
		}
		catch (IOException e)
		{
			System.out.println(e.toString());
		}
	}

	public float citajFloat()
	{
		if (current==max) ucitajLiniju();
		//Float pom = new Float(linijaRazbijenaNaNiz[current++]);
		//float konacanBroj = pom.floatValue();
		//return konacanBroj;
		return new Float (linijaRazbijenaNaNiz[current++]).floatValue();
		
	}
	
	public double citajDouble()
	{
		if (current==max) ucitajLiniju();
		return new Double (linijaRazbijenaNaNiz[current++]).doubleValue();
	}

	
	public int citajInt()
	{
		if (current==max) ucitajLiniju();
		return new Integer(linijaRazbijenaNaNiz[current++]).intValue();
	}
	
}