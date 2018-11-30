CREATE PROCEDURE AddUser @p1 VARCHAR(9) --Numero de Control
,@p2 VARCHAR(20) --Nombres
,@p3 VARCHAR(20) --Apellido Paterno
,@p4 VARCHAR(20) --Apellido Materno
,@p5 CHAR(1) --Sexo
,@p6 TINYINT --Area
,@p7 CHAR(1) --Status
AS
BEGIN
INSERT INTO dbo.Usuarios VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, NULL, CONVERT(TIME,GETDATE(),108), CONVERT(DATE,GETDATE(),103))
END
