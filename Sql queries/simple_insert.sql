INSERT INTO ODDZIALY VALUES('Ortopedyczny',7, 'Mazowiecki Szpital Brodnowski', 1);

INSERT INTO SZPITALE VALUES('Mazowiecki Szpital Ogólny' ,124313719, 'ul. Jakaś 8, 03-242 Warszawa', 0 );

UPDATE SZPITALE SET telefon = 987124313 WHERE nazwa = 'Mazowiecki Szpital Ogólny';

DELETE FROM ODDZIALY WHERE nazwaOdzialu = 'Ortopedyczny';

ALTER TABLE ZABIEGI DROP COLUMN potrzebny_sprzet;