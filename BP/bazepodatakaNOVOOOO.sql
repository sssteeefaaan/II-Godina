SELECT D.Naziv_discipline, UK.Ime, UK.Prezime,UK.Datum_rodjenja
FROM UCESNIK UK ,UCESTVUJE U,DISCIPLINA D
WHERE D.Naziv_discipline = U.Naziv_discipline(+) AND UK.Sifra=U.Sifra(+);

SELECT L.Naziv,BT.Broj_telefona
FROM LOKACIJA L, BROJ_TELEFONA BT
WHERE L.Naziv=BT.Naziv and BT.Broj_telefona LIKE ('+13%');

--1. Za svaku od disciplina "Elfakijade 2020" prikazati redni broj takmi?ara, kao i njegovo puno ime.
SELECT DISTINCT U.Naziv_discipline,U.Redni_broj,UK.Prezime || ' ' || UK.Srednje_ime || ' ' || UK.Ime AS Puno_ime
FROM
UCESNIK UK FULL OUTER JOIN UCESTVUJE U ON UK.Sifra=U.Sifra
FULL OUTER JOIN ORGANIZUJE O ON U.Naziv_discipline=O.Naziv_discipline
WHERE O.Naziv LIKE 'Elfakijada%'
ORDER BY U.Naziv_discipline ASC,U.Redni_broj ASC;

--2. Prikazati sve takmi?are koji u?estvuju na više od jedne discipline.
SELECT Uk.Prezime,Uk.Ime,Count(*) Broj_disciplina
FROM UCESNIK UK INNER JOIN UCESTVUJE U
ON UK.Sifra=U.Sifra
GROUP BY(UK.Ime,UK.Prezime)
HAVING COUNT(*)>1
ORDER BY Broj_disciplina DESC,UK.Prezime ASC;

--3. Odrediti prose?nu starost takmi?ara za svaku disciplinu.
SELECT U.Naziv_discipline, ROUND (AVG(extract(year from sysdate)-extract(year from UK.Datum_rodjenja)),3) as Prosecna_starost
FROM UCESNIK UK RIGHT JOIN UCESTVUJE U ON UK.Sifra=U.Sifra
GROUP BY(U.Naziv_discipline);

--4. Prikazati sve brojeve telefona takmi?ara Kajakaštva.
SELECT UK.Ime || ' ' ||SUBSTR( UK.Srednje_ime,1,1) || '. ' || UK.Prezime as Puno_ime, KT.Kontakt_telefon
FROM UCESNIK UK, KONTAKT_TELEFON KT,UCESTVUJE U
WHERE UK.Sifra=KT.Sifra AND U.Sifra=UK.Sifra and U.Naziv_discipline='Kajakastvo'
ORDER BY PUNO_IME ASC;

--5. Prikazati lokacije, sa kapacitetom izmedju 50 i 100 hiljada, na kojima se odrzavaju discipline Elfakijade 2020, kao i imena tih disciplina.
SELECT L.Naziv,L.Adresa,O.Naziv_discipline,L.Kapacitet
FROM ODRZAVA_SE O, LOKACIJA L,ORGANIZUJE OG
WHERE L.Naziv=O.Naziv AND L.Adresa=O.Adresa AND OG.Naziv_discipline=O.Naziv_discipline AND OG.Naziv LIKE 'Elfakijada%'
GROUP BY O.Naziv_discipline,L.Naziv,L.Adresa,L.Kapacitet
HAVING L.Kapacitet BETWEEN '50000' AND '100000' ;

--6. Prikazati termine održavanja disciplina na lokacijama, kao i njihovo trajanje, u rastu?em redosledu vremena po?etka.
SELECT L.Naziv,O.Naziv_discipline,D.Vreme_pocetka,D.Vreme_kraja,
TO_CHAR( TRUNC ( ( (TO_NUMBER(SUBSTR(D.Vreme_kraja,1,2)) - TO_NUMBER(SUBSTR(D.Vreme_pocetka,1,2 )))*60 + TO_NUMBER(SUBSTR(D.Vreme_kraja,4,2)) - TO_NUMBER(SUBSTR(D.Vreme_pocetka,4,2 )))/60,0)) || ' sati i ' ||
TO_CHAR ( MOD (((TO_NUMBER(SUBSTR(D.Vreme_kraja,1,2)) - TO_NUMBER(SUBSTR(D.Vreme_pocetka,1,2 )))*60 + (TO_NUMBER(SUBSTR(D.Vreme_kraja,4,2)) - TO_NUMBER(SUBSTR(D.Vreme_pocetka,4,2 )))),60)) || ' minuta 'AS Trajanje
FROM LOKACIJA L,ODRZAVA_SE O,DISCIPLINA D
WHERE O.Naziv_discipline=D.Naziv_discipline AND L.Naziv=O.Naziv
ORDER BY O.Vreme_pocetka;

