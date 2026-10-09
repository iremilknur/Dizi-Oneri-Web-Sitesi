CREATE TABLE Diziler
(
    DiziID int IDENTITY(1,1) PRIMARY KEY,
    Baslik nvarchar(100) NOT NULL,
    IcerikMetni nvarchar(MAX),
    Resim nvarchar(200),
    Tur nvarchar(100),
    Imdb float NOT NULL,
    IzlemeLinki nvarchar(300),
    EklenmeTarihi datetime NOT NULL
)