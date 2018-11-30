CREATE PROCEDURE [dbo].[LoadUsers]
AS
SELECT a.nc AS 'NUMERO DE CONTROL'
,a.nombres AS 'NOMBRES'
,a.apellidopat AS 'APELLIDO PATERNO'
,a.apellidomat AS 'APELLIDO MATERNO'
,a.sexo AS 'SEXO'
,b.area AS 'DEPARTAMENTO O CARRERA'
,a.status AS 'STATUS'
,(SELECT FORMAT(a.hora,'hh\:mm')) AS 'HORA'
,(SELECT FORMAT(a.fecha,'dd/MM/yyyy','es-US')) AS 'FECHA'
FROM dbo.Usuarios AS a
INNER JOIN dbo.Areas AS b ON b.id = a.area