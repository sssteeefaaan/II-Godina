CREATE TABLE TURNIR(
Naziv         varchar(20) default ('Unknown') not null,
Datum_odrzavanja    date   default ('01/MAY/2020')  not null,

CONSTRAINT Turnir_PK PRIMARY KEY (Datum_odrzavanja, Naziv)
);

CREATE TABLE DISCIPLINA(
Naziv_discipline         varchar(20) default ('Unknown') not null,
Vreme_pocetka         varchar(8) default ('Unknown') not null,
Vreme_kraja         varchar(8) default ('Unknown') not null,
Ime_sudije         varchar(15) default ('Unknown') not null,
Srednje_ime_sudije         varchar(15) default ('Unknown'),
Prezime_sudije         varchar(15) default ('Unknown') not null,

CONSTRAINT Disciplina_PK PRIMARY KEY (Naziv_discipline, Vreme_pocetka)
);

CREATE TABLE LOKACIJA(
Naziv         varchar(20)  default ('Unknown') not null,
Adresa         varchar(30) default ('Unknown') not null,
Vrsta_terena         varchar(15) default ('Unknown') not null,
Kapacitet        number(6) default(0) not null,

CONSTRAINT Lokacija_PK PRIMARY KEY (Naziv, Adresa),
CONSTRAINT Kapacitet_CHECK CHECK (Kapacitet between -1 and 999999)
);

CREATE TABLE UCESNIK(
Sifra         varchar(9)  default ('Unknown') not null CONSTRAINT UCESNIK_PK PRIMARY KEY,
Ime         varchar(15) default ('Unknown') not null,
Srednje_ime         varchar(15) default ('Unknown'),
Prezime         varchar(15) default ('Unknown') not null,
Regija         varchar(20) default ('Unknown') not null
);

CREATE TABLE SPONZOR(
Prioritet        number(3) default (1) not null CONSTRAINT SPONZOR_PK PRIMARY KEY,
Naziv         varchar(20) default ('Unknown') not null,
Slogan         varchar(200) default ('Unknown') not null,

CONSTRAINT Prioritet_CHECK CHECK (Prioritet between 0 and 999)
);

CREATE TABLE Sponzorise(
Naziv         varchar(20),
Datum_odrzavanja         date,
Prioritet         number(3) REFERENCES SPONZOR(Prioritet),

CONSTRAINT Sponzorise_PK PRIMARY KEY (Datum_odrzavanja , Naziv , Prioritet),
CONSTRAINT Sponzorise_FK FOREIGN KEY(Datum_odrzavanja,Naziv) REFERENCES TURNIR(Datum_odrzavanja,Naziv)
);

CREATE TABLE Organizuje(
Naziv         varchar(20),
Datum_odrzavanja         date,
Naziv_discipline         varchar(20),
Vreme_pocetka         varchar(15),

CONSTRAINT Organizuje_PK PRIMARY KEY(Datum_odrzavanja , Naziv , Naziv_discipline , Vreme_pocetka),
CONSTRAINT Organizuje_Turnir_FK FOREIGN KEY(Datum_odrzavanja,Naziv) REFERENCES TURNIR(Datum_odrzavanja,Naziv),
CONSTRAINT Organizuje_Disciplina_FK FOREIGN KEY(Naziv_discipline,Vreme_pocetka) REFERENCES DISCIPLINA(Naziv_discipline,Vreme_pocetka)
);

CREATE TABLE Ucestvuje(
Sifra        varchar(9) REFERENCES UCESNIK(Sifra),
Naziv_discipline         varchar(20),
Vreme_pocetka         varchar(15),
Redni_broj      number(4) default (1) not null,

CONSTRAINT Ucestvuje_PK PRIMARY KEY (Sifra, Naziv_discipline, Vreme_pocetka),
CONSTRAINT Ucestvuje_FK FOREIGN KEY (Naziv_discipline, Vreme_pocetka) REFERENCES DISCIPLINA(Naziv_discipline, Vreme_pocetka),
CONSTRAINT Redni_broj_CHECK CHECK (Redni_broj between 0 and 999)
);

CREATE TABLE Odrzava_se(
Naziv         varchar(20),
Adresa         varchar(30),
Naziv_discipline         varchar(20),
Vreme_pocetka         varchar(15),

CONSTRAINT Odrzava_se_PK PRIMARY KEY(Naziv, Adresa, Naziv_discipline , Vreme_pocetka),
CONSTRAINT Odrzava_se_Lokacija_FK FOREIGN KEY(Naziv, Adresa) REFERENCES LOKACIJA(Naziv,Adresa),
CONSTRAINT Odrazava_se_Disciplina_FK FOREIGN KEY(Naziv_discipline,Vreme_pocetka) REFERENCES DISCIPLINA(Naziv_discipline,Vreme_pocetka)
);

