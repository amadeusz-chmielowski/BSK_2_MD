Use BSK_2
go
/*insert do szpitali */

INSERT INTO SZPITALE VALUES('Mazowiecki Szpital Brodnowski' ,124313919, 'ul. Kondratowicza 8, 03-242 Warszawa', 0 );
INSERT INTO SZPITALE VALUES('Centrum Onkologii – Instytut im. Marii Skłodowskiej-Curie' ,174705474 , 'ul. Wilhelma Konrada Roentgena 502-781 Warszawa' , 0);
INSERT INTO SZPITALE VALUES('Szpital Czerniakowski' ,429773796, 'ul. Stępińska 19/25, 00-739 Warszawa' , 0);
INSERT INTO SZPITALE VALUES('Poradnia Zdrowia Psychicznego dla Studentów w Warszawie' ,636534627, 'Górnośląska 14,00-432 Warszawa', 0 );
INSERT INTO SZPITALE VALUES('Szpital Dziecięcy im. prof. dr. med. Jana Bogdanowicza w Warszawie' ,602649693, 'ul. Niekłańska 4/24,03-924 Warszawa', 0 );
 
 /*insert do odziałów */

INSERT INTO ODDZIALY VALUES('Reumatologiczny',5, 'Mazowiecki Szpital Brodnowski', 1);
INSERT INTO ODDZIALY VALUES('Zakazny',7, 'Mazowiecki Szpital Brodnowski', 1);

INSERT INTO ODDZIALY VALUES('Chemioterapi',12, 'Centrum Onkologii – Instytut im. Marii Skłodowskiej-Curie', 1);
INSERT INTO ODDZIALY VALUES('Onkologiczny',3, 'Centrum Onkologii – Instytut im. Marii Skłodowskiej-Curie', 1);

INSERT INTO ODDZIALY VALUES('Anastezjologii',4, 'Szpital Czerniakowski', 1);
INSERT INTO ODDZIALY VALUES('Internistyczny',7, 'Szpital Czerniakowski', 1);

INSERT INTO ODDZIALY VALUES('Rehabilitacji',9, 'Poradnia Zdrowia Psychicznego dla Studentów w Warszawie', 1);
INSERT INTO ODDZIALY VALUES('Neurologii',11, 'Poradnia Zdrowia Psychicznego dla Studentów w Warszawie', 1);

INSERT INTO ODDZIALY VALUES('Dziecięcy',17, 'Szpital Dziecięcy im. prof. dr. med. Jana Bogdanowicza w Warszawie', 1);
INSERT INTO ODDZIALY VALUES('Ratunkowy',25, 'Szpital Dziecięcy im. prof. dr. med. Jana Bogdanowicza w Warszawie', 1);

/* insert do sal zabiegowych */

INSERT INTO SALE_ZABIEGOWE VALUES(1, 10, 'Ratunkowy', 2);
INSERT INTO SALE_ZABIEGOWE VALUES(2, 10, 'Ratunkowy', 2);
INSERT INTO SALE_ZABIEGOWE VALUES(3, 10, 'Dziecięcy', 2);
INSERT INTO SALE_ZABIEGOWE VALUES(42, 10, 'Dziecięcy', 2);
INSERT INTO SALE_ZABIEGOWE VALUES(5, 10, 'Neurologii', 2);
INSERT INTO SALE_ZABIEGOWE VALUES(6, 10, 'Neurologii', 2);
INSERT INTO SALE_ZABIEGOWE VALUES(76, 10, 'Rehabilitacji', 2);
INSERT INTO SALE_ZABIEGOWE VALUES(8, 10, 'Rehabilitacji', 2);
INSERT INTO SALE_ZABIEGOWE VALUES(49, 10, 'Internistyczny', 2);
INSERT INTO SALE_ZABIEGOWE VALUES(10, 10, 'Internistyczny', 2);
INSERT INTO SALE_ZABIEGOWE VALUES(161, 10, 'Anastezjologii', 2);
INSERT INTO SALE_ZABIEGOWE VALUES(152, 10, 'Anastezjologii', 2);
INSERT INTO SALE_ZABIEGOWE VALUES(113, 10, 'Onkologiczny', 2);
INSERT INTO SALE_ZABIEGOWE VALUES(14, 10, 'Onkologiczny', 2);
INSERT INTO SALE_ZABIEGOWE VALUES(15, 10, 'Chemioterapi', 2);
INSERT INTO SALE_ZABIEGOWE VALUES(121, 10, 'Chemioterapi', 2);
INSERT INTO SALE_ZABIEGOWE VALUES(43, 10, 'Zakazny', 2);
INSERT INTO SALE_ZABIEGOWE VALUES(56, 10, 'Zakazny', 2);
INSERT INTO SALE_ZABIEGOWE VALUES(129, 10, 'Reumatologiczny', 2);
INSERT INTO SALE_ZABIEGOWE VALUES(37, 10, 'Reumatologiczny', 2);

