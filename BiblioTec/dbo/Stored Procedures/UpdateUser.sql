CREATE PROCEDURE UpdateUser @p1 VARCHAR(9) --Número de Control
	,@p2 VARCHAR(20) --Nombres
	,@p3 VARCHAR(20) --Apellido Paterno
	,@p4 VARCHAR(20) --Apellido Materno
	,@p5 CHAR(1) --Sexo
	,@p6 TINYINT --Area
	,@p7 CHAR(1) --Status
AS
BEGIN
	UPDATE dbo.Usuarios
	SET nombres = @p2
		,apellidopat = @p3
		,apellidomat = @p4
		,sexo = @p5
		,area = @p6
		,status = @p7
	WHERE nc = @p1
END
