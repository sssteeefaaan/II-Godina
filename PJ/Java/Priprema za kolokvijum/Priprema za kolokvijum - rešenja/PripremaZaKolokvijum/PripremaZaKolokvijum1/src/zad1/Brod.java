package zad1;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;

public class Brod implements IBrod, Comparable<Brod> {
    int maksimalanKapacitet;
    int tekucaZauzetost;
    Kontejner[][] kontejneri;
    int n;
    int m;

    Brod() {
        n = 10;
        m = 10;
        tekucaZauzetost = 0;
        maksimalanKapacitet = 1000;
        kontejneri = new Kontejner[n][m];
    }

    Brod(int n, int m, int max) {
        this.n = n;
        this.m = m;
        tekucaZauzetost = 0;
        maksimalanKapacitet = max;
        kontejneri = new Kontejner[n][m];
    }

    @Override
    public void prikaziBrod() {
        for(int i=0; i<n; i++) {
            for(int j=0; j<m; j++) {
                if(kontejneri[i][j] != null) {
                    System.out.print(kontejneri[i][j].getOznaka() + " ");
                } else {
                    System.out.print("* ");
                }
            }
            System.out.println();
        }
    }

    @Override
    public void dodajKontejner(Kontejner k) throws NoMorePlacesAvailable, TooHeavy {
        if(this.tekucaZauzetost + k.getTezina() > this.maksimalanKapacitet)
            throw new TooHeavy("Kontejner je pretezak!");
        boolean uspesnoDodavanje = false;
        for(int i=0; i<n; i++) {
            for(int j=0; j<m; j++) {
                if(kontejneri[i][j] == null) {
                    int kdesno = k.redovi;
                    int kdole = k.kolone;
                    boolean slobodno = true;
                    if (i + kdesno >= n || j + kdole >= m)
                        break;
                    for(int p = i; p < i + kdesno; p++) {
                        for(int q = j; q < j + kdole; q++) {
                            if (kontejneri[p][q] != null) {
                                slobodno = false;
                                break;
                            }
                        }
                        if (!slobodno)
                            break;
                    }
                    if(slobodno) {
                        for(int p = i; p < i + kdesno; p++) {
                            for(int q = j; q < j + kdole; q++) {
                                kontejneri[p][q] = k;
                            }
                        }
                        uspesnoDodavanje = true;
                        break;
                    }
                }
            }
            if(uspesnoDodavanje)
                break;
        }
        if(!uspesnoDodavanje)
            throw new NoMorePlacesAvailable("Nema vise mesta na brodu za kontejner!");
        else {
            this.tekucaZauzetost += k.getTezina();
        }
    }

    @Override
    public void obrisiKontejner(String ID) {
        int tezina = 0;
        for(int i=0; i<n; i++) {
            for(int j=0; j<m; j++) {
                if(kontejneri[i][j] != null && kontejneri[i][j].getID().compareTo(ID) == 0) {
                    tezina = kontejneri[i][j].getTezina();
                    kontejneri[i][j] = null;
                }
            }
        }
        this.tekucaZauzetost -= tezina;
    }

    @Override
    public boolean sadrziKontejner(String ID) {
        for(int i=0; i<n; i++) {
            for(int j=0; j<m; j++) {
                if(kontejneri[i][j] != null && kontejneri[i][j].getID().compareTo(ID) == 0) {
                    return true;
                }
            }
        }
        return false;
    }

    @Override
    public void sacuvajBrod(BufferedWriter b) throws IOException {
        b.write(String.valueOf(maksimalanKapacitet));
        b.newLine();
        b.write(String.valueOf(tekucaZauzetost));
        b.newLine();
        b.write(String.valueOf(n));
        b.newLine();
        b.write(String.valueOf(m));
        b.newLine();
        for(int i=0; i<n; i++) {
            for(int j=0; j<m; j++) {
                if(kontejneri[i][j] != null) {
                    b.write("zauzeto");
                    b.newLine();
                    kontejneri[i][j].sacuvajKontejner(b);
                } else {
                    b.write("slobodno");
                    b.newLine();
                }
            }
        }
    }

    @Override
    public void procitajBrod(BufferedReader b) throws IOException{
        maksimalanKapacitet = Integer.parseInt(b.readLine());
        tekucaZauzetost = Integer.parseInt(b.readLine());
        n = Integer.parseInt(b.readLine());
        m = Integer.parseInt(b.readLine());
        kontejneri = new Kontejner[n][m];
        for(int i=0; i<n; i++) {
            for(int j=0; j<m; j++) {
                String zauzetost = b.readLine();
                if(zauzetost.compareTo("zauzeto") == 0) {
                    String oznaka = b.readLine();
                    if(oznaka.compareTo("H") == 0) {
                        String ID = b.readLine();
                        String ime = b.readLine();
                        int tezina = Integer.parseInt(b.readLine());
                        int redovi = Integer.parseInt(b.readLine());
                        int kolone = Integer.parseInt(b.readLine());
                        String datumIsteka = b.readLine();
                        kontejneri[i][j] = new KontejnerSaHranom(ID, ime, tezina, datumIsteka);
                    } else if(oznaka.compareTo("G") == 0) {
                        String ID = b.readLine();
                        String ime = b.readLine();
                        int tezina = Integer.parseInt(b.readLine());
                        int redovi = Integer.parseInt(b.readLine());
                        int kolone = Integer.parseInt(b.readLine());
                        String zemljaPorekla = b.readLine();
                        kontejneri[i][j] = new KontejnerSaGarderobom(ID, ime, tezina, zemljaPorekla);
                    } else if(oznaka.compareTo("F") == 0) {
                        String ID = b.readLine();
                        String ime = b.readLine();
                        int tezina = Integer.parseInt(b.readLine());
                        int redovi = Integer.parseInt(b.readLine());
                        int kolone = Integer.parseInt(b.readLine());
                        String tip = b.readLine();
                        kontejneri[i][j] = new KontejnerSaGorivom(ID, ime, tezina, tip);
                    }
                } else {
                    kontejneri[i][j] = null;
                }
            }
        }
    }

    @Override
    public int getMaksimalanKapacitet() {
        return maksimalanKapacitet;
    }

    @Override
    public int getTekucaZauzetost() {
        return tekucaZauzetost;
    }

    @Override
    public int compareTo(Brod o) {
        int slobodno1 = this.maksimalanKapacitet - this.tekucaZauzetost;
        int slobodno2 = o.maksimalanKapacitet - o.tekucaZauzetost;
        return slobodno2 - slobodno1;
    }
}
