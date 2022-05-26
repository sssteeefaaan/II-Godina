package zad2;

import com.sun.xml.internal.ws.policy.privateutil.PolicyUtils;

import java.io.*;
import java.util.ArrayList;
import java.util.List;

public class Katastar {
    List<Vlasnik> vlasnici;

    Katastar() {
        vlasnici = new ArrayList<>();
    }

    public void dodajVlasnika(String JMBG, String ime, String prezime) {
        Vlasnik v = new Vlasnik(JMBG, ime, prezime);
        vlasnici.add(v);
    }

    public void dodajParceluVlasniku(String JMBG, Parcela p) {
        for(Vlasnik v: vlasnici) {
            if (v.getJMBG().compareTo(JMBG) == 0)
            {
                v.dodajParcelu(p);
                break;
            }
        }
    }

    public void promeniVlasnika(Parcela p, String v1, String v2) {
        for(Vlasnik v: vlasnici) {
            if (v.getJMBG().compareTo(v1) == 0) {
            	v.obrisiParcelu(p.ID);
            }
            if (v.getJMBG().compareTo(v2) == 0) {
                v.dodajParcelu(p);
            }
        }
    }

    public void prikaziKatastar() {
        for(Vlasnik v: vlasnici) {
            System.out.println();
            v.prikaziVlasnika();
            System.out.println();
        }
    }

    public void sacuvajKatastar(String fileName) throws IOException {
        FileOutputStream f = new FileOutputStream(fileName);
        BufferedOutputStream b = new BufferedOutputStream(f);
        DataOutputStream d = new DataOutputStream(b);
        d.writeInt(vlasnici.size());
        for(Vlasnik v: vlasnici) {
            v.sacuvajVlasnika(d);
        }
        d.close();
        b.close();
        f.close();
    }

    public void ucitajKatastar(String fileName) throws IOException, KlasaZemljistaNevalidna, VrstaParceleNevalidna, JMBGNevalidan {
        FileInputStream f = new FileInputStream (fileName);
        BufferedInputStream b = new BufferedInputStream(f);
        DataInputStream d = new DataInputStream(b);
        int brojVlasnika = d.readInt();
        for(int i=0; i<brojVlasnika; i++) {
            Vlasnik v = new Vlasnik();
            v.procitajVlasnika(d);
            vlasnici.add(v);
        }
        d.close();
        b.close();
        f.close();
    }

    public int izracunajPorezZaVlasnika(String JMBG) {
        for(Vlasnik v: vlasnici)
            if(v.getJMBG().compareTo(JMBG) == 0)
                return v.izracunajPorez();
        return 0;
    }
}