/*INSERT DO KARETEK*/

INSERT INTO KARETKI VALUES('1D7RB1GP6BS570317', 'Zbyszek', 7, 3);
INSERT INTO KARETKI VALUES('3D7KS29C17G700729', 'Marcin',5, 3);
INSERT INTO KARETKI VALUES('3N1CN7AP5FL806224', 'Leszek',4, 3);
INSERT INTO KARETKI VALUES('2HKYF18665H506359', 'Radek',3, 3);
INSERT INTO KARETKI VALUES('1GHDT13S422143143', 'Miłosz',1, 3);
INSERT INTO KARETKI VALUES('4A4AP4AU1EE014467', 'Adam',8, 3);
INSERT INTO KARETKI VALUES('WDCTG4GBXFJ050974', 'Jarosław',9, 3);
INSERT INTO KARETKI VALUES('1G2JD12T6T7545335', 'Mirosław',12, 3);
INSERT INTO KARETKI VALUES('1G1PC5SB0E7287896', 'Jan', NULL, 3);
INSERT INTO KARETKI VALUES('6G2ER57759L211130', 'Radowił', 21, 3);

/*Insert do Chorób */

INSERT INTO CHOROBY VALUES('Achlazja', 2, 'Świat' , 'Genetyczne', 'brak', 0);
INSERT INTO CHOROBY VALUES('Celiakia', 4, 'Świat' , 'Genetyczne', 'brak', 0);
INSERT INTO CHOROBY VALUES('Erlichioza', 2, 'Obszary wiejskie' , 'kleszcze', 'antybiotyki', 0);
INSERT INTO CHOROBY VALUES('Giardioza', 0, 'Polska' , 'pasożyty', 'taletki na pasożyty', 0);
INSERT INTO CHOROBY VALUES('Ebola', 1, 'Afryka' , 'Wirusowe', 'szczepienie', 0);
INSERT INTO CHOROBY VALUES('Kandydoza skóry', 3, 'Świat' , 'grzyby', 'antybiotyki', 0);
INSERT INTO CHOROBY VALUES('Łojotok', 2, 'Świat' , 'Genetyczne', 'amputacja głowy', 0);
INSERT INTO CHOROBY VALUES('Naczyniaki', 2, 'Świat' , 'promieniowanie rakotwórcze', 'wycięcie', 0);
INSERT INTO CHOROBY VALUES('Pełzakowica', 2, 'Rejony Tropikalne' , 'pełzaki', 'amputacja cześci zakażonej', 0);
INSERT INTO CHOROBY VALUES('Sarkoidoza', 2, 'Świat' , 'bakterie', 'kortykosterydy', 0);


/*Insert do zabiegów */

INSERT INTO ZABIEGI VALUES('podanie leku',1, Null, 43,  'Kandydoza skóry', 2);
INSERT INTO ZABIEGI VALUES('amputacja głowy',3, 5, 1, 'Łojotok' , 2);
INSERT INTO ZABIEGI VALUES('amputacja konczyn',3, 5, 2,  'Pełzakowica', 2);
INSERT INTO ZABIEGI VALUES('podanie kortykosterydow',1, 1, 3,  'Sarkoidoza', 2);
INSERT INTO ZABIEGI VALUES('szczepienie',1, 2, 42,  'Ebola', 2);
INSERT INTO ZABIEGI VALUES('wycięcie',2, 4, 5,  'Naczyniaki', 2);
INSERT INTO ZABIEGI VALUES('podanie antybiotykow',1, 1, 37,  'Erlichioza', 2);


