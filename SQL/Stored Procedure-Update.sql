--Bitacora
--ChangeMyPassword
--ChangeOtherPassword
--ComboAdministradores
CREATE PROCEDURE [dbo].[DeleteAdmin]
@p1 VARCHAR(9)
AS
DELETE FROM dbo.Administradores
WHERE DBO.Administradores.nc = @p1
END
GO

CREATE PROCEDURE [dbo].[ExistAdmin]
@p1 AS VARCHAR(9)
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
WHERE nc = @p1
END
GO

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
END
GO

CREATE PROCEDURE [dbo].[LoadAreas]
AS
BEGIN
SELECT a.id AS 'ID'
,a.area AS 'AREA'
FROM dbo.Areas AS a
END

CREATE PROCEDURE [dbo].[LoadMoves]
AS
SELECT a.id AS 'ID'
,a.nc AS 'NUMERO DE CONTROL'
,d.area AS 'DEPARTAMENTO/CARRERA'
,c.sexo AS 'SEXO'
,b.servicio AS 'SERVICIO'
,(SELECT FORMAT(a.hora,'hh\:mm')) AS 'HORA'
,(SELECT FORMAT(a.fecha,'dd/MM/yyyy','es-US')) AS 'FECHA'
FROM dbo.Movimientos AS a
INNER JOIN dbo.Servicios AS b ON b.id = a.servicio
INNER JOIN dbo.Usuarios AS c ON c.nc = a.nc
INNER JOIN dbo.Areas AS d ON d.id = c.area
END
GO

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
END
GO

CREATE PROCEDURE [dbo].[LogRegistry]
@p1 VARCHAR(9),
@p2 VARCHAR(10)
AS
INSERT INTO dbo.RegLogeo (nc,sistema,hora,fecha)
VALUES (@p1,@p2,CONVERT(TIME,GETDATE(),108),CONVERT(DATE,GETDATE(),103))
END
GO

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
END
GO

CREATE PROCEDURE [dbo].[NewAdmin]
@p1 VARCHAR(9),
@p2 VARCHAR(20),
@p3 VARCHAR(20),
@p4 VARCHAR(20),
@p5 CHAR(1),
@p6 VARCHAR(32),
@p7 CHAR(1)
AS
BEGIN
INSERT INTO Administradores(nc,nombres,apellidopat,apellidomat,sexo,password,hora,fecha,superus)
VALUES (@p1,@p2,@p3,@p4,@p5,@p6,CONVERT(TIME,GETDATE(),108),CONVERT(DATE,GETDATE(),103),@p7)
END

CREATE PROCEDURE [dbo].[NewMove]
@p1 VARCHAR(9),
@p2 TINYINT
AS
BEGIN
INSERT INTO dbo.Movimientos (nc,servicio, hora,fecha)
VALUES (@p1,@p2,CONVERT(TIME,GETDATE(),108),CONVERT(DATE,GETDATE(),103))
END

CREATE PROCEDURE [dbo].[UpdateAdmin]
@p1 AS VARCHAR (9),
@p2 AS CHAR(1)
AS
BEGIN
UPDATE dbo.Administradores SET superus = @p2
WHERE nc = @p1
END

CREATE PROCEDURE ComboSource
@p1 AS INT,
@p2 AS VARCHAR(30)
AS
BEGIN
INSERT INTO TipoBusqueda VALUES(@p1, @p2
,IIF(@p1 = 1, 'USUARIOS'
,IIF(@p1 = 2, 'ADMINISTRADORES'
,IIF(@p1 = 3, 'MOVIMIENTOS','NINGUNO'))));
END

CREATE PROCEDURE LoadFilters
 @p1 TINYINT
AS
BEGIN
SELECT a.id AS 'ID'
,a.idBusqueda AS 'ID MODULO'
,a.Modulo AS 'MODULO'
,a.Descripcion AS 'DESCRIPCION'
FROM dbo.TipoBusqueda AS a WHERE idBusqueda = @p1
END