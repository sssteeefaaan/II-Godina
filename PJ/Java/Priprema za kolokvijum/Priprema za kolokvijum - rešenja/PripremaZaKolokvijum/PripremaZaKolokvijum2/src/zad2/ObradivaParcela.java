package zad2;

import java.io.DataOutputStream;
import java.io.IOException;

public class ObradivaParcela extends Parcela {
    private int klasaZemljista;

    ObradivaParcela(String ID, int povrsina, int klasaZemljista) {
        super(ID, povrsina);
        this.klasaZemljista = klasaZemljista;
    }

    @Override
    int racunajPorez() {
        return povrsina*10*(5-klasaZemljista);
    }

    @Override
    void sacuvajParcelu(DataOutputStream d) throws IOException {
        d.writeUTF("obradiva");
        super.sacuvajParcelu(d);
        d.writeInt(klasaZemljista);
    }

    @Override
    public String toString() {
        return super.toString() + " " + klasaZemljista;
    }
}
