package ulazizlaz;

import java.io.*;

public class TypeReader extends BufferedReader {

	int max; // broj podataka u učitanom redu
	int current; // redni broj podatka u učitanom redu koji
				 // ce sledeći biti isporučen
	String line[];

	public TypeReader(Reader s) {
		super(s);
	}

	// ----- funkcija koja učitava liniju iz ulaznog toka -----
	private void nextLine() {
		try {
			String s;
			s = readLine(); // readLine je metod klase Reader
			line = s.split(" "); // <---- LOOK AT THIS
			max = line.length;
			current = 0;
		} catch (IOException e) {
			System.out.println(e.toString());
		}
	}

	public float readFloat() {
		if (current == max)
			nextLine();
		return new Float(line[current++]).floatValue();
	}

	public double readDouble() {
		if (current == max)
			nextLine();
		return new Double(line[current++]).floatValue();
	}

	public int readInt() {
		if (current == max)
			nextLine();
		return new Integer(line[current++]).intValue();
	}

}