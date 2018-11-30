CREATE PROCEDURE [dbo].[LoadAdmins]
AS
SELECT nc AS 'NUMERO DE CONTROL'
,a.nombres AS 'NOMBRES'
,a.apellidopat AS 'APELLIDO PATERNO'
,a.apellidomat AS 'APELLIDO MATERNO'
,a.sexo AS 'SEXO'
,(SELECT FORMAT(a.hora,'hh\:mm')) AS 'HORA'
,(SELECT FORMAT(a.fecha,'dd/MM/yyyy','es-US')) AS 'FECHA'
,a.superus AS 'PERMISOS'
FROM dbo.Administradores AS a