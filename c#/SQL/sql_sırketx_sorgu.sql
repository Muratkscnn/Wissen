--Bak�rkoyde �al�sanlar� sorgula

SELECT 
Ad As 'Personel Ad�',
Soyad As 'Personel Soyad',
ilce As '�l�e',
unvan As 'Unvan�',
departman As 'Departman�'
FROM viewilce
WHERE ilce='Bak�rk�y'

--�stanbuldaki ki�ileri
SELECT 
Ad As 'Personel Ad�',
Soyad As 'Personel Soyad',
ilce As '�l�e',
il
FROM viewilce
WHERE il='�stanbul'

--istanbulda ya�ay�p proje alanlar listesi
SELECT 
Ad As 'Personel Ad�',
Soyad As 'Personel Soyad',
ProjeAd AS 'Proje Ad�',
ilce As '�l�e',
il
FROM viewilce
WHERE il='�stanbul'
