CREATE DATABASE Sorbeteria 
GO

USE Sorbeteria
GO

CREATE TABLE Ventas 
(
ID int Primary Key IDENTITY(1,1)   NOT NULL,
NombreCliente nchar (50)  NOT NULL,

CantidadConoSimple int,
PrecioProducto1 nchar (50),

CantidadConoSimpleBolaDoble int,
PrecioProducto2 nchar (50),

CantidadConoChocolateSimple int,
PrecioProducto3 nchar (50),

CantidadConoChocolateBolaDoble int,
PrecioProducto4 nchar (50),	

Total nchar(50),
)
GO

CREATE TABLE Usuarios 
(
Usuario nchar (5),
Clave nchar (8),
Acceso int 
)
GO

CREATE PROCEDURE MostrarTabla
AS
SELECT * FROM Ventas
GO

EXEC MostrarTabla 
GO