--Bu trigger bir satýþ iþlemi yapýldýðýnda
--tblsatislar tablosuna bu satýþ kaydýnýn yapýlmasý dýþýnda tblurunle tablosunda da satýþý yapýlanurunun stok mýktarýný azaltacak..

CREATE TRIGGER trgUrunStokGuncelle ON tblSatislar FOR INSERT 
AS BEGIN
DECLARE @urunID INT,@satisAdedi INT
SELECT @urunID=UrunID,@satisAdedi=SatisAdedi FROM INSERTED	
UPDATE tblUrunler SET StokMiktari=StokMiktari-@satisAdedi WHERE ID=@urunID

END