CREATE TABLE Kontakt_telefon(
Sifra         varchar(9) REFERENCES UCESNIK(Sifra),
Kontakt_telefon         varchar(15) default ('Unknown') not null,

CONSTRAINT Kontant_telefon PRIMARY KEY(Kontakt_telefon , Sifra)
);

CREATE TABLE Broj_telefona(
Naziv         varchar(20),
Adresa         varchar(30),
Broj_telefona         varchar(15) default ('Unknown') not null,

CONSTRAINT Broj_telefona_PK PRIMARY KEY(Broj_telefona , Adresa , Naziv),
CONSTRAINT Broj_telefona_FK FOREIGN KEY (Naziv, Adresa) references LOKACIJA(Naziv, Adresa)
);

INSERT INTO TURNIR values ('Elfakijada 2020','12-AUG-2020');

INSERT INTO DISCIPLINA values ('Alpsko skijanje','08:00h','12:00h','Djordje','Goran','Jovanovic');
INSERT INTO DISCIPLINA values ('Plivanje 100m','15:15h','19:30h','Michael','Fred','Phelps II');
INSERT INTO DISCIPLINA values('Dresurno jahanje','18:00h','21:30h','Magdalena','Petar','Marjanovic');
INSERT INTO DISCIPLINA values('Mixed Martial Arts','16:45h','21:00h','Predrag','Jelen','Kocic');
INSERT INTO DISCIPLINA values ('Diving 10m','12:00h','16:00h','Thomas','Robert','Daley');


INSERT INTO UCESNIK values ('RS001','Tina','Mladjan','Stanojevic','Jugoistocna Srbija');
INSERT INTO UCESNIK values ('RS002','Marta','Nenad','Dinic','Jugoistocna Srbija');
INSERT INTO UCESNIK values ('RS003','Stefan','Valentina','Aleksic','Jugoistocna Srbija');
INSERT INTO UCESNIK values ('RS004','Djordje','Goran','Jovanovic','Sumadija');
INSERT INTO UCESNIK values ('RS005','Nikola','Niksi','Stankovic','Jugoistocna Srbija');
INSERT INTO UCESNIK values ('RS006','Miljana','Miksi','Bogdanovic','Jugoistocna Srbija');
INSERT INTO UCESNIK values ('RS007','Vuk','Bibi','Bibic','Jugoistocna Srbija');
INSERT INTO UCESNIK values ('RS008','Petra','Ivana','Djordjevic','Jugoistocna Srbija');
INSERT INTO UCESNIK values ('RS009','Pavle','Rastko','Bozinovic','Sumadija');
INSERT INTO UCESNIK values ('RS010','Filip','Mladjan','Trajkovic','Jugoistocna Srbija');
INSERT INTO UCESNIK values ('RS011','Jovan','Mihajlo','Brzovic','Vojvodina');

INSERT INTO UCESNIK values ('SP001','Lucrecia','Hendrich','Montesinos','Spain');
INSERT INTO UCESNIK values ('SP002','Ursula','Tokio','Corbero','Spain');
INSERT INTO UCESNIK values ('SP003','Alvaro','El Professor','Morte','Spain');
INSERT INTO UCESNIK values ('SP004','Alba','Nairobi','Flores','Spain');
INSERT INTO UCESNIK values ('SP005','Raquel','Lisbon','Murillo','Spain');
INSERT INTO UCESNIK values ('SP006','Monica','Stockholm','Gaztambide','Spain');

INSERT INTO UCESNIK values ('USA001','Mikaela','Nadia','Shiffrin','Miami');
INSERT INTO UCESNIK values ('USA002','Alex','Jerry','Russo','New York');
INSERT INTO UCESNIK values ('USA003','Eric','Theodore','Cartman','Texas');

INSERT INTO UCESNIK values ('IT001','Ander','Jorje','Munoz','Italia');

INSERT INTO UCESNIK values ('MS001',' Ken','John','Shamrock','Malezija');

INSERT INTO UCESNIK values ('NK001','Kim','Jong','Un','North Korea');

INSERT INTO UCESNIK values ('NW001','Aleksander','Aamodt','Kilde','Norveska');

INSERT INTO UCESNIK values ('RC001','Janica','Goran','Kostelic','Severna Hrvatska');


