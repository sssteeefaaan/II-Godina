package zad2;

import java.io.DataOutputStream;
import java.io.IOException;

public class Plac extends Parcela{
    private int povrsinaObjekta;

    Plac(String ID, int povrsina, int povrsinaObjekta) {
        super(ID, povrsina);
        this.povrsinaObjekta = povrsinaObjekta;
    }

    @Override
    int racunajPorez() {
        return 50*povrsina + 100*povrsinaObjekta;
    }

    @Override
    void sacuvajParcelu(DataOutputStream d) throws IOException {
        d.writeUTF("plac");
        super.sacuvajParcelu(d);
        d.writeInt(povrsinaObjekta);
    }

    @Override
    public String toString() {
        return super.toString() + " " + povrsinaObjekta;
    }
}
