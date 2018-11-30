CREATE PROCEDURE [dbo].[SearchMoves] @p1 VARCHAR(20) --Numero de Control
	,@p2 TINYINT --Index Area Inicio
	,@p3 TINYINT --Index Area Fin
	,@p4 CHAR(1) --Sexo Inicio
	,@p5 CHAR(1) --Sexo Fin
	,@p6 VARCHAR(10) -- Fecha de Inicio
	,@p7 VARCHAR(10) -- Fecha de Fin
AS
BEGIN
	IF @p1 <> ''
	BEGIN
		SELECT a.id AS 'REGISTRO'
			,a.nc AS 'NUMERO DE CONTROL'
			,b.nombres AS 'NOMBRES'
			,b.apellidopat AS 'APELLIDO PATERNO'
			,b.apellidomat AS 'APELLIDO MATERNO'
			,c.area AS 'DEPARTAMENTO O CARRERA'
			,b.sexo AS 'SEXO'
			,(
				SELECT FORMAT(a.fecha, 'dd/MM/yyyy', 'es-US')
				) AS 'FECHA'
			,(
				SELECT FORMAT(a.hora, 'hh\:mm')
				) AS 'HORA'
		FROM dbo.Movimientos AS a
		INNER JOIN dbo.Usuarios AS b ON b.nc = a.nc
		INNER JOIN dbo.Areas AS c ON c.id = b.area
		WHERE @p1 = b.nc
			AND c.id BETWEEN @p2
				AND @p3
			AND b.sexo IN (
				@p4
				,@p5
				)
			AND a.fecha BETWEEN CAST(@p6 AS DATE)
				AND CAST(@p7 AS DATE)
	END
	ELSE
	BEGIN
		SELECT a.id AS 'REGISTRO'
			,a.nc AS 'NUMERO DE CONTROL'
			,b.nombres AS 'NOMBRES'
			,b.apellidopat AS 'APELLIDO PATERNO'
			,b.apellidomat AS 'APELLIDO MATERNO'
			,c.area AS 'DEPARTAMENTO O CARRERA'
			,b.sexo AS 'SEXO'
			,(
				SELECT FORMAT(a.fecha, 'dd/MM/yyyy', 'es-US')
				) AS 'FECHA'
			,(
				SELECT FORMAT(a.hora, 'hh\:mm')
				) AS 'HORA'
		FROM dbo.Movimientos AS a
		INNER JOIN dbo.Usuarios AS b ON b.nc = a.nc
		INNER JOIN dbo.Areas AS c ON c.id = b.area
		WHERE c.id BETWEEN @p2
				AND @p3
			AND b.sexo IN (
				@p4
				,@p5
				)
			AND a.fecha BETWEEN CAST(@p6 AS DATE)
				AND CAST(@p7 AS DATE)
	END
END

