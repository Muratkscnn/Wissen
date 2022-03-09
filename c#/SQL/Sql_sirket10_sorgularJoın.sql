USE Sirket10
SELECT tblIl.IlAd,tblIlce.IlceAd
FROM tblIl INNER JOIN tblIlce ON tblIl.ID=tblIlce.IlID
--*********************************************************
SELECT tblIl.IlAd,tblIlce.IlceAd
FROM tblIlce INNER JOIN tblIl ON tblIl.ID=tblIlce.IlID
--*********************************************************
SELECT tblPersonel.Ad + ' '+ tblPersonel.Soyad AS 'AD SOYAD' ,DepartmanAd
FROM tblPersonel INNER JOIN tblDepartman ON tblPersonel.DepartmanID=tblDepartman.ID
--*********************************************************
--hang� personele ka� numaral� proje ver�lm��
SELECT tblPersonel.Ad + ' '+ tblPersonel.Soyad AS 'AD SOYAD', tblGorevlendirme.ProjeID
FROM tblPersonel INNER JOIN tblGorevlendirme ON tblPersonel.ID=tblGorevlendirme.PersonelID
--*********************************************************
--personel Ad� proje ad�
SELECT tblPersonel.Ad + ' '+ tblPersonel.Soyad AS 'AD SOYAD', tblProje.ProjeAd
FROM 
tblPersonel INNER JOIN tblGorevlendirme ON tblPersonel.ID=tblGorevlendirme.PersonelID
INNER JOIN tblProje ON tblGorevlendirme.ProjeID=tblProje.ID
--*********************************************************
--istanbulda ya�ayan personel say�s�n� bulal�m
SELECT COUNT(tblpersonel.ID) AS '�stanbulda Ya�ayan Personel Say�s�'
FROM
tblPersonel INNER JOIN tblIlce ON tblPersonel.IlceID=tblIlce.ID 
INNER JOIN tblIl ON tblIlce.IlID=tblIl.ID
WHERE IlAd='�stanbul'
--**********************************************************
--illere g�re �al��an say�s�
SELECT IlAd,COUNT(tblpersonel.ID) AS 'Ya�ayan Personel Say�s�'
FROM
tblPersonel INNER JOIN tblIlce ON tblPersonel.IlceID=tblIlce.ID 
INNER JOIN tblIl ON tblIlce.IlID=tblIl.ID
GROUP BY IlAd
--**********************************************************
--Cinsiyete G�re Maa� Toplamlar�
SELECT tblPersonel.Cinsiyet , SUM(tblPersonel.Maas) AS 'Maa� Toplam�'
FROM tblpersonel
GROUP BY cinsiyet
--**********************************************************
--g�venli alan projesinde yer alan erkek personeli g�ster
SELECT tblPersonel.Ad + ' ' + tblPersonel.Soyad AS 'AD SOYAD', tblPersonel.Cinsiyet , tblProje.ProjeAd
FROM 
tblPersonel INNER JOIN tblGorevlendirme ON tblPersonel.ID = tblGorevlendirme.PersonelID
INNER JOIN tblProje ON tblGorevlendirme.ProjeID=tblProje.ID
WHERE ProjeAd='G�VENL� ALAN' AND Cinsiyet='E'
--**********************************************************
--AKILLI ROBOT PROJESINDE YER ALAN ISTANBUL VE ANKARADA YASAYAN KADINLARIN AD SOYAD YASADIGI SEHRI GOSTER
SELECT tblPersonel.Ad + ' ' + tblPersonel.Soyad AS 'AD SOYAD', tblPersonel.Cinsiyet, tblProje.ProjeAd, tblIl.IlAd
FROM 
tblPersonel INNER JOIN tblGorevlendirme ON tblPersonel.ID = tblGorevlendirme.PersonelID
INNER JOIN tblProje ON tblGorevlendirme.ProjeID=tblProje.ID
INNER JOIN tblIlce ON tblPersonel.IlceID=tblIlce.ID
INNER JOIN tblIl ON tblIlce.IlID=tblIl.ID
WHERE ProjeAd='AKILLI ROBOT' AND Cinsiyet='K' AND (tblIl.IlAd='�stanbul' OR tblIl.IlAd='ANKARA')
--**********************************************************
-- (LEFT JOIN soldaki tabloda varolan tum kay�tlar gelir.)!= RIGHT JO�N
SELECT tblIl.IlAd,tblIlce.IlceAd
FROM tblIl LEFT JOIN tblIlce ON tblIl.ID=tblIlce.IlID
--**********************************************************
--PERSONELLER�N ALDI�I PROJELER 
SELECT tblPersonel.Ad + ' ' + tblPersonel.Soyad AS 'AD SOYAD' , tblproje.ProjeAd 
FROM tblPersonel LEFT JOIN tblGorevlendirme ON tblPersonel.ID=tblGorevlendirme.PersonelID
LEFT JOIN tblProje ON tblGorevlendirme.ProjeID=tblProje.ID

--*************************************************************
--PERSONELLERE ATANAN PPROJE SAYISI
SELECT tblPersonel.Ad + ' ' + tblPersonel.Soyad AS 'AD SOYAD' , COUNT(tblproje.ProjeAd) AS 'Proje Say�s�'
FROM tblPersonel LEFT JOIN tblGorevlendirme ON tblPersonel.ID=tblGorevlendirme.PersonelID
LEFT JOIN tblProje ON tblGorevlendirme.ProjeID=tblProje.ID
GROUP BY tblPersonel.Ad, tblPersonel.Soyad
ORDER BY COUNT(tblProje.ProjeAd) DESC, tblPersonel.Ad ASC
--*************************************************************
--HANG� �EH�RDE HANG� PROJEYE K�M ALMI� . T�M �EH�RLER G�Z�KS�N
SELECT  tblPersonel.Ad , tblPersonel.Soyad,tblIl.IlAd, tblProje.ProjeAd
FROM tblIl LEFT JOIN tblIlce ON tblIl.ID=tblIlce.IlID
LEFT JOIN tblPersonel ON tblPersonel.IlceID=tblIlce.ID
LEFT JOIN tblGorevlendirme ON tblGorevlendirme.PersonelID=tblPersonel.ID
LEFT JOIN tblProje ON tblGorevlendirme.ProjeID=tblProje.ID
--************************************************************
--�STANBULDAK� personellerin i�inden mutlu gen�lik projesinde g�revli ki�ileri cinsiyetleriyle birlikte listeleyelim
-- ad , soyad , cinsiyet
SELECT tblPersonel.Ad + ' ' + tblPersonel.Soyad , tblPersonel.Cinsiyet,ProjeAd
FROM tblPersonel INNER JOIN tblIlce ON tblPersonel.IlceID=tblIlce.ID
INNER JOIN	tblIl ON tblIlce.IlID=tblIl.ID
INNER JOIN tblGorevlendirme ON tblGorevlendirme.PersonelID=tblPersonel.ID
INNER JOIN tblProje		ON tblGorevlendirme.ProjeID=tblProje.ID
WHERE tblProje.ProjeAd='MUTLU GEN�L�K'