/*INSERT DO PACJENTA */

INSERT INTO PACJENCI VALUES(86101931238, ' Blackwell StreetDeadhorse, AK 99734' , 4);
INSERT INTO PACJENCI VALUES(14293047268, ' Francis MineRedding, CA 96001', 4);
INSERT INTO PACJENCI VALUES(88021458338, ' Locust CourtLong Beach, CA 90802', 4);
INSERT INTO PACJENCI VALUES(15302617959, ' Camden StreetReno, NV 89501', 4);
INSERT INTO PACJENCI VALUES(05271938212, ' Ray CourtRockingham, NC 28379', 4);
INSERT INTO PACJENCI VALUES(68110754569, ' Edgewood RoadPine Bluff, AR 71601', 4);
INSERT INTO PACJENCI VALUES(82010633896, ' Arrowood DriveJacksonville, FL 32202', 4);
INSERT INTO PACJENCI VALUES(98031325698, ' Queens LaneSchuyler, VA 22969', 4);
INSERT INTO PACJENCI VALUES(84031733218, ' Blackwell StreetDeadhorse, AK 99734', 4);
INSERT INTO PACJENCI VALUES(87112233566, ' Front StreetWestland, MI 48185', 4);

/*INSERT DO POBYTU*/

INSERT INTO POBYT (data_pobytu, oddzial, pacjent, choroba,zabieg)
	VALUES('1999-01-01', 'Anastezjologii',86101931238,'Achlazja',NULL );

INSERT INTO POBYT (data_pobytu, oddzial, pacjent, choroba,zabieg)
	VALUES('2001-01-01', 'Ratunkowy',14293047268, 'Achlazja',NULL);

INSERT INTO POBYT (data_pobytu, oddzial, pacjent, choroba,zabieg)
	VALUES('2002-01-01', 'Zakazny',88021458338, 'Erlichioza','podanie leku');

INSERT INTO POBYT (data_pobytu, oddzial, pacjent, choroba,zabieg)
	VALUES('2003-01-01', 'Reumatologiczny',15302617959, 'Celiakia',NULL);

INSERT INTO POBYT (data_pobytu, oddzial, pacjent, choroba,zabieg)
	VALUES('2004-01-01', 'Dziecięcy',05271938212, 'Giardioza','podanie leku');

INSERT INTO POBYT (data_pobytu, oddzial, pacjent, choroba,zabieg)
	VALUES('2005-01-01', 'Zakazny',68110754569, 'Ebola','podanie leku');

INSERT INTO POBYT (data_pobytu, oddzial, pacjent, choroba,zabieg)
	VALUES('2006-01-01', 'Ratunkowy',82010633896, 'Łojotok','amputacja głowy');

INSERT INTO POBYT (data_pobytu, oddzial, pacjent, choroba,zabieg)
	VALUES('2007-01-01', 'Internistyczny',98031325698, 'Sarkoidoza','podanie leku');

INSERT INTO POBYT (data_pobytu, oddzial, pacjent, choroba,zabieg)
	VALUES('2008-01-01', 'Reumatologiczny',84031733218, 'Celiakia',NULL);

INSERT INTO POBYT (data_pobytu, oddzial, pacjent, choroba,zabieg)
	VALUES('2008-01-01', 'Zakazny',87112233566, 'Pełzakowica','amputacja konczyn');

INSERT INTO POBYT (data_pobytu, oddzial, pacjent, choroba,zabieg)
	VALUES('2009-01-01', 'Anastezjologii',86101931238,'Achlazja',NULL);

/*INSERT DO LEKARZY*/

