USE WebSabah
	CREATE TABLE tblAlislar (
	ID int IDENTITY(1,1) NOT NULL,
	CalýsanID int NOT NULL,
	UrunID int NOT NULL,
	Adet int NOT NULL,
	BirimFiyat decimal(10,2) NOT NULL,
	Tedarikci varchar(max) NOT NULL,
	Tarih date NOT NULL,
	PRIMARY KEY(ID),
	FOREIGN KEY(CalýsanID) REFERENCES tblCalisanlar(ID),
	FOREIGN KEY (UrunID) REFERENCES tblUrunler(ID)
	)