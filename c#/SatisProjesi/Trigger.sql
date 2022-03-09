--Bu trigger bir sat�� i�lemi yap�ld���nda
--tblsatislar tablosuna bu sat�� kayd�n�n yap�lmas� d���nda tblurunle tablosunda da sat��� yap�lanurunun stok m�ktar�n� azaltacak..

CREATE TRIGGER trgUrunStokGuncelle ON tblSatislar FOR INSERT 
AS BEGIN
DECLARE @urunID INT,@satisAdedi INT
SELECT @urunID=UrunID,@satisAdedi=SatisAdedi FROM INSERTED	
UPDATE tblUrunler SET StokMiktari=StokMiktari-@satisAdedi WHERE ID=@urunID

END