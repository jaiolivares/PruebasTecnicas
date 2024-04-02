--drop table VENTAS

--#region Tablas - INICIO
/*
	CREATE TABLE CLIENTES
	(
		COD INT PRIMARY KEY IDENTITY(1,1),
		NOMBRE VARCHAR(100)
	)

	GO

	CREATE TABLE VENTAS
	(
		COD_VENTA INT PRIMARY KEY IDENTITY(1,1),
		COD_CLIENTE INT,
		MONTO DECIMAL (18,3)
	)

	GO

	INSERT INTO CLIENTES VALUES 
	('Andrés Gómez'),
	('Maite Rojas'),
	('Pedro Sáez'),
	('Vicente López'),
	('Juan Qui...'),
	('Claudia Aranda'),
	('Helena Soto'),
	('Carolina Pérez'),
	('Sergio Cauil'),
	('Ana Miranda')

	GO

	INSERT INTO VENTAS VALUES 
	(1, 132.627),
	(3, 985.978),
	(5, 274.381),
	(7, 847.927),
	(8, 561.051),
	(1, 337.027),
	(9, 532.272),
	(10, 314.011),
	(6, 946.757),
	(1, 535.739)
*/
--#region Tablas - FIN
/*
SELECT * FROM CLIENTES
SELECT * FROM VENTAS
*/

--a) Las ventaws superiores a 500.000
SELECT COD_VENTA, COD_CLIENTE, MONTO
FROM VENTAS
WHERE MONTO > 500.000

--b) La venta más alta
SELECT MAX(MONTO) AS 'VentaMasAlta'
FROM VENTAS

--c) Total de ventas en orden descendente
SELECT COD_VENTA, COD_CLIENTE, MONTO
FROM VENTAS
ORDER BY MONTO DESC

--d) Total de ventas por cliente
SELECT cli.NOMBRE, ven.COD_CLIENTE, SUM(ven.MONTO) As TotalVentas
FROM VENTAS ven
	INNER JOIN CLIENTES cli
		ON cli.COD = ven.COD_CLIENTE
GROUP BY cli.NOMBRE, ven.COD_CLIENTE

--e) Los 3 clientes con ventas más altas
SELECT TOP 3
	cli.NOMBRE, ven.COD_CLIENTE, SUM(ven.MONTO) As TotalVentas
FROM VENTAS ven
	INNER JOIN CLIENTES cli
		ON cli.COD = ven.COD_CLIENTE
GROUP BY cli.NOMBRE, ven.COD_CLIENTE
ORDER BY TotalVentas DESC