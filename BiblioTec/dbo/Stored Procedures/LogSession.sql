CREATE PROCEDURE [dbo].[LogSession]
@p1 VARCHAR(9),
@p2 VARCHAR(32)
AS
SELECT a.nc AS 'NUMERO DE CONTROL'
,a.nombres AS 'NOMBRES'
,a.apellidopat AS 'APELLIDO PATERNO'
,a.apellidomat AS 'APELLIDO MATERNO'
,a.sexo AS 'SEXO'
,a.password AS 'PASSWORD'
,(SELECT FORMAT(a.hora,'hh\:mm')) AS 'HORA'
,(SELECT FORMAT(a.fecha,'dd/MM/yyyy','es-US')) AS 'FECHA'
,a.superus AS 'PERMISOS'
FROM dbo.Administradores AS a
WHERE nc = @p1 AND password = @p2