CREATE PROCEDURE [dbo].[Moves]
@nc VARCHAR(9),
@servicio VARCHAR(60),
@fechaI VARCHAR(10),
@fechaF VARCHAR(10),
@index TINYINT
AS
BEGIN
IF @index = 0 --Número de Control
SELECT dbo.Movimientos.id, dbo.Movimientos.nc, dbo.Servicios.servicio, dbo.Movimientos.hora, dbo.Movimientos.fecha
FROM dbo.Movimientos INNER JOIN dbo.Servicios ON Servicios.id = Movimientos.servicio WHERE dbo.Movimientos.nc LIKE '%' + @nc + '%'

ELSE IF @index = 1 --Servicio
SELECT dbo.Movimientos.id, dbo.Movimientos.nc, dbo.Servicios.servicio, dbo.Movimientos.hora, dbo.Movimientos.fecha
FROM dbo.Movimientos INNER JOIN dbo.Servicios ON Servicios.id = Movimientos.servicio WHERE Servicios.servicio LIKE '%' + @servicio + '%'

ELSE IF @index = 2 --Ambos apellidos
SELECT dbo.Movimientos.id, dbo.Movimientos.nc, dbo.Servicios.servicio, dbo.Movimientos.hora, dbo.Movimientos.fecha
FROM dbo.Movimientos INNER JOIN dbo.Servicios ON Servicios.id = Movimientos.servicio
WHERE dbo.Movimientos.fecha BETWEEN @fechaI AND @fechaF ORDER BY fecha ASC
END