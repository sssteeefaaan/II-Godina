import java.io.*;

class Glavna {
	
	public static void main (String args[])
	{
		int test = 0;
		// Kreiramo objekat klase InputStreamReader koji predstavlja tastaturu:
		InputStreamReader tastatura = new InputStreamReader(System.in);
		
		// Kreiramo bafer za ulazni tok, i dodeljujemo mu predstavnika tastature:
		BufferedReader br = new BufferedReader(tastatura);
		
		// Pripremamo promenljivu tipa String da prihvati ono sto otkucamo:
		String red_teksta=null;
		// Moramo da je inicijalizujemo necim (recimo sa null), zato sto
		// se moze desiti da tastatura otkaze i da se promenljivoj nista
		// ne dodeli, pa bi ona ostala neinicijalizovana, sto nije dobra
		// praksa.
		
		// Citanje sa tastature je kriticna operacija (ako bi neko iscupao
		// tastaturu u ovom trenutku, program bi mogao da se blokira), zato
		// taj deo ide u try blok (kao i zatvaranje toka):
		try
		{
			red_teksta = br.readLine();	// Funkcija ucitava dok ne pritisnemo Enter.
			// test = System.in.read();
			br.close();	// Zatvaramo tok (oslobadjamo tastaturu) jer nam ne treba vise.

		}
		catch (IOException izuzetak)
		{
			System.out.println(izuzetak);
		}
		
		// Na kraju odstampamo to sto smo uneli sa tastature, radi potvrde:
		System.out.println("Ukucali ste: \"" + red_teksta + "\""+test);
	}
}
// NAPOMENA: Pri startovanju programa ukljuciti konzolu (da bude vidljiva).
// Window -> Show View -> Console
// Nakon samog startovanja programa kliknuti misem na povrsinu konzole da bi
// dosla u fokus, i onda kucati proizvoljan tekst, potom pritisnuti Enter.
