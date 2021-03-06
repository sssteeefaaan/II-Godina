ALTER TABLE TURNIR
ADD Datum_kraja date;
UPDATE TURNIR SET Datum_kraja='20-AUG-2020' WHERE NAZIV='Elfakijada 2020' AND Datum_odrzavanja='12-AUG-2020';

ALTER TABLE ODRZAVA_SE
ADD Datum_odrzavanja DATE;
UPDATE ODRZAVA_SE SET Datum_odrzavanja='12-AUG-2020' WHERE Naziv_discipline='Alpsko skijanje';
UPDATE ODRZAVA_SE SET Datum_odrzavanja='13-AUG-2020' WHERE Naziv_discipline='Diving 10m';
UPDATE ODRZAVA_SE SET Datum_odrzavanja='16-AUG-2020' WHERE Naziv_discipline='Plivanje 100m';
UPDATE ODRZAVA_SE SET Datum_odrzavanja='17-AUG-2020' WHERE Naziv_discipline='Mixed Martial Arts';
UPDATE ODRZAVA_SE SET Datum_odrzavanja='18-AUG-2020' WHERE Naziv_discipline='Dresurno jahanje';

ALTER TABLE ODRZAVA_SE
DROP CONSTRAINT ODRZAVA_SE_PK;
ALTER TABLE ODRZAVA_SE
ADD PRIMARY KEY (Vreme_pocetka,Datum_odrzavanja);
ALTER TABLE ODRZAVA_SE
RENAME CONSTRAINT SYS_C00132441 TO ODRZAVA_SE_PK;

ALTER TABLE UCESNIK
ADD Datum_rodjenja date;
Update UCESNIK set Datum_rodjenja='15-JAN-1998' where Sifra='IT001';
Update UCESNIK set Datum_rodjenja='17-DEC-1978' where Sifra='MS001';
Update UCESNIK set Datum_rodjenja='04-AUG-2001' where Sifra='NK001';
Update UCESNIK set Datum_rodjenja='22-MAY-1999' where Sifra='NW001';
Update UCESNIK set Datum_rodjenja='05-APR-1989' where Sifra='NW001';
Update UCESNIK set Datum_rodjenja='01-FEB-2000' where Sifra='RC001';
Update UCESNIK set Datum_rodjenja='12-AUG-1999' where Sifra='RS001';
Update UCESNIK set Datum_rodjenja='08-MAR-2000' where Sifra='RS002';
Update UCESNIK set Datum_rodjenja='02-MAR-2000' where Sifra='RS003';
Update UCESNIK set Datum_rodjenja='09-DEC-1999' where Sifra='RS004';
Update UCESNIK set Datum_rodjenja='01-AUG-1999' where Sifra='RS005';
Update UCESNIK set Datum_rodjenja='15-SEP-1999' where Sifra='RS006';
Update UCESNIK set Datum_rodjenja='13-FEB-2000' where Sifra='RS007';
Update UCESNIK set Datum_rodjenja='19-JUN-1990' where Sifra='RS008';
Update UCESNIK set Datum_rodjenja=null where Sifra='RS009';
Update UCESNIK set Datum_rodjenja='21-OCT-1999' where Sifra='RS010';
Update UCESNIK set Datum_rodjenja='13-JUL-1998' where Sifra='RS011';
Update UCESNIK set Datum_rodjenja='04-FEB-1997' where Sifra='SP001';
Update UCESNIK set Datum_rodjenja='13-MAR-1994' where Sifra='SP002';
Update UCESNIK set Datum_rodjenja='09-SEP-1999' where Sifra='SP003';
Update UCESNIK set Datum_rodjenja='03-NOV-1996' where Sifra='SP004';
Update UCESNIK set Datum_rodjenja='31-MAR-1995' where Sifra='SP005';
Update UCESNIK set Datum_rodjenja='23-JUL-1993' where Sifra='SP006';
Update UCESNIK set Datum_rodjenja='30-OCT-1999' where Sifra='USA001';
Update UCESNIK set Datum_rodjenja='11-NOV-1991' where Sifra='USA002';
Update UCESNIK set Datum_rodjenja=null where Sifra='USA003';

INSERT INTO DISCIPLINA VALUES('Skok motkom','13:30h','15:00h','Pablo',null,'Escobar');
INSERT INTO DISCIPLINA VALUES('Kajakastvo','06:00h','12:00h','Mark','Oliver','Twist');
INSERT INTO DISCIPLINA VALUES('Klizanje na ledu','19:00h','22:30h','Maria','Katarina','Zamolochikowa');

INSERT INTO LOKACIJA VALUES('Tiger Stadium','Baton Rouge, Louisiana USA','Atletika','105000');
INSERT INTO LOKACIJA VALUES('National Stadium','Poniatowskiego Poland','Led','90000');
INSERT INTO LOKACIJA VALUES('Chesapeake Bay','Maryland, Virginia, USA','Kajak','0');

INSERT INTO Broj_telefona VALUES('Tiger Stadium','Baton Rouge, Louisiana USA','+1333429890');
INSERT INTO Broj_telefona VALUES('Tiger Stadium','Baton Rouge, Louisiana USA','+1333429888');
INSERT INTO Broj_telefona VALUES('Tiger Stadium','Baton Rouge, Louisiana USA','+1333429875');
INSERT INTO Broj_telefona VALUES('National Stadium','Poniatowskiego Poland','+35678638299');
INSERT INTO Broj_telefona VALUES('National Stadium','Poniatowskiego Poland','+35678638297');
INSERT INTO Broj_telefona VALUES('Chesapeake Bay','Maryland, Virginia, USA','+1333765267');

