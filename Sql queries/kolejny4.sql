SELECT pesel, adres FROM PIS WHERE PIS.id IN (SELECT id FROM ODDZIALY AS z1
JOIN POBYT po2 ON po2.oddzial = z1.nazwaOdzialu
where z1.nazwaOdzialu = 'Reumatologiczny');
