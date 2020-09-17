Use BSK_2
go

--CREATE schema MacSec
--go

--ClearanceLevelNumber:
--	0 - uncalssified
--	1 - restricted
--	2 - confidential
--	3 - secret
--	4 - top secret

CREATE TABLE SZPITALE (
nazwa VARCHAR(100) PRIMARY KEY,
telefon bigint CHECK ( telefon BETWEEN 100000000 AND 999999999 ) NOT NULL,
adres VARCHAR(100) not null,
ClearanceLevelNumber int DEFAULT 0
);


CREATE TABLE ODDZIALY (
nazwaOdzialu VARCHAR(20) PRIMARY KEY,
wyposazenie INT,
szpital VARCHAR(100) REFERENCES SZPITALE ON DELETE CASCADE NOT NULL,
ClearanceLevelNumber int DEFAULT 1
);


CREATE TABLE SALE_ZABIEGOWE (
numer_sali int check ( numer_sali BETWEEN 0 AND 300 ) PRIMARY KEY,
sprzet_operacyjny int,
oddzial VARCHAR(20) REFERENCES ODDZIALY ON DELETE CASCADE NOT NULL,
ClearanceLevelNumber int DEFAULT 2
);

CREATE TABLE KARETKI(
vin char(17) PRIMARY KEY,
kierowca VARCHAR(50),
wyposazenie int,
ClearanceLevelNumber int DEFAULT 3
)

CREATE TABLE CHOROBY(
nazwa_choroby VARCHAR(20) PRIMARY KEY,
mutacje int,
wystepowanie VARCHAR(20) NOT NULL,
rodzaj_rozpowrzechniania VARCHAR(80),
leczenie VARCHAR(80),
ClearanceLevelNumber int DEFAULT 0
);

CREATE TABLE ZABIEGI (
nazwa_zabiegu VARCHAR(50) PRIMARY KEY,
ilosc_potrzebnych_lekarzy smallint NOT NULL,
potrzebny_sprzet smallint,
sala_zabiegowa int REFERENCES SALE_ZABIEGOWE ON DELETE SET NULL,
choroba VARCHAR(20) REFERENCES CHOROBY ON DELETE SET NULL,
ClearanceLevelNumber int DEFAULT 2
);

CREATE TABLE PACJENCI(
pesel bigint PRIMARY KEY,
adres VARCHAR(500),
ClearanceLevelNumber int DEFAULT 4
);

CREATE TABLE POBYT (
id bigint IDENTITY(1,1) PRIMARY KEY,	
data_pobytu date NOT NULL,
oddzial VARCHAR(20) REFERENCES ODDZIALY ON DELETE SET NULL,
pacjent bigint REFERENCES PACJENCI ON DELETE SET NULL,
choroba VARCHAR(20) REFERENCES CHOROBY ON DELETE SET NULL,
zabieg VARCHAR(50) REFERENCES ZABIEGI ON DELETE SET NULL,
ClearanceLevelNumber int DEFAULT 4
);


CREATE TABLE LEKARZE (
numer_lekarza int check ( numer_lekarza BETWEEN 1000000 AND 9999999 ) PRIMARY KEY,
specjalizacja VARCHAR(20),
imie VARCHAR(20) NOT NULL,
nazwisko VARCHAR(30),
oddzial VARCHAR(20) REFERENCES ODDZIALY ON DELETE SET NULL,
zabieg VARCHAR(50) REFERENCES ZABIEGI ON DELETE SET NULL,
ClearanceLevelNumber int DEFAULT 3
);

CREATE TABLE BTPOBYT_LEKARZE (
PRIMARY KEY (lekarz, pobyt),
lekarz INT REFERENCES LEKARZE ,
pobyt bigint REFERENCES POBYT,
ClearanceLevelNumber int DEFAULT 4
);

CREATE TABLE TRANSPORTY(
id int IDENTITY(1,1) PRIMARY KEY,
typ_pojazdu varchar(20) NOT NULL,
vin char(17) REFERENCES KARETKI ON DELETE SET NULL,
pacjent bigint REFERENCES PACJENCI ON DELETE SET NULL,
lekarz int REFERENCES LEKARZE ON DELETE SET NULL,
nazwa_zabiegu VARCHAR(50) REFERENCES ZABIEGI ON DELETE SET NULL,
ClearanceLevelNumber int DEFAULT 4
);


CREATE TABLE RECEPTY(
numer_recepty int PRIMARY KEY,
data_wystawienia date NOT NULL,
termin_waznosci date NOT NULL,
lekarz int REFERENCES LEKARZE ON DELETE SET NULL,
pobyt bigint REFERENCES POBYT ON DELETE SET NULL,
ClearanceLevelNumber int DEFAULT 4
);

