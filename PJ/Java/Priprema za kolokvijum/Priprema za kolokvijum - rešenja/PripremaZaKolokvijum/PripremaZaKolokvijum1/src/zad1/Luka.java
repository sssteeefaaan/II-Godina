package zad1;

import java.io.*;
import java.util.ArrayList;
import java.util.List;

public class Luka {
    private List<IBrod> brodovi;

    Luka() {
        this.brodovi = new ArrayList<>();
    }

    public void dodajBrod(IBrod b) {
        this.brodovi.add(b);
    }

    public void obrisiBrod(IBrod b) {
        this.brodovi.remove(b);
    }

    public void dodajKontejner(Kontejner k) throws NoShips {
        if (brodovi.isEmpty())
            throw new NoShips("Nema brodova u luci!");
        brodovi.sort(null);
        IBrod prvi = brodovi.get(0);
        try {
            prvi.dodajKontejner(k);
        }
        catch (NoMorePlacesAvailable e) {
            System.out.println(e.getMessage());
        }
        catch (TooHeavy e) {
            System.out.println(e.getMessage());
        }
    }

    public void obrisiKontejner(String ID) {
        for (IBrod b: brodovi) {
            if(b.sadrziKontejner(ID))
                b.obrisiKontejner(ID);
        }
    }

    public void prikaziBrodove() {
        int redni = 1;
        for (IBrod b: brodovi) {
            System.out.println(redni);
            System.out.println(b.getMaksimalanKapacitet() - b.getTekucaZauzetost());
            System.out.println();
            b.prikaziBrod();
            redni++;
            System.out.println();
        }
        System.out.println();
        System.out.println("*******************************");
        System.out.println();
    }

    public void sacuvajLuku(String fileName) {
        try(FileWriter f = new FileWriter(fileName);
            BufferedWriter b = new BufferedWriter(f);) {
            b.write(String.valueOf(brodovi.size()));
            b.newLine();
            for(IBrod brod: brodovi) {
                brod.sacuvajBrod(b);
            }
        }
        catch(IOException e) {
            System.out.println("Greska pri radu sa fajlom!");
        }
        catch(Exception e) {
            System.out.println("Upss! Doslo je do greske!");
        }
    }

    public void procitajLuku(String fileName) {
        try(FileReader f = new FileReader(fileName);
        BufferedReader b = new BufferedReader(f)) {
            int brojBrodova = Integer.parseInt(b.readLine());
            for(int i=0; i< brojBrodova; i++) {
                IBrod brod = new Brod();
                brod.procitajBrod(b);
                brodovi.add(brod);
            }
        }
        catch(IOException e) {
            System.out.println("Greska pri radu sa fajlom!");
        }
        catch(Exception e) {
            System.out.println("Upss! Doslo je do greske!");
        }
    }

}
