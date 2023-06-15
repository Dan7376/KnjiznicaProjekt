CREATE DATABASE KnjiznicaProjekt

USE KnjiznicaProjekt

CREATE TABLE Knjige (
    KnjigaID INT PRIMARY KEY IDENTITY(1, 1),
    Naslov NVARCHAR(100),
    Autor NVARCHAR(100),
    Zanr NVARCHAR(50),
    GodinaIzdavanja INT,
    DostupneKopije INT,
    Lokacija NVARCHAR(50)
);

CREATE TABLE Posuditelji (
    PosuditeljID INT PRIMARY KEY IDENTITY(1, 1),
    ImePrezime NVARCHAR(100),
    Adresa NVARCHAR(200),
    Email NVARCHAR(100),
    Telefon NVARCHAR(20)
);

CREATE TABLE Transakcije (
    TransakcijaID INT PRIMARY KEY IDENTITY(1, 1),
    KnjigaID INT,
    PosuditeljID INT,
    DatumPosudbe DATE,
    DatumVracanja DATE,
    Status NVARCHAR(50),
    FOREIGN KEY (KnjigaID) REFERENCES Knjige(KnjigaID),
    FOREIGN KEY (PosuditeljID) REFERENCES Posuditelji(PosuditeljID)
);

CREATE TABLE Login (
    PosuditeljID INT PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(50) NOT NULL,
    FOREIGN KEY (PosuditeljID) REFERENCES Posuditelji(PosuditeljID)
);

INSERT INTO Knjige (Naslov, Autor, Zanr, GodinaIzdavanja, DostupneKopije, Lokacija)
VALUES
    ('Tajna zaboravljenog ključa', 'John Smith', 'Misterija', 2015, 3, 'Polica A'),
    ('Skriveno carstvo', 'Emily Brown', 'Fantazija', 2010, 5, 'Polica B'),
    ('Umjetnost putovanja kroz vrijeme', 'Sophia Williams', 'Znanstvena fantastika', 2018, 2, 'Polica C'),
    ('Tajne izgubljenog grada', 'David Johnson', 'Pustolovina', 2005, 1, 'Polica D'),
    ('Moć znanja', 'Anna Wilson', 'Edukativna', 2022, 4, 'Polica E'),
    ('Tajanstveni artefakt', 'Ana Novak', 'Misterija', 2015, 3, 'Polica 2A'),
    ('Skriveno blago', 'Marko Petrović', 'Pustolovina', 2008, 5, 'Polica 3B'),
    ('Sjena prošlosti', 'Lara Vuković', 'Triler', 2019, 2, 'Polica 1C'),
    ('Magična kraljevina', 'Ivan Horvat', 'Fantazija', 2013, 4, 'Polica 4D'),
    ('Tajna crnog dijamanta', 'Elena Kovač', 'Romansa', 2005, 1, 'Polica 2B'),
    ('Zarobljeni svijet', 'Ivana Horvatović', 'Znanstvena fantastika', 2012, 3, 'Polica 3C'),
    ('Skrivene tajne', 'Petar Kovačević', 'Misterija', 2017, 5, 'Polica 2D'),
    ('Izgubljeni kontinent', 'Mia Novaković', 'Pustolovina', 2009, 2, 'Polica 4A'),
    ('Mračni tragovi', 'Luka Petrović', 'Triler', 2016, 4, 'Polica 1D'),
    ('Čarobni svijet', 'Elena Horvat', 'Fantazija', 2011, 1, 'Polica 3A');

INSERT INTO Posuditelji (ImePrezime, Adresa, Email, Telefon)
VALUES
   ('Marko Petrović', 'Ulica Marka Marulića 5, Zagreb', 'marko.petrovic@example.com', '0912345678'),
   ('Ana Kovač', 'Trg Franje Tuđmana 10, Split', 'ana.kovac@example.com', '0987654321'),
   ('Ivan Horvat', 'Pere Grge 15, Osijek', 'ivan.horvat@example.com', '0951234567'),
   ('Lana Novak', 'Gundulićeva ulica 20, Rijeka', 'lana.novak@example.com', '0998765432'),
   ('Petar Katić', 'Vukovarska ulica 25, Zadar', 'petar.katic@example.com', '0923456789'),
   ('Ana Marić', 'Ulica Ivana Gundulića 10, Zagreb', 'ana.maric@example.com', '0912345678'),
   ('Ivan Horvat', 'Trg Stjepana Radića 5, Split', 'ivan.horvat@example.com', '0987654321'),
   ('Luka Novaković', 'Pere Grge 15, Osijek', 'luka.novakovic@example.com', '0951234567'),
   ('Petra Kovačić', 'Gundulićeva ulica 20, Rijeka', 'petra.kovacic@example.com', '0998765432'),
   ('Marko Petrović', 'Vukovarska ulica 25, Zadar', 'marko.petrovic@example.com', '0923456789'),
   ('Ana Marić', 'Ulica Ivana Gundulića 10, Zagreb', 'ana.maric@example.com', '0912345678'),
   ('Ivan Horvat', 'Trg Stjepana Radića 5, Split', 'ivan.horvat@example.com', '0987654321'),
   ('Luka Novaković', 'Pere Grge 15, Osijek', 'luka.novakovic@example.com', '0951234567'),
   ('Petra Kovačić', 'Gundulićeva ulica 20, Rijeka', 'petra.kovacic@example.com', '0998765432'),
   ('Marko Petrović', 'Vukovarska ulica 25, Zadar', 'marko.petrovic@example.com', '0923456789');

