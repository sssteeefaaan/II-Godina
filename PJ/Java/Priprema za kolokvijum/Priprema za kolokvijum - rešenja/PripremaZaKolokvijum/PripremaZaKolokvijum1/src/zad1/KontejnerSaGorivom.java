package zad1;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;

public class KontejnerSaGorivom extends Kontejner {
    private String tip;

    KontejnerSaGorivom() {}

    @Override
    void sacuvajKontejner(BufferedWriter b) throws IOException {
        super.sacuvajKontejner(b);
        b.write(tip);
        b.newLine();
    }

    KontejnerSaGorivom(String ID, String ime, int tezina, String tip) {
        super(ID, ime, tezina, 1, 6, "F");
        this.tip = tip;
    }
}
