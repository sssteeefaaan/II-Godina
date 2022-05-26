package zad1;

public class Main {

    public static void main(String[] args) {
        
        try {
        	Luka luka = new Luka();
            IBrod b1 = new Brod(10, 10, 2000);
            IBrod b2 = new Brod(10, 10, 1000);
            IBrod b3 = new Brod(5, 5, 500);
            luka.dodajBrod(b1);
            luka.dodajBrod(b2);
            luka.dodajBrod(b3);
            KontejnerSaHranom k1 = new KontejnerSaHranom("1", "Kontejner1", 1000, "20.04.2020.");
            KontejnerSaGarderobom k2 = new KontejnerSaGarderobom("2", "Kontejner2", 300, "Srbija");
            KontejnerSaGorivom k3 = new KontejnerSaGorivom("3", "Kontejner3", 500, "dizel");
            KontejnerSaHranom k4 = new KontejnerSaHranom("4", "Kontejner4", 900, "08.04.2020.");
            KontejnerSaGarderobom k5 = new KontejnerSaGarderobom("5", "Kontejner5", 700, "Kina");
            KontejnerSaGorivom k6 = new KontejnerSaGorivom("6", "Kontejner6", 100, "dizel");
            KontejnerSaHranom k7 = new KontejnerSaHranom("7", "Kontejner7", 200, "16.04.2020.");
            KontejnerSaGarderobom k8 = new KontejnerSaGarderobom("8", "Kontejner8", 100, "Engleska");
            KontejnerSaGorivom k9 = new KontejnerSaGorivom("9", "Kontejner9", 200, "dizel");
            
            luka.dodajKontejner(k1);
            luka.prikaziBrodove();
            luka.dodajKontejner(k2);
            luka.prikaziBrodove();
            luka.dodajKontejner(k3);
            luka.prikaziBrodove();
            luka.dodajKontejner(k4);
            luka.prikaziBrodove();
            luka.dodajKontejner(k5);
            luka.prikaziBrodove();
            luka.dodajKontejner(k6);
            luka.prikaziBrodove();
            luka.dodajKontejner(k7);
            luka.prikaziBrodove();
            luka.dodajKontejner(k8);
            luka.prikaziBrodove();
            luka.dodajKontejner(k9);
            luka.prikaziBrodove();
            luka.obrisiKontejner("8");
            luka.prikaziBrodove();
            luka.sacuvajLuku("luka.txt");
            Luka novaLuka = new Luka();
            novaLuka.procitajLuku("luka.txt");
            System.out.println("Prikaz broda nakon citanja iz fajla!");
            novaLuka.prikaziBrodove();
        }
        catch (NoShips e) {
            System.out.println(e.getMessage());
        }
        catch(Exception e) {
            System.out.println("Upss! Doslo je do greske!");
        }
    }
}
