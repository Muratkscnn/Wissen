USE sHastane
go
CREATE TABLE tblBolumler(
	ID INT IDENTITY (1,1) NOT NULL,
	BolumAd VARCHAR(30) UNIQUE NOT NULL,
	PRIMARY KEY(ID)
	)
	go
	INSERT INTO tblBolumler
	VALUES
		('Dahiliye'),('Nöroloji'),('Ortopedi')
		go
		CREATE TABLE tblDoktorlar(
		ID INT IDENTITY (1,1) NOT NULL,
		SicilNo Char(5) NOT NULL,
		Adsoyad VARCHAR(40) NOT NULL,
		Tel VARCHAR(11) NULL,
		Mail VARCHAR(30) NULL,
		BolumID INT NOT NULL,
		PRIMARY KEY(ID),
		FOREIGN KEY (BolumID) REFERENCES tblBolumler(ID)
		)
		go
		INSERT INTO tblDoktorlar VALUES
		('58564','Ali Can','5565969595','alican@gmail.com','1'),
		('25486','Demet Evgar','5325254998','demet@gmail.com','1'),
		('59877','Sedat Kanar','5364665961','sedat@gmail.com','3'),
		('32145','Ferhunde Haným','5314895879','ferhunde@gmail.com','2'),
		('12345','Zafer Kimki','5314589632','zafer@gmail.com','2')
		go