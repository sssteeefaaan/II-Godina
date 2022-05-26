package zad2;

import java.io.IOException;

public class Main {
    public static void main(String[] args) {    
        try {
        	Katastar k = new Katastar();
            Parcela p1 = new ObradivaParcela("1", 23, 1);
            Parcela p2 = new NeobradivaParcela("2", 24);
            Parcela p3 = new Plac("3", 42, 150);
            Parcela p4 = new ObradivaParcela("4", 35, 2);
            Parcela p5 = new NeobradivaParcela("5", 78);
            Parcela p6 = new ObradivaParcela("6", 22, 3);
            Parcela p7 = new Plac("7", 36, 100);

            String jmbg1 = "1234567890123";
            String jmbg2 = "1234567890124";
            String jmbg3 = "1234567890125";
            k.dodajVlasnika(jmbg1, "Mirko", "Mirkovic");
            k.dodajVlasnika(jmbg2, "Slavko", "Slavkovic");
            k.dodajVlasnika(jmbg3, "Dragan", "Draganic");
            k.dodajParceluVlasniku(jmbg1, p1);
            k.dodajParceluVlasniku(jmbg1, p4);
            k.dodajParceluVlasniku(jmbg2, p5);
            k.dodajParceluVlasniku(jmbg2, p7);
            k.dodajParceluVlasniku(jmbg3, p6);
            k.dodajParceluVlasniku(jmbg3, p3);
            k.dodajParceluVlasniku(jmbg2, p2);
            k.prikaziKatastar();
            int porez = k.izracunajPorezZaVlasnika(jmbg1);
            System.out.println("Porez za prvog vlasnika je: " + porez);
            k.promeniVlasnika(p2, jmbg2, jmbg1);
            k.prikaziKatastar();
            porez = k.izracunajPorezZaVlasnika(jmbg1);
            System.out.println("Porez za prvog vlasnika posle prebacivanja parcele je: " + porez);
            
            k.sacuvajKatastar("katastar.bin");
            Katastar noviKatastar = new Katastar();
            noviKatastar.ucitajKatastar("katastar.bin");
            System.out.println();
            System.out.println("Prikaz katastra nakon ucitavanja!");
            noviKatastar.prikaziKatastar();
        }
        catch(VrstaParceleNevalidna e) {
            System.out.println(e.getMessage());
        }
        catch (JMBGNevalidan e) {
            System.out.println(e.getMessage());
        }
        catch (KlasaZemljistaNevalidna e) {
            System.out.println(e.getMessage());
        }
        catch (IOException e) {
            System.out.println("Doslo je do greske pri radu sa fajlom!");
        }
        catch(Exception e) {
        	System.out.println("Upss! Doslo je do greske!");
        }
    }
}
