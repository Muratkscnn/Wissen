USE WebSabah	
/*
SELECT * FROM viewsatislar */
/*
SELECT 
Adsoyad AS [Ad Soyad],
UrunAd AS [Ürün Adý],
BirimFiyat AS [Birim Fiyatý]
FROM viewSatislar */
/*
SELECT
	AdSoyad AS 'AD SOYAD',
	UrunAd AS 'ÜRÜN ADI',
	ADET AS 'ADET',
	BirimFiyat AS 'BÝRÝM FÝYATI',
	Tarih AS 'TARÝH',
	Musteri AS 'MÜÞTERÝ',
	Birimfiyat * Adet AS 'TUTAR'
	FROM viewSatislar */

	/* SELECT AdSoyad, BirimFiyat, Adet, Musteri
	FROM ViewSAtislar
	WHERE musteri='MUSTERÝ A' */
	/*
	SELECT AdSoyad, BirimFiyat, Adet, Musteri
	FROM ViewSAtislar
	WHERE musteri='MUSTERÝ A' AND Adet>=2 */

	--müþteri A ve C þatýþlarýndan Tutarý 20000'in üzerinde olanlarý getiren sorgu
	/*
	SELECT AdSoyad,UrunAd, BirimFiyat,Adet,
	BirimFiyat*Adet AS 'TUTAR', Musteri,Tarih
	FROM ViewSatislar
	WHERE  (musteri='MUSTERÝ A' OR musteri='Musteri C') AND Adet*BirimFiyat>20000 */

	--Satýþý yapýlan ürünleri listeleyelim
	--SELECT DISTINCT urunAd FROM ViewSatislar
	
	--SADECE Müsteri C'ye Satýþý yapýlan ürünleri listeleyelim
	--SELECT DISTINCT UrunAd FROM ViewSatislar WHERE musteri='MUSTERÝ C'

	--sýralama yapmak için A-Z/Küçükten Büyüðe (ASC) Z-A/Büyükten Küçüðe(DESC)
	/* SELECT AdSoyad, UrunAd, Adet, Musteri 
	FROM viewSatislar
	ORDER BY UrunAd DESC,Adet DESC */

	--müsteriadýna gore A->Z sýralansýn müsterisi ayný olanlarda AdSoyada göre A->z sýralansýn.
	/* SELECT AdSoyad, UrunAd, Adet, Musteri 
	FROM viewSatislar
	ORDER BY musteri,AdSoyad */
	
	--hangi ürün kaç kez iþleme alýndý COUNT dolu sutunlarý sayma iþlemi - Groupby gruplama

	/* SELECT urunAd,COUNT(AdSoyad) AS 'Ýþlem Sayýsý'
	FROM viewSatislar
	GROUP BY urunAd
	ORDER BY urunAd DESC */

	--Toplam Satiýþ miktarý
	/* SELECT SUM(Adet)
	FROM viewSatislar */
	
	-- ürünlerin toplam satýþ miktarý
	/* SELECT urunad, SUM(adet)
	FROM viewSatislar
	GROUP BY UrunAD */

	/* SELECT urunad, SUM(adet*BirimFiyat)
	FROM viewSatislar
	GROUP BY UrunAD
	*/
	SELECT
	AdSoyad AS 'AD SOYAD',
	UrunAd AS 'ÜRÜN ADI',
	ADET AS 'ADET',
	Alisfiyati AS 'ALIÞ FÝYATI',
	satisfiyati AS 'SATIÞ FÝYATI',
	(satisfiyati - alisfiyati) * adet AS 'Kar',
	Tarih AS 'TARÝH',
	Musteri AS 'MÜÞTERÝ'
    FROM viewkar
	ORDER BY (satisfiyati - alisfiyati) * adet DESC
	