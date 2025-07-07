/*
drop table Usuario
drop table Empresa
drop table UsuarioEmpresa
*/

CREATE TABLE Usuario
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Nombre VARCHAR(30),
	Correo VARCHAR(100),
	FechaNacimiento DATE,
	Activo BIT
)

INSERT INTO Usuario VALUES ('Javier Olivares', 'joz@gmail.com', '19871014', 1)
INSERT INTO Usuario VALUES ('Usuario dos', 'dos@hotmail.com', '19900101', 1)

CREATE TABLE Empresa
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Nombre VARCHAR(30),
	FechaInicio DATETIME,
	FechaTermino DATE,
	Actual BIT
)

INSERT INTO Empresa VALUES ('Goldenfrost', '20070101', '20130430',0)
INSERT INTO Empresa VALUES ('iConstruye', '20150311', '20221231',0)
INSERT INTO Empresa VALUES ('Nueva', '20250722', NULL,1)

CREATE TABLE UsuarioEmpresa
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	IdUsuario INT,
	IdEmpresa INT
)

INSERT INTO UsuarioEmpresa VALUES (NEWID(),(SELECT TOP 1 Id FROM Usuario WHERE Nombre = 'Javier Olivares'),(SELECT TOP 1 Id FROM Empresa WHERE Nombre = 'Goldenfrost'))
INSERT INTO UsuarioEmpresa VALUES (NEWID(),(SELECT TOP 1 Id FROM Usuario WHERE Nombre = 'Javier Olivares'),(SELECT TOP 1 Id FROM Empresa WHERE Nombre = 'iConstruye'))
INSERT INTO UsuarioEmpresa VALUES (NEWID(),(SELECT TOP 1 Id FROM Usuario WHERE Nombre = 'Javier Olivares'),(SELECT TOP 1 Id FROM Empresa WHERE Nombre = 'Nueva'))
INSERT INTO UsuarioEmpresa VALUES (NEWID(),(SELECT TOP 1 Id FROM Usuario WHERE Nombre = 'Usuario dos'),(SELECT TOP 1 Id FROM Empresa WHERE Nombre = 'Nueva'))

SELECT * FROM Usuario
SELECT * FROM Empresa
SELECT * FROM UsuarioEmpresa