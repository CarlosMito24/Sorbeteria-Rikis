CREATE DATABASE Sorbeteria 
GO

USE Sorbeteria
GO

CREATE TABLE Ventas 
(
ID int Primary Key IDENTITY(1,1)   NOT NULL,
NombreCliente nchar (50)  NOT NULL,

CantidadProducto1 int,
Producto1 nchar (50),
PrecioProducto1 nchar (50),

CantidadProducto2 int,
Producto2 nchar (50),
PrecioProducto2 nchar (50),

CantidadProducto3 int,
Producto3 nchar (50),
PrecioProducto3 nchar (50),

CantidadProducto4 int,
Producto4 nchar (50),
PrecioProducto4 nchar (50),

Total nchar(50),
)
GO

CREATE TABLE Usuarios 
(
Usuario nchar (50),
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