package zad1;

import java.io.BufferedWriter;
import java.io.IOException;

public abstract class Kontejner {
    protected String ID;
    protected String ime;
    protected int tezina;
    protected int redovi;
    protected int kolone;
    protected String oznaka;

    Kontejner() { tezina = 0; redovi = 0; kolone = 0; }

    Kontejner(String ID, String ime, int tezina, int redovi, int kolone, String oznaka) {
        this.ID = ID;
        this.ime = ime;
        this.tezina = tezina;
        this.redovi = redovi;
        this.kolone = kolone;
        this.oznaka = oznaka;
    }

    String getID() {
        return this.ID;
    }

    int getTezina() {
        return this.tezina;
    }

    String getOznaka() {
        return this.oznaka;
    }

    void sacuvajKontejner(BufferedWriter b) throws IOException {
        b.write(oznaka);
        b.newLine();
        b.write(ID);
        b.newLine();
        b.write(ime);
        b.newLine();
        b.write(String.valueOf(tezina));
        b.newLine();
        b.write(String.valueOf(redovi));
        b.newLine();
        b.write(String.valueOf(kolone));
        b.newLine();
    }
}
