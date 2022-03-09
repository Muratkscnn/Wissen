USE WebSabah	
CREATE TABLE tblCalisanlar(
	ID int NOT NULL,
	TCNo char(11) NOT NULL,
	AdSoyad varchar(50) NOT NULL,
	Cinsiyet char(1) NOT NULL,
	BolumId int NOT NULL,
	PRIMARY KEY(ID),
	FOREIGN KEY(BolumID) REFERENCES tblBolumler(ID)
	)