INSERT INTO LOKACIJA values ('Chamonix','74400, France','Ski staza','1550');
INSERT INTO LOKACIJA values ('Bazen Banjica','19350 Knjazevac','Bazen','200');
INSERT INTO LOKACIJA values ('Empire Stadium','Wembley, London','Stadion','82000');
INSERT INTO LOKACIJA values ('Olimpico del Nuoto','Foro Italico, Rome, Italy','Vodeni sportovi','20000');

INSERT INTO SPONZOR values ('1','Corega krema','Da Vam vilica ostane na mestu, cak i uz najneverovatnije sportove!');
INSERT INTO SPONZOR values ('2','Chipsy','Jer jesti nije greh, vec privilegija.');
INSERT INTO SPONZOR values ('3','Head and Shoulders','Za one koje nije strah prljanja!');

INSERT INTO Kontakt_telefon values ('RS001','+38164312674');
INSERT INTO Kontakt_telefon values ('RS001','+38161456399');
INSERT INTO Kontakt_telefon values ('RS002','+38160989324');
INSERT INTO Kontakt_telefon values ('RS002','+47337546127');
INSERT INTO Kontakt_telefon values ('RS003','+19278356794');
INSERT INTO Kontakt_telefon values ('RS003','+13786451713');
INSERT INTO Kontakt_telefon values ('RS004','+385674987645');
INSERT INTO Kontakt_telefon values ('RS004','+38167776623');
INSERT INTO Kontakt_telefon values ('RS005','+38164567921');
INSERT INTO Kontakt_telefon values ('RS005','+38163312567');
INSERT INTO Kontakt_telefon values ('RS006','+38167321992');
INSERT INTO Kontakt_telefon values ('RS006','+38165213345');
INSERT INTO Kontakt_telefon values ('RS007','+38163219020');
INSERT INTO Kontakt_telefon values ('RS007','+38167233495');
INSERT INTO Kontakt_telefon values ('RS008','+381628978654');
INSERT INTO Kontakt_telefon values ('RS008','+381665989321');
INSERT INTO Kontakt_telefon values ('RS009','+342346654323');
INSERT INTO Kontakt_telefon values ('RS009','+396433456754');
INSERT INTO Kontakt_telefon values ('RS010','+397564323454');
INSERT INTO Kontakt_telefon values ('RS010','+1345564534');
INSERT INTO Kontakt_telefon values ('RS011','+3816542453');
INSERT INTO Kontakt_telefon values ('RS011','+381656431454');
INSERT INTO Kontakt_telefon values ('SP001','+60564344454');
INSERT INTO Kontakt_telefon values ('SP001','+67176319313');
INSERT INTO Kontakt_telefon values ('SP002','+78461298411');
INSERT INTO Kontakt_telefon values ('SP002','+978214782421');
INSERT INTO Kontakt_telefon values ('SP003','+491278498127');
INSERT INTO Kontakt_telefon values ('SP003','+347123941241');
INSERT INTO Kontakt_telefon values ('SP004','+34718748712');
INSERT INTO Kontakt_telefon values ('SP004','+34239487910');
INSERT INTO Kontakt_telefon values ('SP005','+34989876817');
INSERT INTO Kontakt_telefon values ('SP005','+349797756816');
INSERT INTO Kontakt_telefon values ('SP006','+34979988196');
INSERT INTO Kontakt_telefon values ('SP006','+344436756816');
INSERT INTO Kontakt_telefon values ('USA001','+45234534253');
INSERT INTO Kontakt_telefon values ('USA001','+33534590890');
INSERT INTO Kontakt_telefon values ('USA002','+12950235352');
INSERT INTO Kontakt_telefon values ('USA002','+124815239582');
INSERT INTO Kontakt_telefon values ('USA003','+145090238523');
INSERT INTO Kontakt_telefon values ('USA003','+124084791273');
INSERT INTO Kontakt_telefon values ('IT001','+128409819234');
INSERT INTO Kontakt_telefon values ('IT001','+1247214823827');
INSERT INTO Kontakt_telefon values ('MS001','+237823623988');
INSERT INTO Kontakt_telefon values ('MS001','+87627362141');
INSERT INTO Kontakt_telefon values ('NK001','+1279486127846');
INSERT INTO Kontakt_telefon values ('NK001','+7184612749128');
INSERT INTO Kontakt_telefon values ('NW001','+7248612841274');
INSERT INTO Kontakt_telefon values ('NW001','+3476848833984');
INSERT INTO Kontakt_telefon values ('RC001','+423428656816');
INSERT INTO Kontakt_telefon values ('RC001','+349797182466');

