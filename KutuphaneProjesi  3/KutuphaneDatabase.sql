CREATE DATABASE sKutuphane
GO
USE sKutuphane
CREATE TABLE tblTurler
(
ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
TurAd VARCHAR(30) UNIQUE
)
GO
CREATE TABLE tblYazarlar
(
	ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	AdSoyad VARCHAR(30),
	Cinsiyet VARCHAR(1),
	DogumTarihi DATE,
	Tel VARCHAR(11),
	Mail VARCHAR(40),
	TurID INT FOREIGN KEY REFERENCES tblTurler(ID) ON DELETE CASCADE
	)
	GO
CREATE TABLE tblYayinEvleri
(
	ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Ad VARCHAR(50) UNIQUE,
	Adres VARCHAR(50),
	Tel VARCHAR(11)
	)
	GO
CREATE TABLE tblUyeler
(
	ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	AdSoyad VARCHAR(30),
	Cinsiyet VARCHAR(1),
	DogumTarihi DATE,
	Tel VARCHAR(11),
	Mail VARCHAR(40),
	UyelikTarihi DATE,
	UyelikTipi INT,
	TcNo VARCHAR(11),
	Meslek VARCHAR(30),
	EgitimDurumu INT,
	CezaDurumu BIT
	)
	GO
CREATE TABLE tblKitaplar
(
	ISBN VARCHAR(13) NOT NULL PRIMARY KEY,
	Ad VARCHAR(100),
	SayfaSayisi INT,
	Stok INT,
	TurID INT FOREIGN KEY REFERENCES tblTurler(ID) ON DELETE CASCADE,
	YazarID INT FOREIGN KEY REFERENCES tblYazarlar(ID),
	YayinEviID INT FOREIGN KEY REFERENCES tblYayinEvleri(ID) ON DELETE CASCADE
	)
	GO
CREATE TABLE tblOdunc
(
	ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	UyeID INT FOREIGN KEY REFERENCES tblUyeler(ID) ON DELETE CASCADE,
	KitapISBN VARCHAR(13) FOREIGN KEY REFERENCES tblKitaplar(ISBN) ON DELETE CASCADE,
	VerilisTarihi DATE,
	TeslimTarihi DATE,
	Iptal BIT
	)
	GO

	INSERT INTO tblTurler VALUES
	('Basvuru'),('Bilgisayar'),('Edebiyat'),('Ders Kitabý')
	INSERT INTO tblYazarlar VALUES
	('Orhan Pamuk','E','1950-1-1','55555','opamuk1@gmail.com',1),
	('Orhan yamuk','E','1935-1-1','43344','opamuk2@gmail.com',2),
	('Osman Pamuk','E','1970-1-1','333333','opamuk8@gmail.com',3),
	('Orhan tanuk','K','1930-1-1','22222','opamuk3@gmail.com',4)
	INSERT INTO tblYayinevleri VALUES
	('KIRMIZI ÝNEK','BEYOÐLU','3564785'),
	('MAVÝ PORTAKAL BASIM DAÐITIM','BAKIRKÖY','111111'),
	('TURUNCU GÖKYÜZÜ YAYINLARI','KADIKÖY','8978987')
	INSERT INTO tblUyeler (AdSoyad,Cinsiyet,UyelikTipi,EgitimDurumu,CezaDurumu) VALUES
	('Ferhat Aldýverdi','E',2,3,0),
	('Burak Özen','E',2,4,0),
	('Ferdi Tayfur','E',1,4,1),
	('Sezen Aksu','K',1,1,0),
	('Canan Günaçmaz','K',2,1,0)
	INSERT INTO tblKitaplar(ISBN,Ad,TurID,YazarID,YayinEviID) VALUES
	('444444','C# PROGRAMLAMAYA GÝRÝÞ',2,3,2),
	('514525','KARA KÝTAP',3,1,2),
	('789654','VEGAN OLMA REHBERÝ',4,2,2),
	('257896','E-TÝCARETÝN KAPILARI',2,4,1),
	('157896','GÖÐE BAKALIM',1,2,3)


	





