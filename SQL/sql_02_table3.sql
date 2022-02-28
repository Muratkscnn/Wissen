USE WebSabah
CREATE TABLE tblUrunler(
	ID int IDENTITY(1,1) not NULL,
	UrunAd varchar(30) NOT NULL,
	StokMiktari int NOT NULL,
	Fiyat decimal(10,2) NOT NULL,
	PRIMARY KEY(ID)
	)

