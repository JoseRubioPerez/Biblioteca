CREATE PROCEDURE [dbo].[ReporteServiciosPorSexo]
@servicio TINYINT,
@sexo CHAR(1)
AS
BEGIN
SELECT dbo.Movimientos.id AS 'REGISTRO'
,dbo.Usuarios.nc AS 'NUMERO DE CONTROL'
,dbo.Usuarios.nombres AS 'NOMBRES'
,dbo.Usuarios.apellidopat AS 'APELLIDO PATERNO'
,dbo.Usuarios.apellidomat AS 'APELLIDO MATERNO'
,dbo.Servicios.servicio AS 'SERVICIO'
,(SELECT FORMAT(dbo.Movimientos.hora,'hh\:mm')) AS 'HORA'
,(SELECT FORMAT(dbo.Movimientos.fecha,'dd/MM/yyyy','es-US')) AS 'FECHA'
FROM dbo.Movimientos INNER JOIN dbo.Usuarios ON Usuarios.nc = Movimientos.nc
INNER JOIN dbo.Servicios ON Servicios.id = Movimientos.servicio
WHERE dbo.Movimientos.servicio = @servicio
AND dbo.Usuarios.sexo = @sexo
END