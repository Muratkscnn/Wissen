--Bakýrkoyde çalýsanlarý sorgula

SELECT 
Ad As 'Personel Adý',
Soyad As 'Personel Soyad',
ilce As 'Ýlçe',
unvan As 'Unvaný',
departman As 'Departmaný'
FROM viewilce
WHERE ilce='Bakýrköy'

--Ýstanbuldaki kiþileri
SELECT 
Ad As 'Personel Adý',
Soyad As 'Personel Soyad',
ilce As 'Ýlçe',
il
FROM viewilce
WHERE il='Ýstanbul'

--istanbulda yaþayýp proje alanlar listesi
SELECT 
Ad As 'Personel Adý',
Soyad As 'Personel Soyad',
ProjeAd AS 'Proje Adý',
ilce As 'Ýlçe',
il
FROM viewilce
WHERE il='Ýstanbul'
