package zad2;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class Vlasnik {
    private String JMBG;
    private String ime;
    private String prezime;
    List<Parcela> parcele;

    Vlasnik() {
        this.parcele = new ArrayList<>();
    }

    Vlasnik(String JMBG, String ime, String prezime) {
        this.JMBG = JMBG;
        this.ime = ime;
        this.prezime = prezime;
        this.parcele = new ArrayList<>();
    }

    public void dodajParcelu(Parcela p) {
        this.parcele.add(p);
    }

    public void obrisiParcelu(String ID) {
        for(Parcela p: parcele) {
            if (p.ID.compareTo(ID) == 0) {
                parcele.remove(p);
                break;
            }
        }
    }

    public void sacuvajVlasnika(DataOutputStream d) throws IOException {
        d.writeUTF(JMBG);
        d.writeUTF(ime);
        d.writeUTF(prezime);
        d.writeInt(parcele.size());
        for(Parcela p: parcele) {
            p.sacuvajParcelu(d);
        }
    }

    public void procitajVlasnika(DataInputStream d) throws IOException, JMBGNevalidan, KlasaZemljistaNevalidna, VrstaParceleNevalidna {
        JMBG = d.readUTF();
        if(JMBG.length() != 13)
            throw new JMBGNevalidan();
        ime = d.readUTF();
        prezime = d.readUTF();
        int brojParcela = d.readInt();
        for(int i=0; i<brojParcela;i++) {
            String tip = d.readUTF();
            if (tip.compareTo("obradiva") == 0) {
                String ID = d.readUTF();
                int povrsina = d.readInt();
                int klasaZemljista = d.readInt();
                if(klasaZemljista > 3 || klasaZemljista < 1)
                    throw new KlasaZemljistaNevalidna();
                Parcela p = new ObradivaParcela(ID, povrsina, klasaZemljista);
                parcele.add(p);
            } else if(tip.compareTo("neobradiva") == 0) {
                String ID = d.readUTF();
                int povrsina = d.readInt();
                Parcela p = new NeobradivaParcela(ID, povrsina);
                parcele.add(p);
            } else if(tip.compareTo("plac") == 0) {
                String ID = d.readUTF();
                int povrsina = d.readInt();
                int povrsinaObjekta = d.readInt();
                Parcela p = new Plac(ID, povrsina, povrsinaObjekta);
                parcele.add(p);
            } else
                throw new VrstaParceleNevalidna();
        }
    }

    public String getJMBG() {
        return JMBG;
    }

    public void prikaziVlasnika() {
        System.out.println(JMBG + " " + ime + " " + prezime);
        for(Parcela p: parcele) {
            System.out.println(p.toString());
        }
    }

    public int izracunajPorez() {
        int porez = 0;
        for(Parcela p: parcele) {
            porez += p.racunajPorez();
        }
        return porez;
    }
}
