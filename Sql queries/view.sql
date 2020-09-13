CREATE VIEW PIS (id, pesel, [data pobytu], adres)
AS SELECT id, pesel, data_pobytu, adres FROM POBYT AS p1
JOIN PACJENCI a1 ON a1.pesel = p1.pacjent;

