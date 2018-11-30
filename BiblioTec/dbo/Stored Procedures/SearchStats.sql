CREATE PROCEDURE [dbo].[SearchStats] @p1 CHAR(1) --Sexo Inicio
	,@p2 CHAR(1) --Sexo Fin
	,@p3 TINYINT --Servicio 1
	,@p4 TINYINT --Servicio 2
	,@p5 TINYINT --Servicio 3
	,@p6 TINYINT --Servicio 4
	,@p7 TINYINT --Servicio 5
	,@p8 TINYINT --Servicio 6
	,@p9 TINYINT --Servicio 7
	,@p10 VARCHAR(10) --Fecha Inicio
	,@p11 VARCHAR(10) --Fecha Fin
AS
BEGIN
	SELECT a.id AS 'REGISTRO'
		,a.nc AS 'NUMERO DE CONTROL'
		,b.nombres AS 'NOMBRES'
		,b.apellidopat AS 'APELLIDO PATERNO'
		,b.apellidomat AS 'APELLIDO MATERNO'
		,b.sexo AS 'SEXO'
		,UPPER(c.area) AS 'DEPARTAMENTO O CARRERA'
		,UPPER(d.servicio) AS 'SERVICIO'
		,(
			SELECT UPPER(FORMAT(a.fecha, 'MMMM dd DE yyyy', 'es-US'))
			) AS 'FECHA'
		,(
			SELECT FORMAT(a.hora, 'hh\:mm')
			) AS 'HORA'
	FROM dbo.Movimientos AS a
	INNER JOIN dbo.Usuarios AS b ON b.nc = a.nc
	INNER JOIN dbo.Areas AS c ON c.id = b.area
	INNER JOIN dbo.Servicios AS d ON d.id = a.servicio
	WHERE a.fecha BETWEEN CAST(@p10 AS DATE)
			AND CAST(@p11 AS DATE)
		AND d.id IN (
			@p3
			,@p4
			,@p5
			,@p6
			,@p7
			,@p8
			,@p9
			)
		AND b.sexo IN (
			@p1
			,@p2
			)
	ORDER BY a.id ASC
END

