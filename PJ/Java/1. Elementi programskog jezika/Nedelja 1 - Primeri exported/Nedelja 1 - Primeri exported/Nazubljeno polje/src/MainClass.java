
public class MainClass {

	public static void main(String[] args)
	{
		int [][]matrica = new int[5][];
		
		for (int i=0; i<matrica.length; i++)
		{
			matrica[i] = new int[i+1];
			System.out.println("Red "+(i+1)+" imaće dužinu: "+(i+1));
			
			for (int j=0; j<matrica[i].length; j++)
			{
				matrica[i][j] = 1;
			}
		}
	}

}
