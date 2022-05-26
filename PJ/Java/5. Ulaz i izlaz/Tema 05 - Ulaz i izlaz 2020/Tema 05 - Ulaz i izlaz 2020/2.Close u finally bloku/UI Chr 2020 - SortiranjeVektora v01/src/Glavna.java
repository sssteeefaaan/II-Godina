
public class Glavna {

	public static void main(String[] args) {
		
//		System.out.println("Pocetak main metoda!"); // kontrolni red

		nizovi.Vektor v1;
		nizovi.Vektor v2;
		v1 = new nizovi.Vektor();
		v2 = new nizovi.Vektor();
		
		v1.citajIzTekstualne("Neuredjen.txt");
		
//		System.out.println("Ucitao sam iz \"Neuredjen.txt\"");	// kontrolni red
//		v1.stampajVektor();										// kontrolni red
		
		v1.sort();
//		System.out.println("Sortirao sam.");					// kontrolni red
//		v1.stampajVektor();										// kontrolni red
		v1.write("Uredjen.dat");
//		System.out.println("Upisao sam u \"Uredjen.dat\"");		// kontrolni red

		v2.read("Uredjen.dat");
//		System.out.println("Ucitao sam iz \"Uredjen.dat\"");	// kontrolni red
//		v2.stampajVektor();										// kontrolni red
		v2.writeText("Uredjen.txt");
//		System.out.println("Upisao sam u \"Uredjen.txt\"");		// kontrolni red

	}
}
