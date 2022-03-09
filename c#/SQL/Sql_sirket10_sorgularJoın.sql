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
--hangý personele kaç numaralý proje verýlmýþ
SELECT tblPersonel.Ad + ' '+ tblPersonel.Soyad AS 'AD SOYAD', tblGorevlendirme.ProjeID
FROM tblPersonel INNER JOIN tblGorevlendirme ON tblPersonel.ID=tblGorevlendirme.PersonelID
--*********************************************************
--personel Adý proje adý
SELECT tblPersonel.Ad + ' '+ tblPersonel.Soyad AS 'AD SOYAD', tblProje.ProjeAd
FROM 
tblPersonel INNER JOIN tblGorevlendirme ON tblPersonel.ID=tblGorevlendirme.PersonelID
INNER JOIN tblProje ON tblGorevlendirme.ProjeID=tblProje.ID
--*********************************************************
--istanbulda yaþayan personel sayýsýný bulalým
SELECT COUNT(tblpersonel.ID) AS 'Ýstanbulda Yaþayan Personel Sayýsý'
FROM
tblPersonel INNER JOIN tblIlce ON tblPersonel.IlceID=tblIlce.ID 
INNER JOIN tblIl ON tblIlce.IlID=tblIl.ID
WHERE IlAd='Ýstanbul'
--**********************************************************
--illere göre çalýþan sayýsý
SELECT IlAd,COUNT(tblpersonel.ID) AS 'Yaþayan Personel Sayýsý'
FROM
tblPersonel INNER JOIN tblIlce ON tblPersonel.IlceID=tblIlce.ID 
INNER JOIN tblIl ON tblIlce.IlID=tblIl.ID
GROUP BY IlAd
--**********************************************************
--Cinsiyete Göre Maaþ Toplamlarý
SELECT tblPersonel.Cinsiyet , SUM(tblPersonel.Maas) AS 'Maaþ Toplamý'
FROM tblpersonel
GROUP BY cinsiyet
--**********************************************************
--güvenli alan projesinde yer alan erkek personeli göster
SELECT tblPersonel.Ad + ' ' + tblPersonel.Soyad AS 'AD SOYAD', tblPersonel.Cinsiyet , tblProje.ProjeAd
FROM 
tblPersonel INNER JOIN tblGorevlendirme ON tblPersonel.ID = tblGorevlendirme.PersonelID
INNER JOIN tblProje ON tblGorevlendirme.ProjeID=tblProje.ID
WHERE ProjeAd='GÜVENLÝ ALAN' AND Cinsiyet='E'
--**********************************************************
--AKILLI ROBOT PROJESINDE YER ALAN ISTANBUL VE ANKARADA YASAYAN KADINLARIN AD SOYAD YASADIGI SEHRI GOSTER
SELECT tblPersonel.Ad + ' ' + tblPersonel.Soyad AS 'AD SOYAD', tblPersonel.Cinsiyet, tblProje.ProjeAd, tblIl.IlAd
FROM 
tblPersonel INNER JOIN tblGorevlendirme ON tblPersonel.ID = tblGorevlendirme.PersonelID
INNER JOIN tblProje ON tblGorevlendirme.ProjeID=tblProje.ID
INNER JOIN tblIlce ON tblPersonel.IlceID=tblIlce.ID
INNER JOIN tblIl ON tblIlce.IlID=tblIl.ID
WHERE ProjeAd='AKILLI ROBOT' AND Cinsiyet='K' AND (tblIl.IlAd='Ýstanbul' OR tblIl.IlAd='ANKARA')
--**********************************************************
-- (LEFT JOIN soldaki tabloda varolan tum kayýtlar gelir.)!= RIGHT JOÝN
SELECT tblIl.IlAd,tblIlce.IlceAd
FROM tblIl LEFT JOIN tblIlce ON tblIl.ID=tblIlce.IlID
--**********************************************************
--PERSONELLERÝN ALDIÐI PROJELER 
SELECT tblPersonel.Ad + ' ' + tblPersonel.Soyad AS 'AD SOYAD' , tblproje.ProjeAd 
FROM tblPersonel LEFT JOIN tblGorevlendirme ON tblPersonel.ID=tblGorevlendirme.PersonelID
LEFT JOIN tblProje ON tblGorevlendirme.ProjeID=tblProje.ID

--*************************************************************
--PERSONELLERE ATANAN PPROJE SAYISI
SELECT tblPersonel.Ad + ' ' + tblPersonel.Soyad AS 'AD SOYAD' , COUNT(tblproje.ProjeAd) AS 'Proje Sayýsý'
FROM tblPersonel LEFT JOIN tblGorevlendirme ON tblPersonel.ID=tblGorevlendirme.PersonelID
LEFT JOIN tblProje ON tblGorevlendirme.ProjeID=tblProje.ID
GROUP BY tblPersonel.Ad, tblPersonel.Soyad
ORDER BY COUNT(tblProje.ProjeAd) DESC, tblPersonel.Ad ASC
--*************************************************************
--HANGÝ ÞEHÝRDE HANGÝ PROJEYE KÝM ALMIÞ . TÜM ÞEHÝRLER GÖZÜKSÜN
SELECT  tblPersonel.Ad , tblPersonel.Soyad,tblIl.IlAd, tblProje.ProjeAd
FROM tblIl LEFT JOIN tblIlce ON tblIl.ID=tblIlce.IlID
LEFT JOIN tblPersonel ON tblPersonel.IlceID=tblIlce.ID
LEFT JOIN tblGorevlendirme ON tblGorevlendirme.PersonelID=tblPersonel.ID
LEFT JOIN tblProje ON tblGorevlendirme.ProjeID=tblProje.ID
--************************************************************
--ÝSTANBULDAKÝ personellerin içinden mutlu gençlik projesinde görevli kiþileri cinsiyetleriyle birlikte listeleyelim
-- ad , soyad , cinsiyet
SELECT tblPersonel.Ad + ' ' + tblPersonel.Soyad , tblPersonel.Cinsiyet,ProjeAd
FROM tblPersonel INNER JOIN tblIlce ON tblPersonel.IlceID=tblIlce.ID
INNER JOIN	tblIl ON tblIlce.IlID=tblIl.ID
INNER JOIN tblGorevlendirme ON tblGorevlendirme.PersonelID=tblPersonel.ID
INNER JOIN tblProje		ON tblGorevlendirme.ProjeID=tblProje.ID
WHERE tblProje.ProjeAd='MUTLU GENÇLÝK'


