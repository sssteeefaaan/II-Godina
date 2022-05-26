package zad2;

import java.io.DataOutputStream;
import java.io.IOException;

public class NeobradivaParcela extends Parcela {

    NeobradivaParcela(String ID, int povrsina) {
        super(ID, povrsina);
    }

    @Override
    int racunajPorez() {
        return povrsina * 10;
    }

    @Override
    void sacuvajParcelu(DataOutputStream d) throws IOException {
        d.writeUTF("neobradiva");
        super.sacuvajParcelu(d);
    }
}