INSERT INTO LEKARZE VALUES(8886437, 'Chirurg', 'Robert', 'Kogut', 'Ratunkowy', 'amputacja głowy', 3);
INSERT INTO LEKARZE VALUES(3961169, 'Chirurg', 'Zbyszek', null, 'Ratunkowy', 'podanie leku', 3);
INSERT INTO LEKARZE VALUES(7149365, 'Chirurg', 'Miłosz', null, 'Ratunkowy', 'amputacja konczyn', 3);
INSERT INTO LEKARZE VALUES(8984912, 'Chirurg', 'Bogumił', null, 'Ratunkowy', 'szczepienie', 3);
INSERT INTO LEKARZE VALUES(5245860, 'Chirurg', 'Igor', null, 'Ratunkowy', 'podanie kortykosterydow', 3);
INSERT INTO LEKARZE VALUES(8527011, 'Chirurg', 'Maciek', null, 'Ratunkowy', 'wycięcie', 3);


/*INSERT DO REF NA POBYT I LEKARZY */

INSERT INTO BTPOBYT_LEKARZE VALUES(8886437, 1, 4);
INSERT INTO BTPOBYT_LEKARZE VALUES(3961169, 1, 4);
INSERT INTO BTPOBYT_LEKARZE VALUES(8886437, 2, 4);
INSERT INTO BTPOBYT_LEKARZE VALUES(3961169, 3, 4);
INSERT INTO BTPOBYT_LEKARZE VALUES(7149365, 4, 4);
INSERT INTO BTPOBYT_LEKARZE VALUES(8886437, 5, 4);
INSERT INTO BTPOBYT_LEKARZE VALUES(8527011, 6, 4);
INSERT INTO BTPOBYT_LEKARZE VALUES(8886437, 7, 4);
INSERT INTO BTPOBYT_LEKARZE VALUES(5245860, 8, 4);
INSERT INTO BTPOBYT_LEKARZE VALUES(8886437, 9, 4);
INSERT INTO BTPOBYT_LEKARZE VALUES(8527011, 10, 4);
INSERT INTO BTPOBYT_LEKARZE VALUES(8886437, 11, 4);

/*INSERT DO TRANSPORTU*/

INSERT INTO TRANSPORTY(typ_pojazdu, vin, pacjent, lekarz)
	VALUES('karetka','1G1PC5SB0E7287896' ,86101931238,8886437);

INSERT INTO TRANSPORTY(typ_pojazdu, vin, pacjent, lekarz)
	VALUES('karetka','3D7KS29C17G700729' ,14293047268,8886437);

INSERT INTO TRANSPORTY(typ_pojazdu, vin, pacjent, lekarz)
	VALUES('karetka','3N1CN7AP5FL806224' ,88021458338,8886437);

INSERT INTO TRANSPORTY(typ_pojazdu, vin, pacjent, lekarz)
	VALUES('karetka','1G1PC5SB0E7287896' ,68110754569,8886437);

INSERT INTO TRANSPORTY(typ_pojazdu, vin, pacjent, lekarz)
	VALUES('karetka','1G1PC5SB0E7287896' ,98031325698,8886437);

INSERT INTO TRANSPORTY(typ_pojazdu, vin, pacjent, lekarz)
	VALUES('karetka','6G2ER57759L211130' ,86101931238,8886437);

/*INSERT DO RECEPT*/

INSERT INTO RECEPTY VALUES(4029717, '2008-01-01', '2008-01-01', 5245860, 1, 4);
INSERT INTO RECEPTY VALUES(1527849, '2008-01-01', '2008-01-01', 8527011, 2, 4);
INSERT INTO RECEPTY VALUES(3660365, '2008-01-01', '2008-01-01', 3961169, 3, 4);
INSERT INTO RECEPTY VALUES(2869777, '2009-01-01', '2008-01-01', 5245860, 5, 4);
INSERT INTO RECEPTY VALUES(6288547, '2009-01-01', '2008-01-01', 8527011, 6, 4);
INSERT INTO RECEPTY VALUES(3822147, '2010-01-01', '2008-01-01', 3961169, 7, 4);
INSERT INTO RECEPTY VALUES(1088456, '2011-01-01', '2008-01-01', 8527011, 8, 4);
INSERT INTO RECEPTY VALUES(3508208, '2012-01-01', '2008-01-01', 5245860, IDENT_CURRENT('POBYT'), 4);


