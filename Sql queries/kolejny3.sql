SELECT mutacje as liczba_mutacji, COUNT(mutacje) AS liczba_chorob_o_danej_liczbie_mutacji FROM CHOROBY 
GROUP BY mutacje;