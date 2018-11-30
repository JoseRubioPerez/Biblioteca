CREATE PROCEDURE [dbo].[SearchUsers] @p1 INT --Index
	,@p2 VARCHAR(9) --Numero de Control
	,@p3 VARCHAR(20) --Nombres
	,@p4 VARCHAR(20) --Apellido Paterno
	,@p5 VARCHAR(20) --Apellido Materno
	,@p6 CHAR(1) --Sexo
	,@p7 TINYINT --Departamento o Carrera
	,@p8 CHAR(1) --Status
AS
BEGIN
	DECLARE @NumControl INT = 0
		,@Names INT = 1
		,@FirstLastName INT = 2
		,@SecondLastName INT = 3
		,@BothLastName INT = 4
		,@Sex INT = 5
		,@DepartmentOrCareer INT = 6
		,@Status INT = 7

	IF @p1 = @NumControl
	BEGIN
		SELECT b.nc AS 'NUMERO DE CONTROL'
			,b.nombres AS 'NOMBRES'
			,b.apellidopat AS 'APELLIDO PATERNO'
			,b.apellidomat AS 'APELLIDO MATERNO'
			,c.area AS 'DEPARTAMENTO O CARRERA'
			,b.sexo AS 'SEXO'
			,b.status AS 'STATUS'
		FROM dbo.Usuarios AS b
		INNER JOIN dbo.Areas AS c ON c.id = b.area
		WHERE b.nc = @p2
	END

	IF @p1 = @Names
	BEGIN
		SELECT b.nc AS 'NUMERO DE CONTROL'
			,b.nombres AS 'NOMBRES'
			,b.apellidopat AS 'APELLIDO PATERNO'
			,b.apellidomat AS 'APELLIDO MATERNO'
			,c.area AS 'DEPARTAMENTO O CARRERA'
			,b.sexo AS 'SEXO'
			,b.STATUS AS 'STATUS'
		FROM dbo.Usuarios AS b
		INNER JOIN dbo.Areas AS c ON c.id = b.area
		WHERE b.nombres LIKE '%' + @p3 + '%'
	END

	IF @p1 = @FirstLastName
	BEGIN
		SELECT b.nc AS 'NUMERO DE CONTROL'
			,b.nombres AS 'NOMBRES'
			,b.apellidopat AS 'APELLIDO PATERNO'
			,b.apellidomat AS 'APELLIDO MATERNO'
			,c.area AS 'DEPARTAMENTO O CARRERA'
			,b.sexo AS 'SEXO'
			,b.status AS 'STATUS'
		FROM dbo.Usuarios AS b
		INNER JOIN dbo.Areas AS c ON c.id = b.area
		WHERE b.apellidopat LIKE '%' + @p4 + '%'
	END

	IF @p1 = @SecondLastName
	BEGIN
		SELECT b.nc AS 'NUMERO DE CONTROL'
			,b.nombres AS 'NOMBRES'
			,b.apellidopat AS 'APELLIDO PATERNO'
			,b.apellidomat AS 'APELLIDO MATERNO'
			,c.area AS 'DEPARTAMENTO O CARRERA'
			,b.sexo AS 'SEXO'
			,b.status AS 'STATUS'
		FROM dbo.Usuarios AS b
		INNER JOIN dbo.Areas AS c ON c.id = b.area
		WHERE b.apellidomat LIKE '%' + @p5 + '%'
	END

	IF @p1 = @BothLastName
	BEGIN
		SELECT b.nc AS 'NUMERO DE CONTROL'
			,b.nombres AS 'NOMBRES'
			,b.apellidopat AS 'APELLIDO PATERNO'
			,b.apellidomat AS 'APELLIDO MATERNO'
			,c.area AS 'DEPARTAMENTO O CARRERA'
			,b.sexo AS 'SEXO'
			,b.STATUS AS 'STATUS'
		FROM dbo.Usuarios AS b
		INNER JOIN dbo.Areas AS c ON c.id = b.area
		WHERE b.apellidopat LIKE '%' + @p4 + '%'
			OR b.apellidopat LIKE '%' + @p5 + '%'
			OR b.apellidomat LIKE '%' + @p4 + '%'
			OR b.apellidomat LIKE '%' + @p5 + '%'
	END

	IF @p1 = @Sex
	BEGIN
		SELECT b.nc AS 'NUMERO DE CONTROL'
			,b.nombres AS 'NOMBRES'
			,b.apellidopat AS 'APELLIDO PATERNO'
			,b.apellidomat AS 'APELLIDO MATERNO'
			,c.area AS 'DEPARTAMENTO O CARRERA'
			,b.sexo AS 'SEXO'
			,b.STATUS AS 'STATUS'
		FROM dbo.Usuarios AS b
		INNER JOIN dbo.Areas AS c ON c.id = b.area
		WHERE b.sexo = @p6
	END

	IF @p1 = @DepartmentOrCareer
	BEGIN
		SELECT b.nc AS 'NUMERO DE CONTROL'
			,b.nombres AS 'NOMBRES'
			,b.apellidopat AS 'APELLIDO PATERNO'
			,b.apellidomat AS 'APELLIDO MATERNO'
			,c.area AS 'DEPARTAMENTO O CARRERA'
			,b.sexo AS 'SEXO'
			,b.STATUS AS 'STATUS'
		FROM dbo.Usuarios AS b
		INNER JOIN dbo.Areas AS c ON c.id = b.area
		WHERE c.id = @p7
	END

	IF @p1 = @Status
	BEGIN
		SELECT b.nc AS 'NUMERO DE CONTROL'
			,b.nombres AS 'NOMBRES'
			,b.apellidopat AS 'APELLIDO PATERNO'
			,b.apellidomat AS 'APELLIDO MATERNO'
			,c.area AS 'DEPARTAMENTO O CARRERA'
			,b.sexo AS 'SEXO'
			,b.STATUS AS 'STATUS'
		FROM dbo.Usuarios AS b
		INNER JOIN dbo.Areas AS c ON c.id = b.area
		WHERE b.STATUS = @p8
	END
END
