CREATE PROCEDURE [dbo].[Search]
@nc VARCHAR(9),
@nombres VARCHAR(20),
@apellidopat VARCHAR(20),
@apellidomat VARCHAR(20),
@sexo CHAR(1),
@area VARCHAR(70),
@status CHAR(1),
@index TINYINT
AS
BEGIN
IF @index = 0 --Número de Control
SELECT dbo.Usuarios.nc
,dbo.Usuarios.nombres
,dbo.Usuarios.apellidopat
,dbo.Usuarios.apellidomat
,dbo.Usuarios.sexo
,dbo.Areas.area
,dbo.Usuarios.status
,(SELECT FORMAT(dbo.Usuarios.hora,'hh\:mm')) AS hora
,(SELECT FORMAT(dbo.Usuarios.fecha,'dd/MM/yyyy','es-US')) AS fecha
FROM dbo.Usuarios 
INNER JOIN dbo.Areas ON Areas.id = Usuarios.area WHERE dbo.Usuarios.nc LIKE '%' + @nc + '%'

ELSE IF @index = 1 --Nombres
SELECT dbo.Usuarios.nc
,dbo.Usuarios.nombres
,dbo.Usuarios.apellidopat
,dbo.Usuarios.apellidomat
,dbo.Usuarios.sexo
,dbo.Areas.area
,dbo.Usuarios.status
,(SELECT FORMAT(dbo.Usuarios.hora,'hh\:mm')) AS hora
,(SELECT FORMAT(dbo.Usuarios.fecha,'dd/MM/yyyy','es-US')) AS fecha
FROM dbo.Usuarios 
INNER JOIN dbo.Areas ON Areas.id = Usuarios.area WHERE dbo.Usuarios.nombres LIKE '%' + @nombres + '%'

ELSE IF @index = 2 --Ambos apellidos
SELECT dbo.Usuarios.nc
,dbo.Usuarios.nombres
,dbo.Usuarios.apellidopat
,dbo.Usuarios.apellidomat
,dbo.Usuarios.sexo
,dbo.Areas.area
,dbo.Usuarios.status
,(SELECT FORMAT(dbo.Usuarios.hora,'hh\:mm')) AS hora
,(SELECT FORMAT(dbo.Usuarios.fecha,'dd/MM/yyyy','es-US')) AS fecha
FROM dbo.Usuarios 
INNER JOIN dbo.Areas ON Areas.id = Usuarios.area WHERE dbo.Usuarios.apellidopat LIKE '%' + @apellidopat + '%' AND dbo.Usuarios.apellidomat LIKE '%' + @apellidomat + '%'

ELSE IF @index = 3 --Sexo
SELECT dbo.Usuarios.nc
,dbo.Usuarios.nombres
,dbo.Usuarios.apellidopat
,dbo.Usuarios.apellidomat
,dbo.Usuarios.sexo
,dbo.Areas.area
,dbo.Usuarios.status
,(SELECT FORMAT(dbo.Usuarios.hora,'hh\:mm')) AS hora
,(SELECT FORMAT(dbo.Usuarios.fecha,'dd/MM/yyyy','es-US')) AS fecha
FROM dbo.Usuarios 
INNER JOIN dbo.Areas ON Areas.id = Usuarios.area WHERE dbo.Usuarios.sexo LIKE '%' + @sexo + '%'

ELSE IF @index = 4 --Carrera o departamento
SELECT dbo.Usuarios.nc
,dbo.Usuarios.nombres
,dbo.Usuarios.apellidopat
,dbo.Usuarios.apellidomat
,dbo.Usuarios.sexo
,dbo.Areas.area
,dbo.Usuarios.status
,(SELECT FORMAT(dbo.Usuarios.hora,'hh\:mm')) AS hora
,(SELECT FORMAT(dbo.Usuarios.fecha,'dd/MM/yyyy','es-US')) AS fecha
FROM dbo.Usuarios 
INNER JOIN dbo.Areas ON Areas.id = Usuarios.area WHERE dbo.Areas.area LIKE '%' + @area + '%'

ELSE IF @index = 5 --Status del usuario
SELECT dbo.Usuarios.nc
,dbo.Usuarios.nombres
,dbo.Usuarios.apellidopat
,dbo.Usuarios.apellidomat
,dbo.Usuarios.sexo
,dbo.Areas.area
,dbo.Usuarios.status
,(SELECT FORMAT(dbo.Usuarios.hora,'hh\:mm')) AS hora
,(SELECT FORMAT(dbo.Usuarios.fecha,'dd/MM/yyyy','es-US')) AS fecha
FROM dbo.Usuarios 
INNER JOIN dbo.Areas ON Areas.id = Usuarios.area WHERE dbo.Usuarios.status LIKE '%' + @status + '%'
END