INSERT INTO ODRZAVA_SE VALUES('Tiger Stadium','Baton Rouge, Louisiana USA','Skok motkom','13:30h','14-AUG-2020');
INSERT INTO ODRZAVA_SE VALUES('National Stadium','Poniatowskiego Poland','Klizanje na ledu','19:00h','19-AUG-2020');
INSERT INTO ODRZAVA_SE VALUES('Chesapeake Bay','Maryland, Virginia, USA','Kajakastvo','06:00h','15-AUG-2020');

INSERT INTO ORGANIZUJE VALUES('Elfakijada 2020','12-AUG-2020','Skok motkom','13:30h');
INSERT INTO ORGANIZUJE VALUES('Elfakijada 2020','12-AUG-2020','Kajakastvo','06:00h');
INSERT INTO ORGANIZUJE VALUES('Elfakijada 2020','12-AUG-2020','Klizanje na ledu','19:00h');

INSERT INTO UCESNIK VALUES('IT002','Giorgio','Huepe','Armani','Nothern Italy','11-JUL-1993');
INSERT INTO UCESNIK VALUES('IT003','Elio','Theodore','Perlman','Nothern Italy',null);
INSERT INTO UCESNIK VALUES('USA004','Philip','Johnathan','Meachelson','Texas','13-nov-1994');
INSERT INTO UCESNIK VALUES('FR001','Timothee','Hal','Chalamet','Hauts de France','27-DEC-1995');
INSERT INTO UCESNIK VALUES('FR002','Piere','Louis','Bagguette','Hauts de France',null);

INSERT INTO KONTAKT_TELEFON VALUES('IT002','+4178831633');
INSERT INTO KONTAKT_TELEFON VALUES('IT002','+4181273661');
INSERT INTO KONTAKT_TELEFON VALUES('IT003','+4717263112');
INSERT INTO KONTAKT_TELEFON VALUES('IT003','+4712312896');
INSERT INTO KONTAKT_TELEFON VALUES('USA004','+133176387');
INSERT INTO KONTAKT_TELEFON VALUES('USA004','+133871481');
INSERT INTO KONTAKT_TELEFON VALUES('FR001','+5633687652');
INSERT INTO KONTAKT_TELEFON VALUES('FR001','+5618273112');
INSERT INTO KONTAKT_TELEFON VALUES('FR001','+5671278482');
INSERT INTO KONTAKT_TELEFON VALUES('FR002','+5671783129');
INSERT INTO KONTAKT_TELEFON VALUES('FR002','+5671294721');

INSERT INTO UCESTVUJE VALUES('IT002','Skok motkom','13:30h',1);
INSERT INTO UCESTVUJE VALUES('USA001','Skok motkom','13:30h',2);
INSERT INTO UCESTVUJE VALUES('IT003','Skok motkom','13:30h',3);
INSERT INTO UCESTVUJE VALUES('RS002','Skok motkom','13:30h',4);
INSERT INTO UCESTVUJE VALUES('USA004','Skok motkom','13:30h',5);
INSERT INTO UCESTVUJE VALUES('FR001','Kajakastvo','06:00h',1);
INSERT INTO UCESTVUJE VALUES('FR002','Kajakastvo','06:00h',2);
INSERT INTO UCESTVUJE VALUES('RS003','Kajakastvo','06:00h',3);
INSERT INTO UCESTVUJE VALUES('RS001','Kajakastvo','06:00h',4);
INSERT INTO UCESTVUJE VALUES('RS005','Kajakastvo','06:00h',5);
INSERT INTO UCESTVUJE VALUES('IT003','Kajakastvo','06:00h',6);
INSERT INTO UCESTVUJE VALUES('USA001','Kajakastvo','06:00h',7);
INSERT INTO UCESTVUJE VALUES('SP001','Klizanje na ledu','19:00h',1);
INSERT INTO UCESTVUJE VALUES('SP002','Klizanje na ledu','19:00h',2);
INSERT INTO UCESTVUJE VALUES('RS003','Klizanje na ledu','19:00h',3);

INSERT INTO SPONZOR VALUES(4,'Ribela','I miris i ukus, Ribela!');
INSERT INTO SPONZOR VALUES(5,'Redbull','Redbull! Daje ti krila!');
INSERT INTO SPONZOR VALUES(6,'Adidas','Ostani u pokretu! Adidas!');

INSERT INTO SPONZORISE VALUES('Elfakijada 2020','12-AUG-2020',4);
INSERT INTO SPONZORISE VALUES('Elfakijada 2020','12-AUG-2020',5);
INSERT INTO SPONZORISE VALUES('Elfakijada 2020','12-AUG-2020',6);
SELECT Sifra, Ime, Prezime, Regija FROM UCESNIK WHERE Regija IN ('Nothern Italy','Severna Hrvatska','Sumadija');

SELECT *
FROM UCESNIK
WHERE extract(year from Datum_rodjenja) > 1999
ORDER BY Datum_rodjenja DESC;

SELECT Naziv,extract(day from Datum_kraja)-extract(day from Datum_odrzavanja) as Dana
FROM TURNIR;

SELECT Ime,Prezime,extract(year from sysdate)-extract(year from Datum_rodjenja) as Starost
FROM UCESNIK
WHERE Datum_rodjenja is not null and extract(year from sysdate)-extract(year from Datum_rodjenja) between '20' and '30'
ORDER BY Starost ASC;

SELECT Naziv_discipline, Datum_odrzavanja
FROM ODRZAVA_SE
WHERE Datum_odrzavanja BETWEEN '16-AUG-2020' AND '19-AUG-2020'
ORDER BY Datum_odrzavanja ASC;
