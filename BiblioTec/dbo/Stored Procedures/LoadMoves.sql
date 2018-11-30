CREATE PROCEDURE [dbo].[LoadMoves]
AS
SELECT a.id AS 'ID'
,a.nc AS 'NUMERO DE CONTROL'
,d.area AS 'DEPARTAMENTO/CARRERA'
,c.sexo AS 'SEXO'
,b.servicio AS 'SERVICIO'
,(SELECT FORMAT(a.hora,'hh\:mm')) AS 'HORA'
,(SELECT FORMAT(a.fecha,'dd/MM/yyyy','es-US')) AS 'FECHA'
FROM dbo.Movimientos AS a
INNER JOIN dbo.Servicios AS b ON b.id = a.servicio
INNER JOIN dbo.Usuarios AS c ON c.nc = a.nc
INNER JOIN dbo.Areas AS d ON d.id = c.area