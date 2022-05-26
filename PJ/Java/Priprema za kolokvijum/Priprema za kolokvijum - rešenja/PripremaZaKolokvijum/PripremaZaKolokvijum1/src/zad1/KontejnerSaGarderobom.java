package zad1;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;

public class KontejnerSaGarderobom extends Kontejner {
    private String zemljaPorekla;

    KontejnerSaGarderobom() {}

    @Override
    void sacuvajKontejner(BufferedWriter b) throws IOException {
        super.sacuvajKontejner(b);
        b.write(zemljaPorekla);
        b.newLine();
    }

    KontejnerSaGarderobom(String ID, String ime, int tezina, String zemljaPorekla) {
        super(ID, ime, tezina, 4, 1, "G");
        this.zemljaPorekla = zemljaPorekla;
    }
}
