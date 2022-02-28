USE WebSabah	
/*
SELECT * FROM viewsatislar */
/*
SELECT 
Adsoyad AS [Ad Soyad],
UrunAd AS [�r�n Ad�],
BirimFiyat AS [Birim Fiyat�]
FROM viewSatislar */
/*
SELECT
	AdSoyad AS 'AD SOYAD',
	UrunAd AS '�R�N ADI',
	ADET AS 'ADET',
	BirimFiyat AS 'B�R�M F�YATI',
	Tarih AS 'TAR�H',
	Musteri AS 'M��TER�',
	Birimfiyat * Adet AS 'TUTAR'
	FROM viewSatislar */

	/* SELECT AdSoyad, BirimFiyat, Adet, Musteri
	FROM ViewSAtislar
	WHERE musteri='MUSTER� A' */
	/*
	SELECT AdSoyad, BirimFiyat, Adet, Musteri
	FROM ViewSAtislar
	WHERE musteri='MUSTER� A' AND Adet>=2 */

	--m��teri A ve C �at��lar�ndan Tutar� 20000'in �zerinde olanlar� getiren sorgu
	/*
	SELECT AdSoyad,UrunAd, BirimFiyat,Adet,
	BirimFiyat*Adet AS 'TUTAR', Musteri,Tarih
	FROM ViewSatislar
	WHERE  (musteri='MUSTER� A' OR musteri='Musteri C') AND Adet*BirimFiyat>20000 */

	--Sat��� yap�lan �r�nleri listeleyelim
	--SELECT DISTINCT urunAd FROM ViewSatislar
	
	--SADECE M�steri C'ye Sat��� yap�lan �r�nleri listeleyelim
	--SELECT DISTINCT UrunAd FROM ViewSatislar WHERE musteri='MUSTER� C'

	--s�ralama yapmak i�in A-Z/K���kten B�y��e (ASC) Z-A/B�y�kten K����e(DESC)
	/* SELECT AdSoyad, UrunAd, Adet, Musteri 
	FROM viewSatislar
	ORDER BY UrunAd DESC,Adet DESC */

	--m�steriad�na gore A->Z s�ralans�n m�sterisi ayn� olanlarda AdSoyada g�re A->z s�ralans�n.
	/* SELECT AdSoyad, UrunAd, Adet, Musteri 
	FROM viewSatislar
	ORDER BY musteri,AdSoyad */
	
	--hangi �r�n ka� kez i�leme al�nd� COUNT dolu sutunlar� sayma i�lemi - Groupby gruplama

	/* SELECT urunAd,COUNT(AdSoyad) AS '��lem Say�s�'
	FROM viewSatislar
	GROUP BY urunAd
	ORDER BY urunAd DESC */

	--Toplam Sati�� miktar�
	/* SELECT SUM(Adet)
	FROM viewSatislar */
	
	-- �r�nlerin toplam sat�� miktar�
	/* SELECT urunad, SUM(adet)
	FROM viewSatislar
	GROUP BY UrunAD */

	/* SELECT urunad, SUM(adet*BirimFiyat)
	FROM viewSatislar
	GROUP BY UrunAD
	*/
	SELECT
	AdSoyad AS 'AD SOYAD',
	UrunAd AS '�R�N ADI',
	ADET AS 'ADET',
	Alisfiyati AS 'ALI� F�YATI',
	satisfiyati AS 'SATI� F�YATI',
	(satisfiyati - alisfiyati) * adet AS 'Kar',
	Tarih AS 'TAR�H',
	Musteri AS 'M��TER�'
    FROM viewkar
	ORDER BY (satisfiyati - alisfiyati) * adet DESC
	