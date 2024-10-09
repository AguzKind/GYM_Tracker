
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
CREATE TABLE Dias (
DiaID INT IDENTITY,
Fecha DATE,
Peso DECIMAL (10, 3),
PRIMARY KEY (DiaID),
)
CREATE TABLE Imagenes (
ImagenID INT IDENTITY,
ImgPath VARCHAR(100) NOT NULL,
DiaID INT,
PRIMARY KEY (ImagenID),
FOREIGN KEY (DiaID) REFERENCES Dias(DiaID)
)