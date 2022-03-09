CREATE DATABASE SirketSabah

USE SirketSabah

--Departman Tablosu (UNIQUE TEKRAR YAPILMAZ)

CREATE TABLE tblDepartman
(
	ID INT IDENTITY(1,1) NOT NULL,
	Ad VARCHAR(30) UNIQUE NOT NULL,
	PRIMARY KEY(ID)
)
--tblDepartman tablosuna veri giriþi

INSERT INTO tblDepartman
VALUES ('Kalite'),('Yönetim'),('Ar-Ge'),('Teknik')


--ünvanlar tablosu
CREATE TABLE tblUnvanlar
(
	ID INT IDENTITY(1,1) NOT NULL,
	Ad VARCHAR(30) UNIQUE NOT NULL,
	PRIMARY KEY(ID)
	)
--unvanlar tablosuna veri giriþi

INSERT INTO tblUnvanlar
VALUES	('Mühendis'),
		('ÝK Uzmaný'),
		('Teknisyen')

--iller tablosu

CREATE TABLE tblIller (
	ID char(2) NOT NULL,
	Ad varchar(30) UNIQUE NOT NULL,
	PRIMARY KEY(ID)
)

--Ýller veri giriþi
INSERT INTO tblIller
VALUES	('06','Ankara'),
		('34','Ýstanbul'),
		('35','Ýzmir')

--Ýlçeler tablosu 

CREATE TABLE tblIlce
(
	ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Ad varchar(30) NOT NULL,
	IlID char(2) NOT NULL REFERENCES tblIller(ID)
	--PRIMARY KEY(ID),
	--FOREIGN KEY(IlID) REFERENCES tblIller(ID)
)
--ilçe veri giriþi
INSERT INTO tblIlce
VALUES	('Çankaya','06'),('Yeni Mahalle','06'),('Polatlý','06'),
		('Belikdüzü','34'),('Bakýrköy','34'),('Beþiktaþ','34'),
		('Karþýyaka','35'),('Konak','35'),('Çeþme','35')
		
--Proje tablosu

CREATE TABLE tblProjeler (
	ID INT IDENTITY(1,1) NOT NULL,
	Ad VARCHAR(40) UNIQUE NOT NULL,
	Baslamatarihi DATE NULL,
	PlanlananBitisTarihi DATE NULL,
	PRIMARY KEY(ID) )

-- proje veri giriþi

INSERT INTO tblProjeler
VALUES
	('YEÞÝL DÜNYA','2022.3.5','2022.11.10'),
	('GÜVENLÝ AÐ',NULL,NULL),
	('MUTLU ÞEHÝRLER','2022.4.4',NULL),
	('AKILLI EVLER',NULL,'2023.4.3')

--PERSONEL TABLOSU

CREATE TABLE tblPersonel (
	ID INT IDENTITY(1,1) NOT NULL,
	Ad VARCHAR(30) NOT NULL,
	Soyad VARCHAR(30) NOT NULL,
	Cinsiyet CHAR(1) NOT NULL,
	DogumTarihi DATE NOT NULL,
	DogumYeri int NOT NULL,
	IseBaslamaTarihi DATE,
	DepartmanID int NOT NULL,
	UnvanID int NOT NULL,
	Maas decimal(12,2) NOT NULL,	
	FOREIGN KEY(DogumYeri) REFERENCES tblIlce(ID),
	FOREIGN KEY(DepartmanID) REFERENCES tblDepartman(ID),
	FOREIGN KEY(UnvanID) REFERENCES tblUnvanlar(ID)
	)

	-- daha sonra prýmary key atama
	ALTER TABLE tblPersonel ADD
	PRIMARY KEY(ID)

	--personel veri giriþi

	INSERT INTO tblPersonel
	VALUES 
		--('Ahmet','Ekinci','E','1986.3.23',2,'2005.3.1',1,1,12500),
		--('Burak','Turhan','E','1990.4.15',3,'2010.4.5',2,2,14000),
		--('Ceyda','Sakarya','K','1992.7.16',7,'2012.3.1',3,3,18000),
		('Demet','ÇOLAK','K','1982.05.05',5,'2005.06.17',3,3,2800),
		('Evrim','ÇITAK','K','1987.12.05',1,'2000.01.12',2,1,4500),
		('Figen','ESMER','K','1982.10.22',4,'1998.05.07',1,2,4000),
		('Galip','TANAR','E','1983.02.28',9,'1997.05.07',1,2,5200),
		('Emir','YANIK','E','1975.05.07',2,'2010.07.17',2,2,4500),
		('Ilgýn','ACI','E','1974.05.01',2,'2000.08.18',3,2,4200),
		('Ýskender','TAÞ','E','1974.07.02',7,'1995.09.05',4,1,4400),
		('Jale','CAN','K','1976.09.18',    5,'1998.10.12',2,2,3250),
		('Kamil','ALBAYRAK','E','1976.08.19',9,'2000.11.25',1,2,5200),
		('Leman','HASKIRIÞ','K','1978.09.20',6,'1999.10.27',1,2,4200),
		('Meltem','UYSAL','K','1985.08.04',6,'2000.05.27',1,2,2500),
		('Necati','UYSAL','E','1990.12.01',4,'2000.03.06',2,1,2000),
		('Osman','UYSAL','E','1982.02.15',6,'1995.05.12',4,3,4800),
		('Ömer','BUZDAÐ','E','1980.10.30',5,'2001.08.10',1,2,4800),
		('Perihan','KANAT','K','1980.10.28',4,'2001.07.11',4,1,2200),
		('Ramiz','ÇAKIR','E','1981.11.19',7,'2001.07.30',4,3,2700),
		('Sertaç','KÖSEDAÐ','E','1981.12.20',9,'2002.12.20',3,2,2900),
		('Þefik','ÇAPANOÐLU','E','1982.02.20',6,'1998.05.25',3,3,4800),
		('Taner','BOZOKLU','E','1983.07.21',5,'2005.09.05',1,2,3000),
		('Utku','DUMAN','E','1975.06.13',6,'2005.03.05',1,3,2800),
		('Ümit','ÞÝRÝN','E','1978.04.02',7,'1998.04.04',2,2,3300),
		('Veysel','ERTÜZÜN','E','1980.07.03',3,'2002.07.18',4,3,3100),
		('Yakup','GÖKÇE','E','1975.06.18',2,'2002.03.25',4,3,3100),
		('Zeliha','CANÝÞ','K','1978.03.03',5,'2005.08.13',1,3,2500)

--Görevlendirme 
	CREATE TABLE tblGorevlendirmeler
	(
	ID INT IDENTITY(1,1) NOT NULL,
	ProjeID INT NOT NULL,
	PersonelID INT NOT NULL,
	PRIMARY KEY(ID),
	FOREIGN KEY (ProjeID) REFERENCES tblprojeler(ID),
	FOREIGN KEY (PersonelID) REFERENCES tblpersonel(ID),
	CONSTRAINT ProjePersonelTekil UNIQUE (ProjeID,PersonelID)

	)
	
	--GOREVLENDIRME veri giriþi
	INSERT INTO tblGorevlendirmeler
	VALUES
		(1,3),(1,5),(1,7),(1,8),(1,11),
		(2,1),(2,3),(2,10),(2,13),(2,12),
		(3,4),(3,9),(3,15),(3,19),(3,21),
		(4,2),(4,8),(4,10),(4,20),(4,27)
