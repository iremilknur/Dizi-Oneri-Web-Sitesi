CREATE TABLE Diziler
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Baslik NVARCHAR(100),
    Resim NVARCHAR(250),
    Aciklama NVARCHAR(MAX),
    Kategori NVARCHAR(50)
);
INSERT INTO Diziler
(Baslik, Resim, Aciklama, Kategori)
VALUES
('Stranger Things',
'Images/uploads/strangerthings.jpg',
'Gizem, bilim kurgu ve macera dizisi.',
'Bilim Kurgu'),


('The Last of Us',
'Images/uploads/thelastofus.jpg',
'Hayatta kalma temalı macera dizisi.',
'Dram'),


('Breaking Bad',
'Images/uploads/breakingbad.jpg',
'Kimya öğretmeninin suç dünyasına girişini anlatır.',
'Suç');
