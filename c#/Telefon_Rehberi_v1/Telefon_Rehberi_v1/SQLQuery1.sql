--CREATE DATABASE sRehber
USE sRehber
CREATE TABLE tblKisiler
(
ID INT IDENTITY(1,1),
Ad VARCHAR(20) NOT NULL,
Soyad VARCHAR(20) NOT NULL,
Cinsiyet CHAR NOT NULL,
Telefon NCHAR(11) NOT NULL,
PRIMARY KEY(ID)
)
INSERT INTO tblKisiler
VALUES
	('Haluk','Levet','E','05554325566'),
	('Seren','Günaçtı','K','05310907666'),
	('Kemal','Kalbur','E','05315243623'),
	('Saide','Kül','K','05359876543'),
	('Mahir','Çakmak','E','05413215467'),
	('Canan','Solak','K','05647654321')
