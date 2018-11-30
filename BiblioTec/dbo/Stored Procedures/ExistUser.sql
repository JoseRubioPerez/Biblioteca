CREATE PROCEDURE [dbo].[ExistUser]
@p1 VARCHAR(9)
AS
BEGIN
SELECT a.nombres AS 'NOMBRES'
,a.apellidopat AS 'APELLIDO PATERNO'
,a.apellidomat AS 'APELLIDO MATERNO'
,b.area 'AREA'
FROM dbo.Usuarios AS a
INNER JOIN dbo.Areas AS b ON b.id = a.area
WHERE a.nc = @p1
END