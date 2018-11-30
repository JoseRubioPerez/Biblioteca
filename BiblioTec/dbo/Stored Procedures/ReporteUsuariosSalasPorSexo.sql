CREATE PROCEDURE ReporteUsuariosSalasPorSexo
@index TINYINT
AS
BEGIN
IF @index = 1
SELECT dbo.Movimientos.id,
dbo.Usuarios.nc,
dbo.Usuarios.nombres,
dbo.Usuarios.apellidopat,
dbo.Usuarios.apellidomat,
dbo.Servicios.servicio,
dbo.Movimientos.hora,
dbo.Movimientos.fecha
FROM dbo.Movimientos INNER JOIN dbo.Usuarios ON Usuarios.nc = Movimientos.nc
INNER JOIN dbo.Servicios ON dbo.Servicios.id = dbo.Movimientos.servicio
WHERE dbo.Movimientos.servicio = 4 AND dbo.Usuarios.sexo = 'M' OR dbo.Movimientos.servicio = 5 AND dbo.Usuarios.sexo = 'M'
ELSE IF @index = 2
SELECT dbo.Movimientos.id,
dbo.Usuarios.nc,
dbo.Usuarios.nombres,
dbo.Usuarios.apellidopat,
dbo.Usuarios.apellidomat,
dbo.Servicios.servicio,
dbo.Movimientos.hora,
dbo.Movimientos.fecha
FROM dbo.Movimientos INNER JOIN dbo.Usuarios ON Usuarios.nc = Movimientos.nc
INNER JOIN dbo.Servicios ON dbo.Servicios.id = dbo.Movimientos.servicio
WHERE dbo.Movimientos.servicio = 4 AND dbo.Usuarios.sexo = 'H' OR dbo.Movimientos.servicio = 5 AND dbo.Usuarios.sexo = 'H'
END