SELECT kierowca FROM KARETKI AS K1
WHERE K1.vin IN (SELECT vin, count(vin) as puste FROM TRANSPORTY
GROUP BY vin);

