CREATE DATABASE PersonelTakip
GO
USE PersonelTakip
GO
CREATE TABLE tblDepartmanlar
(
	ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Ad VARCHAR(50),
	Sorumlu VARCHAR(50)

)
INSERT INTO tblDepartmanlar VALUES
('Ýnsan Kaynaklarý','Alex de Souza'),
('Muhasebe','Bafetimbi Gomis'),
('Satýþ','Serdar Aziz'),
('Üretim','Elif Kaya')
GO
USE PersonelTakip
CREATE TABLE tblUnvanlar
(
	ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Ad VARCHAR(50)
)
INSERT INTO tblUnvanlar VALUES
('Ýþçi'),('Mühendis'),('Takým Lideri'),('Þef'),('Yönetici')
GO
CREATE TABLE tblCalisanlar
(
	ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Ad VARCHAR(50),
	Soyad VARCHAR(50),
	TcNo VARCHAR(11) UNIQUE,
	PersonelNo VARCHAR(5) UNIQUE,
	DogumTarihi DATE ,
	IseBaslamaTarihi DATE,
	DepartmanID INT,
	UnvanID INT,
	Durumu VARCHAR(5),
	FOREIGN KEY(DepartmanID) REFERENCES tblDepartmanlar(ID),
	FOREIGN KEY(UnvanID) REFERENCES tblUnvanlar(ID)
)
GO
INSERT INTO tblCalisanlar VALUES
('Seda','Kodyazar','89763344984','74522','2012-5-1','1975-3-19',1,3,'Aktif'),
('Faruk','Günsayan','89763344985','82345','2013-4-11','1976-3-19',2,2,'Aktif'),
('Cemal','Gittigelmez','89763344986','63467','2010-12-13','1975-3-19',1,1,'Aktif'),
('Orhan','Taklacý','89763344988','34112','2010-5-20','1979-3-16',1,4,'Aktif'),
('Cem','Parasaydý','89763344989','11111','1999-5-17','1973-3-19',3,5,'Aktif'),
('Tarkan','Çalhankýzý','89763344917','22222','2019-3-14','1988-3-19',2,5,'Aktif'),
('Feride','Kodyazar','89763344927','33333','2020-1-16','1986-3-19',3,1,'Aktif'),
('Selcan','Günsayan','89763344937','44444','2017-6-23','1989-3-19',1,2,'Aktif'),
('Begüm','Tutkopar','89763344947','55555','2018-7-24','1987-3-19',3,3,'Aktif')
