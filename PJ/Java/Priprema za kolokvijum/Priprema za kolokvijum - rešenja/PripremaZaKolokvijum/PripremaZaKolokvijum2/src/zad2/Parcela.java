package zad2;

import java.io.DataOutputStream;
import java.io.IOException;

public abstract class Parcela {
    protected String ID;
    protected int povrsina;

    Parcela(String ID, int povrsina) {
        this.ID = ID;
        this.povrsina = povrsina;
    }

    abstract int racunajPorez();

    void sacuvajParcelu(DataOutputStream d) throws IOException {
        d.writeUTF(ID);
        d.writeInt(povrsina);
    }

    @Override
    public String toString() {
        return ID + " " + povrsina;
    }
}
