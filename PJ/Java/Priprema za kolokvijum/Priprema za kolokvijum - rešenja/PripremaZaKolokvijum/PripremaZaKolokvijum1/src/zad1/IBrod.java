package zad1;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;

public interface IBrod {
    void prikaziBrod();
    void dodajKontejner(Kontejner k) throws NoMorePlacesAvailable, TooHeavy;
    void obrisiKontejner(String ID);
    boolean sadrziKontejner(String ID);
    void sacuvajBrod(BufferedWriter b) throws IOException;
    void procitajBrod(BufferedReader b) throws IOException;
    int getMaksimalanKapacitet();
    int getTekucaZauzetost();
}
