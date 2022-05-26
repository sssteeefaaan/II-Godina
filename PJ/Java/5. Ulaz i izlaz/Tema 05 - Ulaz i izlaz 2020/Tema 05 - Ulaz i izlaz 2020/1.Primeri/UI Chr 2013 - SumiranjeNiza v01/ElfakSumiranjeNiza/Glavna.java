import java.io.*;

public class Glavna {

	public static void main(String[] args) {
		try
		{
			ulazizlaz.TypeReader r = new ulazizlaz.TypeReader(new InputStreamReader(System.in));
			ulazizlaz.TypeReader r2 = new ulazizlaz.TypeReader(new FileReader("FNiz.txt"));
			
			int nd = r.readInt();
			int i;
			double[] nizd = new double [nd];
			
			for (i=0; i<nd; i++)
				nizd[i]=r.readDouble();
			
			int nf=r2.readInt();
			float[] nizf = new float[nf];
			
			for (i=0; i<nf; i++)
				nizf[i]=r2.readFloat();
			
			double sd;
			float sf;
			for (sd=0, i=0; i<nd; sd += nizd[i++]);	// sumiranje Doubleova
			for (sf=0, i=0; i<nf; sf += nizf[i++]);	// sumiranje Floatova
			
			System.out.println("Suma elemenata niza ucitanog sa std. ulaza je: "+sd);
			System.out.println("Suma el.niza ucitanog iz datoteke je "+sf);
			
			r.close();
			r2.close();
		}
		catch (IOException ex)
		{
			System.out.println(ex.toString());
			
		}
	}
}