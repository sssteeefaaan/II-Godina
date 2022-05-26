CREATE TABLE TURNIR(
Datum_odrzavanja    date   default ('01/MAY/2020')  not null,
Naziv         varchar(20) default ('Unknown') not null,

CONSTRAINT Turnir_PK PRIMARY KEY (Datum_odrzavanja, Naziv)
);

CREATE TABLE DISCIPLINA(
Naziv_discipline         varchar(20) default ('Unknown') not null,
Vreme_pocetka         varchar(8) default ('Unknown') not null,
Vreme_kraja         varchar(8) default ('Unknown') not null,
Ime         varchar(15) default ('Unknown') not null,
Srednje_ime         varchar(15) default ('Unknown'),
Prezime         varchar(15) default ('Unknown') not null,

CONSTRAINT Disciplina_PK PRIMARY KEY (Naziv_discipline, Vreme_pocetka)
);

CREATE TABLE LOKACIJA(
Naziv         varchar(20)  default ('Unknown') not null,
Adresa         varchar(30) default ('Unknown') not null,
Kapacitet        number(6) default(0) not null,
Vrsta_terena         varchar(15) default ('Unknown') not null,
Broj_telefona varchar(15)  default ('Unknown'),

CONSTRAINT Lokacija_PK PRIMARY KEY (Naziv, Adresa),
CONSTRAINT Kapacitet_CHECK CHECK (Kapacitet between -1 and 999999)
);

CREATE TABLE UCESNIK(
Ime         varchar(15) default ('Unknown') not null,
Srednje_ime         varchar(15) default ('Unknown'),
Prezime         varchar(15) default ('Unknown') not null,
Redni_broj         number(4)  default (1) not null CONSTRAINT UCESNIK_PK PRIMARY KEY,
Regija         varchar(15) default ('Unknown') not null,

CONSTRAINT Redni_broj_CHECK CHECK (Redni_broj between 0 and 9999)
);

CREATE TABLE SPONZOR(
Naziv         varchar(20) default ('Unknown') not null,
Slogan         varchar(200) default ('Unknown') not null,
Prioritet        number(3) default (1) not null CONSTRAINT SPONZOR_PK PRIMARY KEY,

CONSTRAINT Prioritet_CHECK CHECK (Prioritet between 0 and 999)
);

CREATE TABLE Ucestvuje(
Redni_broj        number(3) REFERENCES UCESNIK(Redni_broj),
Naziv_discipline         varchar(15),
Vreme_pocetka         varchar(15),

CONSTRAINT Ucestvuje_PK PRIMARY KEY (Redni_broj, Naziv_discipline, Vreme_pocetka),
CONSTRAINT Ucestvuje_FK FOREIGN KEY (Naziv_discipline, Vreme_pocetka) REFERENCES DISCIPLINA(Naziv_discipline, Vreme_pocetka)
);

CREATE TABLE Sponzorise(
Datum_odrzavanja         date,
Naziv         varchar(20),
Prioritet         number(3) REFERENCES SPONZOR(Prioritet),

CONSTRAINT Sponzorise_PK PRIMARY KEY (Datum_odrzavanja , Naziv , Prioritet),
CONSTRAINT Sponzorise_FK FOREIGN KEY(Datum_odrzavanja,Naziv) REFERENCES TURNIR(Datum_odrzavanja,Naziv)
);

CREATE TABLE Organizuje(
Datum_odrzavanja         date,
Naziv         varchar(20),
Naziv_discipline         varchar(15),
Vreme_pocetka         varchar(15),

CONSTRAINT Organizuje_PK PRIMARY KEY(Datum_odrzavanja , Naziv , Naziv_discipline , Vreme_pocetka),
CONSTRAINT Organizuje_Turnir_FK FOREIGN KEY(Datum_odrzavanja,Naziv) REFERENCES TURNIR(Datum_odrzavanja,Naziv),
CONSTRAINT Organizuje_Disciplina_FK FOREIGN KEY(Naziv_discipline,Vreme_pocetka) REFERENCES DISCIPLINA(Naziv_discipline,Vreme_pocetka)
);

CREATE TABLE Kontakt_telefon(
Kontakt_telefon         varchar(15) default ('Unknown') not null,
Redni_broj         number(3) REFERENCES UCESNIK(Redni_broj),

CONSTRAINT Kontant_telefon PRIMARY KEY(Kontakt_telefon , Redni_broj)
);

CREATE TABLE Broj_telefona(
Broj_telefona         varchar(15) default ('Unknown') not null,
Adresa         varchar(30),
Naziv         varchar(20),

CONSTRAINT Broj_telefona_PK PRIMARY KEY(Broj_telefona , Adresa , Naziv),
CONSTRAINT Broj_telefona_FK FOREIGN KEY (Naziv, Adresa) references LOKACIJA(Naziv, Adresa)
);

INSERT INTO 