INSERT INTO Transakcije
VALUES
   (1, 1, '2023-04-01', '2023-04-08', 'Posuđeno'),
   (2, 3, '2023-04-02', '2023-04-09', 'Posuđeno'),
   (3, 2, '2023-04-03', '2023-04-10', 'Vraćeno'),
   (4, 4, '2023-04-04', '2023-04-11', 'Posuđeno'),
   (5, 5, '2023-04-05', '2023-04-12', 'Posuđeno'),
   (2, 1, '2023-04-06', '2023-04-13', 'Vraćeno'),
   (3, 3, '2023-04-07', '2023-04-14', 'Posuđeno'),
   (4, 2, '2023-04-08', '2023-04-15', 'Vraćeno'),
   (5, 4, '2023-04-09', '2023-04-16', 'Vraćeno'),
   (1, 5, '2023-04-10', '2023-04-17', 'Posuđeno'),
   (3, 2, '2023-04-11', '2023-04-18', 'Posuđeno'),
   (1, 1, '2023-04-12', '2023-04-19', 'Posuđeno'),
   (4, 3, '2023-04-13', '2023-04-20', 'Vraćeno'),
   (5, 5, '2023-04-14', '2023-04-21', 'Vraćeno'),
   (2, 4, '2023-04-15', '2023-04-22', 'Vraćeno');

INSERT INTO Login (PosuditeljID, Username, Password)
VALUES
    (1, 'user1', 'password1'),
    (2, 'user2', 'password2'),
    (3, 'user3', 'password3'),
    (4, 'user4', 'password4'),
    (5, 'user5', 'password5'),
	(6, 'user6', 'password6'),
    (7, 'user7', 'password7'),
    (8, 'user8', 'password8'),
    (9, 'user9', 'password9'),
    (10, 'user10', 'password10'),
	(11, 'user11', 'password11'),
    (12, 'user12', 'password12'),
    (13, 'user13', 'password13'),
    (14, 'user14', 'password14'),
    (15, 'user15', 'password15');

SELECT * 
FROM Knjige;

SELECT * 
FROM Posuditelji;

SELECT * 
FROM Transakcije;

SELECT T.TransakcijaID, B.Naslov, B.Autor, P.ImePrezime, P.Adresa, P.Email, P.Telefon
FROM Transakcije T
INNER JOIN Knjige B ON T.KnjigaID = B.KnjigaID
INNER JOIN Posuditelji P ON T.PosuditeljID = P.PosuditeljID
WHERE T.Status = 'Posuđeno';

CREATE VIEW InventarKnjiga AS 
SELECT KnjigaID, Naslov, Autor, Zanr, DostupneKopije, Lokacija
FROM Knjige;

CREATE VIEW PosuditeljInformacije AS
SELECT ImePrezime, Adresa, Email, Telefon
FROM Posuditelji;

CREATE VIEW PosudeneKnjige AS
SELECT T.TransakcijaID, K.Naslov AS Knjiga, P.ImePrezime AS Posuditelj, T.DatumPosudbe, T.DatumVracanja, T.Status
FROM Transakcije T
JOIN Knjige K ON T.KnjigaID = K.KnjigaID
JOIN Posuditelji P ON T.PosuditeljID = P.PosuditeljID
WHERE T.Status = 'Posuđeno';

CREATE VIEW NevraceneKnjige AS
SELECT T.TransakcijaID, K.Naslov AS Knjiga, P.ImePrezime AS Posuditelj, T.DatumPosudbe, T.DatumVracanja, T.Status
FROM Transakcije T
JOIN Knjige K ON T.KnjigaID = K.KnjigaID
JOIN Posuditelji P ON T.PosuditeljID = P.PosuditeljID
WHERE T.Status = 'Posuđeno' AND T.DatumVracanja < GETDATE();

CREATE VIEW PopularneKnjige AS
SELECT K.Naslov AS Knjiga, COUNT(*) AS BrojPosudbi
FROM Transakcije T
JOIN Knjige K ON T.KnjigaID = K.KnjigaID
GROUP BY K.Naslov;

SELECT Knjiga, BrojPosudbi
FROM PopularneKnjige
ORDER BY BrojPosudbi DESC;

SELECT *
FROM NevraceneKnjige

SELECT *
FROM PosudeneKnjige

SELECT *
FROM PosuditeljInformacije

SELECT *
FROM Login
