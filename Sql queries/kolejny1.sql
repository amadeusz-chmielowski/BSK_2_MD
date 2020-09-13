SELECT pesel FROM PIS WHERE PIS.id IN (SELECT id FROM ZABIEGI AS z1
JOIN POBYT po2 ON po2.zabieg = z1.nazwa_zabiegu
WHERE z1.nazwa_zabiegu = 'podanie leku');

/* wypisanie peseli wszystkich  pacjent�w, kt�rzy odbyli zabieg "podanie leku" */