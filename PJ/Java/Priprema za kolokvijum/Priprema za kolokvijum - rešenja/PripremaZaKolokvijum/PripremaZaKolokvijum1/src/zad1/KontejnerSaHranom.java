package zad1;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;

public class KontejnerSaHranom extends Kontejner {
    private String datumIsteka;

    KontejnerSaHranom() {}

    @Override
    void sacuvajKontejner(BufferedWriter b) throws IOException {
        super.sacuvajKontejner(b);
        b.write(datumIsteka);
        b.newLine();
    }

    KontejnerSaHranom(String ID, String ime, int tezina, String datumIsteka) {
        super(ID, ime, tezina, 2, 2, "H");
        this.datumIsteka = datumIsteka;
    }
}
