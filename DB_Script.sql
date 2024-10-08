
-- Creado por Agustín Macoggi
-- https://aguzkind.dev.ar




-- Creación de la base de datos.
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'GYM_Tracker')
BEGIN
    CREATE DATABASE GYM_Tracker;
END

-- Seleccionar la base de datos creada.
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'GYM_Tracker')
BEGIN
    USE GYM_Tracker;
END


-- Creación de tablas
CREATE TABLE Imagenes (
ImagenID INT IDENTITY,
ImgPath VARCHAR(100) NOT NULL,
PRIMARY KEY (ImagenID),
)

CREATE TABLE Dias (
DiaID INT IDENTITY,
Fecha DATE,
Peso DECIMAL (10, 3),
PRIMARY KEY (DiaID),
)

CREATE TABLE Imagen_Dia (
DiaID INT,
ImagenID INT,
FOREIGN KEY (DiaID) REFERENCES Dias(DiaID),
FOREIGN KEY (ImagenID) REFERENCES Imagenes(ImagenID)
)


-- Test
DROP TABLE Imagen_Dia
DROP TABLE Dias
DROP TABLE Imagenes

INSERT INTO Imagenes VALUES ('test')
INSERT INTO Dias (Fecha, Peso) VALUES ('2024-01-01', 115.300)
INSERT INTO Imagen_Dia (DiaID, ImagenID) VALUES (1,1)

SELECT * FROM Imagenes
SELECT * FROM Dias
SELECT * FROM Imagen_Dia
-- Test
