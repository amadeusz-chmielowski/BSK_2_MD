SELECT pesel FROM RECEPTY AS r1
JOIN PIS p1 ON p1.id = r1.pobyt
WHERE r1.data_wystawienia > '2008-01-01';