INSERT INTO Broj_telefona values ('Chamonix','74400, France','+1242142354');
INSERT INTO Broj_telefona values ('Chamonix','74400, France','+1487248724252');
INSERT INTO Broj_telefona values ('Bazen Banjica','19350 Knjazevac','+124214525');
INSERT INTO Broj_telefona values ('Bazen Banjica','19350 Knjazevac','+124978267');
INSERT INTO Broj_telefona values ('Empire Stadium','Wembley, London','+4233478522');
INSERT INTO Broj_telefona values ('Empire Stadium','Wembley, London','+2983628375');
INSERT INTO Broj_telefona values ('Olimpico del Nuoto','Foro Italico, Rome, Italy','+2472852523');
INSERT INTO Broj_telefona values ('Olimpico del Nuoto','Foro Italico, Rome, Italy','+3984768934');

INSERT INTO Sponzorise values ('Elfakijada 2020','12-Aug-2020','1');
INSERT INTO Sponzorise values ('Elfakijada 2020','12-Aug-2020','2');
INSERT INTO Sponzorise values ('Elfakijada 2020','12-Aug-2020','3');

INSERT INTO Ucestvuje values ('RS001','Alpsko skijanje','08:00h',1);
INSERT INTO Ucestvuje values ('RS002','Alpsko skijanje','08:00h',2);
INSERT INTO Ucestvuje values ('USA003','Alpsko skijanje','08:00h',3);
INSERT INTO Ucestvuje values ('IT001','Alpsko skijanje','08:00h',4);
INSERT INTO Ucestvuje values ('MS001','Alpsko skijanje','08:00h',5);

INSERT INTO Ucestvuje values ('RS003','Plivanje 100m','15:15h',1);
INSERT INTO Ucestvuje values ('RS004','Plivanje 100m','15:15h',2);
INSERT INTO Ucestvuje values ('SP001','Plivanje 100m','15:15h',3);
INSERT INTO Ucestvuje values ('SP002','Plivanje 100m','15:15h',4);
INSERT INTO Ucestvuje values ('USA001','Plivanje 100m','15:15h',5);

INSERT INTO Ucestvuje values ('USA002','Dresurno jahanje','18:00h',1);
INSERT INTO Ucestvuje values ('RS005','Dresurno jahanje','18:00h',2);
INSERT INTO Ucestvuje values ('RS006','Dresurno jahanje','18:00h',3);
INSERT INTO Ucestvuje values ('NW001','Dresurno jahanje','18:00h',4);
INSERT INTO Ucestvuje values ('NK001','Dresurno jahanje','18:00h',5);

INSERT INTO Ucestvuje values('RS010','Mixed Martial Arts','16:45h',1);
INSERT INTO Ucestvuje values('RS007','Mixed Martial Arts','16:45h',2);
INSERT INTO Ucestvuje values('RC001','Mixed Martial Arts','16:45h',3);
INSERT INTO Ucestvuje values('SP003','Mixed Martial Arts','16:45h',4);
INSERT INTO Ucestvuje values('SP004','Mixed Martial Arts','16:45h',5);

INSERT INTO Ucestvuje values('RS008','Diving 10m','12:00h',1);
INSERT INTO Ucestvuje values('RS009','Diving 10m','12:00h',2);
INSERT INTO Ucestvuje values('SP005','Diving 10m','12:00h',3);
INSERT INTO Ucestvuje values('RS011','Diving 10m','12:00h',4);
INSERT INTO Ucestvuje values('SP006','Diving 10m','12:00h',5);
INSERT INTO Ucestvuje values('IT001','Diving 10m','12:00h',6);

INSERT INTO Organizuje values('Elfakijada 2020','12-AUG-2020','Alpsko skijanje','08:00h');
INSERT INTO Organizuje values('Elfakijada 2020','12-AUG-2020','Plivanje 100m','15:15h');
INSERT INTO Organizuje values('Elfakijada 2020','12-AUG-2020','Dresurno jahanje','18:00h');
INSERT INTO Organizuje values('Elfakijada 2020','12-AUG-2020','Mixed Martial Arts','16:45h');
INSERT INTO Organizuje values('Elfakijada 2020','12-AUG-2020','Diving 10m','12:00h');

INSERT INTO Odrzava_se values('Chamonix','74400, France','Alpsko skijanje','08:00h');
INSERT INTO Odrzava_se values('Bazen Banjica','19350 Knjazevac','Plivanje 100m','15:15h');
INSERT INTO Odrzava_se values('Empire Stadium','Wembley, London','Dresurno jahanje','18:00h');
INSERT INTO Odrzava_se values('Empire Stadium','Wembley, London','Mixed Martial Arts','16:45h');
INSERT INTO Odrzava_se values('Olimpico del Nuoto','Foro Italico, Rome, Italy','Diving 10m','12:00h');









