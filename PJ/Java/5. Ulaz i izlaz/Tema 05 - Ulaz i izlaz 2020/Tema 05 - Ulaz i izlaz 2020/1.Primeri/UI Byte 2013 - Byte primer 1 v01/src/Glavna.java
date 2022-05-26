import java.io.*;

public class Glavna {
	
	public static void main (String args[])
	
	{
	
	byte niz[] = new byte[2];
	niz[0] = 10;
	niz[1] = 20;
	
	try
		{
			FileOutputStream fos = new FileOutputStream("za_citanje.bin");
			BufferedOutputStream bos = new BufferedOutputStream(fos);
			
			bos.write(1);
			
			bos.write(niz);
			
			bos.close();
			
		}

		catch (IOException ioe_pis)
		{
			System.out.println("Greska pri upisu: "+ioe_pis);
		}
		
		try
		{
			FileInputStream fis = new FileInputStream("za_citanje.bin");
			BufferedInputStream bis = new BufferedInputStream(fis);
			
			int temp;
			while ((temp = bis.read()) != -1)
			{
			System.out.println(temp);
			}

// 			Metod read vraca vrednost -1 kada nema vise sta da se cita iz fajla.
			
/*			System.out.println(bis.read());  // treba da vrati -1
			System.out.println(bis.read());  // treba da vrati -1
			System.out.println(bis.read());  // treba da vrati -1
*/
			bis.close();
		}
		catch (IOException ioe_cit)
		{
			System.out.println("Greska pri citanju: "+ioe_cit);
		}
	}
}
