
SELECT imie, nazwisko FROM LEKARZE AS l1 WHERE l1.numer_lekarza IN (SELECT lekarz FROM BTPOBYT_LEKARZE AS bt1 WHERE bt1.pobyt IN (SELECT id FROM PACJENCI AS p1
JOIN POBYT po2 ON po2.pacjent = p1.pesel
WHERE P1.pesel = 86101931238));