--PROCEDIMIENTOS ALMACENADOS DE LA BASE DE DATOS "biblioteca"

--SP PARA LOGEO DE ADMINISTRADORES
CREATE PROCEDURE Logeo
@user VARCHAR(9),
@pass VARCHAR(32)
AS
SELECT nc,password,superus FROM Administradores WHERE nc = @user AND password = @pass
GO
--SP PARA CAMBIO DE CONTRASEÑA
CREATE PROCEDURE ChangePassword
@user VARCHAR(9),
@pass VARCHAR(32),
@newpass VARCHAR(32)
AS
UPDATE Administradores SET password = @newpass WHERE password = @pass AND nc = @user
GO
--SP PARA CAMBIO DE CONTRASEÑA DE OTROS ADMINISTRADORES
CREATE PROCEDURE ChangeOtherPassword
@nc VARCHAR(9),
@newpass VARCHAR(32)
AS
UPDATE Administradores SET password = @newpass WHERE nc = @nc
GO
--SP PARA CONSULTAR TODOS LOS ADMINISTRADORES QUE NO SON SUPER USUARIOS Y MOSTRARLOS EN UN COMBOBOX
CREATE PROCEDURE ComboAdministradores
AS
BEGIN
SELECT nc, nombres, apellidopat, apellidomat FROM dbo.Administradores WHERE superus = 'N' ORDER BY nc
END
GO
--SP PARA CARGAR TODOS LOS ADMINISTRADORES DEL SISTEMA SIN CARGAR LA CONTRASEÑA
CREATE PROCEDURE CargarAdministradores
AS
SELECT nc, nombres, apellidopat, apellidomat, sexo, hora, fecha, superus FROM dbo.Administradores
GO
--SP PARA CARGAR TODAS LAS AREAS DEL SISTEMA
CREATE PROCEDURE CargarAreas
AS
BEGIN
SELECT dbo.Areas.area FROM dbo.Areas
END
GO
--SP PARA CARGAR TODOS LOS USUARIOS DEL SISTEMA
CREATE PROCEDURE CargarUsuarios
AS
SELECT dbo.Usuarios.nc AS 'Número de Control'
,dbo.Usuarios.nombres AS 'Nombres'
,dbo.Usuarios.apellidopat AS 'Apellido Paterno'
,dbo.Usuarios.apellidomat AS 'Apellido Materno'
,dbo.Usuarios.sexo AS 'Sexo'
,dbo.Areas.area AS 'Departamento/Carrera'
,dbo.Usuarios.status AS 'Status'
,(SELECT FORMAT(dbo.Usuarios.hora,'hh\:mm')) AS 'Hora Registro'
,(SELECT FORMAT(dbo.Usuarios.fecha,'dd/MM/yyyy','es-US')) AS 'Fecha Registro'
FROM dbo.Usuarios 
INNER JOIN dbo.Areas ON Areas.id = Usuarios.area
GO
--SP PARA AGREGAR UN NUEVO ADMINISTRADOR SIN FOTO
CREATE PROCEDURE AddNewAdmin
@nc VARCHAR(9),
@nombres VARCHAR(20),
@apellidopat VARCHAR(20),
@apellidomat VARCHAR(20),
@sexo CHAR(1),
@password VARCHAR(32),
@supersu CHAR(1)
AS
INSERT INTO Administradores(nc,nombres,apellidopat,apellidomat,sexo,password,hora,fecha,superus) VALUES
(@nc,@nombres,@apellidopat,@apellidomat,@sexo,@password,CONVERT(TIME,GETDATE(),108),CONVERT(DATE,GETDATE(),103),@supersu)
GO
--SP PARA COMPROBAR EXISTENCIA DE UN ADMINISTRADOR EN EL SISTEM
CREATE PROCEDURE ExistAdmin
@nc AS VARCHAR(9)
AS
SELECT * FROM dbo.Administradores WHERE nc = @nc
GO
--SP PARA BORRAR UN ADMINISTRADOR EN EL SISTEMA
CREATE PROCEDURE BorrarAdmin
@nc VARCHAR(9)
AS
DELETE FROM Administradores WHERE nc = @nc
GO
--SP PARA ACTUALIZAR EL PERMISO DE SUPER USUARIO DE UN ADMINISTRADOR
CREATE PROCEDURE UpdateAdmin
@nc AS VARCHAR (9),
@supersu AS CHAR(1)
AS
UPDATE dbo.Administradores SET superus = @supersu WHERE nc = @nc
GO

--SP PARA MOSTRAR TODOS LOS MOVIMIENTOS REALIZADOS
CREATE PROCEDURE CargarMovimientos
AS
SELECT dbo.Movimientos.id
,dbo.Movimientos.nc
,dbo.Servicios.servicio
,(SELECT FORMAT(dbo.Movimientos.hora,'hh\:mm')) AS hora
,(SELECT FORMAT(dbo.Movimientos.fecha,'dd/MM/yyyy','es-US')) AS fecha
FROM dbo.Movimientos
INNER JOIN dbo.Servicios ON Servicios.id = Movimientos.servicio

GO

--SP PARA AGREGAR NUEVO MOVIMIENTO AL SISTEMA
CREATE PROCEDURE NewMove
@nc VARCHAR(9),
@servicio TINYINT
AS
INSERT INTO dbo.Movimientos (nc,servicio, hora,fecha) VALUES (@nc,@servicio,CONVERT(TIME,GETDATE(),108),CONVERT(DATE,GETDATE(),103))
GO

--SP PARA REGISTRAR EL INICIO DE SESIÓN DE UN ADMINISTRADOR
CREATE PROCEDURE AddRegistry
@nc VARCHAR(9),
@sistema VARCHAR(10)
AS
INSERT INTO dbo.RegLogeo (nc,sistema,hora,fecha) VALUES (@nc,@sistema,CONVERT(TIME,GETDATE(),108),CONVERT(DATE,GETDATE(),103))
GO

--SP PARA REGISTRAR EN LA BITACORA EL INICIO DE SESIÓN DE UN ADMINISTRADOR
CREATE PROCEDURE Bitacora
@nc VARCHAR(9),
@sistema VARCHAR(20),
@accion VARCHAR(7)
AS
BEGIN
INSERT INTO dbo.RegLogeo (nc,sistema, hora,fecha,accion) VALUES (@nc,@sistema,CONVERT(TIME,GETDATE(),108),CONVERT(DATE,GETDATE(),103),@accion)
END
GO


--SP PARA SABER LA EXISTENCIA DE UN USUARIO
CREATE PROCEDURE ExistUsuario
@nc VARCHAR(9)
AS
BEGIN
SELECT dbo.Usuarios.nombres, dbo.Usuarios.apellidopat, dbo.Usuarios.apellidomat, dbo.Areas.area FROM dbo.Usuarios INNER JOIN dbo.Areas ON Areas.id = Usuarios.area WHERE nc = @nc
END
GO

--SP PARA BUSCAR ENTRE CUALQUIER MOVIMIENTO
CREATE PROCEDURE Moves
@nc VARCHAR(9),
@servicio VARCHAR(60),
@fechaI VARCHAR(10),
@fechaF VARCHAR(10),
@index TINYINT
AS
BEGIN
IF @index = 0 --Número de Control
SELECT dbo.Movimientos.id, dbo.Movimientos.nc, dbo.Servicios.servicio, dbo.Movimientos.hora, dbo.Movimientos.fecha
FROM dbo.Movimientos INNER JOIN dbo.Servicios ON Servicios.id = Movimientos.servicio WHERE dbo.Movimientos.nc LIKE '%' + @nc + '%'

ELSE IF @index = 1 --Servicio
SELECT dbo.Movimientos.id, dbo.Movimientos.nc, dbo.Servicios.servicio, dbo.Movimientos.hora, dbo.Movimientos.fecha
FROM dbo.Movimientos INNER JOIN dbo.Servicios ON Servicios.id = Movimientos.servicio WHERE Servicios.servicio LIKE '%' + @servicio + '%'

ELSE IF @index = 2 --Ambos apellidos
SELECT dbo.Movimientos.id, dbo.Movimientos.nc, dbo.Servicios.servicio, dbo.Movimientos.hora, dbo.Movimientos.fecha
FROM dbo.Movimientos INNER JOIN dbo.Servicios ON Servicios.id = Movimientos.servicio
WHERE dbo.Movimientos.fecha BETWEEN @fechaI AND @fechaF ORDER BY fecha ASC
END

--SP PARA CONSULTAR LOS HOMBRES O MUJERES QUE UTILIZAN LOS SERVICIOS 4 Y 5 DEL CENTRO DE INFORMACIÓN
CREATE PROCEDURE ReporteUsuariosSalasPorSexo
@index TINYINT
AS
BEGIN
IF @index = 1
SELECT dbo.Movimientos.id,
dbo.Usuarios.nc,
dbo.Usuarios.nombres,
dbo.Usuarios.apellidopat,
dbo.Usuarios.apellidomat,
dbo.Servicios.servicio,
dbo.Movimientos.hora,
dbo.Movimientos.fecha
FROM dbo.Movimientos INNER JOIN dbo.Usuarios ON Usuarios.nc = Movimientos.nc
INNER JOIN dbo.Servicios ON dbo.Servicios.id = dbo.Movimientos.servicio
WHERE dbo.Movimientos.servicio = 4 AND dbo.Usuarios.sexo = 'M' OR dbo.Movimientos.servicio = 5 AND dbo.Usuarios.sexo = 'M'
ELSE IF @index = 2
SELECT dbo.Movimientos.id,
dbo.Usuarios.nc,
dbo.Usuarios.nombres,
dbo.Usuarios.apellidopat,
dbo.Usuarios.apellidomat,
dbo.Servicios.servicio,
dbo.Movimientos.hora,
dbo.Movimientos.fecha
FROM dbo.Movimientos INNER JOIN dbo.Usuarios ON Usuarios.nc = Movimientos.nc
INNER JOIN dbo.Servicios ON dbo.Servicios.id = dbo.Movimientos.servicio
WHERE dbo.Movimientos.servicio = 4 AND dbo.Usuarios.sexo = 'H' OR dbo.Movimientos.servicio = 5 AND dbo.Usuarios.sexo = 'H'
END
GO

--SP PARA GENERAR LOS REPORTES DE CUALQUIER SERVICIOS
CREATE PROCEDURE ReporteServiciosPorSexo
@servicio TINYINT,
@sexo CHAR(1)
AS
BEGIN
SELECT dbo.Movimientos.id AS 'REGISTRO'
,dbo.Usuarios.nc AS 'NUMERO DE CONTROL'
,dbo.Usuarios.nombres AS 'NOMBRES'
,dbo.Usuarios.apellidopat AS 'APELLIDO PATERNO'
,dbo.Usuarios.apellidomat AS 'APELLIDO MATERNO'
,dbo.Servicios.servicio AS 'SERVICIO'
,(SELECT FORMAT(dbo.Movimientos.hora,'hh\:mm')) AS 'HORA'
,(SELECT FORMAT(dbo.Movimientos.fecha,'dd/MM/yyyy','es-US')) AS 'FECHA'
FROM dbo.Movimientos INNER JOIN dbo.Usuarios ON Usuarios.nc = Movimientos.nc
INNER JOIN dbo.Servicios ON Servicios.id = Movimientos.servicio
WHERE dbo.Movimientos.servicio = @servicio
AND dbo.Usuarios.sexo = @sexo
END

--SP PARA INSERTAR UN NUEVO USUARIO
CREATE PROCEDURE NewUser
@p1 VARCHAR(9),
@P2 VARCHAR(20),
@p3 VARCHAR(20),
@p4 VARCHAR(20),
@p5 CHAR(1),
@p6 TINYINT,
@p7 CHAR(1)
AS
BEGIN
INSERT INTO dbo.Usuarios (nc,nombres,apellidopat,apellidomat,sexo,area,status,foto,hora,fecha)
VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,NULL,CONVERT(TIME,GETDATE(),108),CONVERT(DATE,GETDATE(),103))
END

--SP PARA BUSQUEDAS
CREATE PROCEDURE Search
@nc VARCHAR(9),
@nombres VARCHAR(20),
@apellidopat VARCHAR(20),
@apellidomat VARCHAR(20),
@sexo CHAR(1),
@area VARCHAR(70),
@status CHAR(1),
@index TINYINT
AS
BEGIN
IF @index = 0 --Numero de Control
SELECT dbo.Usuarios.nc
,dbo.Usuarios.nombres
,dbo.Usuarios.apellidopat
,dbo.Usuarios.apellidomat
,dbo.Usuarios.sexo
,dbo.Areas.area
,dbo.Usuarios.status
,(SELECT FORMAT(dbo.Usuarios.hora,'hh\:mm')) AS hora
,(SELECT FORMAT(dbo.Usuarios.fecha,'dd/MM/yyyy','es-US')) AS fecha
FROM dbo.Usuarios
INNER JOIN dbo.Areas ON Areas.id = Usuarios.area WHERE dbo.Usuarios.nc LIKE '%' + @nc + '%'

ELSE IF @index = 1 --Nombres
SELECT dbo.Usuarios.nc
,dbo.Usuarios.nombres
,dbo.Usuarios.apellidopat
,dbo.Usuarios.apellidomat
,dbo.Usuarios.sexo
,dbo.Areas.area
,dbo.Usuarios.status
,(SELECT FORMAT(dbo.Usuarios.hora,'hh\:mm')) AS hora
,(SELECT FORMAT(dbo.Usuarios.fecha,'dd/MM/yyyy','es-US')) AS fecha
FROM dbo.Usuarios
INNER JOIN dbo.Areas ON Areas.id = Usuarios.area WHERE dbo.Usuarios.nombres LIKE '%' + @nombres + '%'

ELSE IF @index = 2 --Ambos apellidos
SELECT dbo.Usuarios.nc
,dbo.Usuarios.nombres
,dbo.Usuarios.apellidopat
,dbo.Usuarios.apellidomat
,dbo.Usuarios.sexo
,dbo.Areas.area
,dbo.Usuarios.status
,(SELECT FORMAT(dbo.Usuarios.hora,'hh\:mm')) AS hora
,(SELECT FORMAT(dbo.Usuarios.fecha,'dd/MM/yyyy','es-US')) AS fecha
FROM dbo.Usuarios
INNER JOIN dbo.Areas ON Areas.id = Usuarios.area WHERE dbo.Usuarios.apellidopat LIKE '%' + @apellidopat + '%' AND dbo.Usuarios.apellidomat LIKE '%' + @apellidomat + '%'

ELSE IF @index = 3 --Sexo
SELECT dbo.Usuarios.nc
,dbo.Usuarios.nombres
,dbo.Usuarios.apellidopat
,dbo.Usuarios.apellidomat
,dbo.Usuarios.sexo
,dbo.Areas.area
,dbo.Usuarios.status
,(SELECT FORMAT(dbo.Usuarios.hora,'hh\:mm')) AS hora
,(SELECT FORMAT(dbo.Usuarios.fecha,'dd/MM/yyyy','es-US')) AS fecha
FROM dbo.Usuarios
INNER JOIN dbo.Areas ON Areas.id = Usuarios.area WHERE dbo.Usuarios.sexo LIKE '%' + @sexo + '%'

ELSE IF @index = 4 --Carrera o departamento
SELECT dbo.Usuarios.nc
,dbo.Usuarios.nombres
,dbo.Usuarios.apellidopat
,dbo.Usuarios.apellidomat
,dbo.Usuarios.sexo
,dbo.Areas.area
,dbo.Usuarios.status
,(SELECT FORMAT(dbo.Usuarios.hora,'hh\:mm')) AS hora
,(SELECT FORMAT(dbo.Usuarios.fecha,'dd/MM/yyyy','es-US')) AS fecha
FROM dbo.Usuarios
INNER JOIN dbo.Areas ON Areas.id = Usuarios.area WHERE dbo.Areas.area LIKE '%' + @area + '%'

ELSE IF @index = 5 --Status del usuario
SELECT dbo.Usuarios.nc
,dbo.Usuarios.nombres
,dbo.Usuarios.apellidopat
,dbo.Usuarios.apellidomat
,dbo.Usuarios.sexo
,dbo.Areas.area
,dbo.Usuarios.status
,(SELECT FORMAT(dbo.Usuarios.hora,'hh\:mm')) AS hora
,(SELECT FORMAT(dbo.Usuarios.fecha,'dd/MM/yyyy','es-US')) AS fecha
FROM dbo.Usuarios
INNER JOIN dbo.Areas ON Areas.id = Usuarios.area WHERE dbo.Usuarios.status LIKE '%' + @status + '%'
END

--SP PARA ACTUALIZAR USUARIO
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
		,STATUS = @p7
	WHERE nc = @p1
END
GO

--SP PARA BUSQUEDAS DE USUARIO
CREATE PROCEDURE SearchUsers @p1 INT --Index
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
			,b.STATUS AS 'STATUS'
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
			,b.STATUS AS 'STATUS'
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
			,b.STATUS AS 'STATUS'
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
GO

--SP PARA INSERTAR USUARIO NUEVO
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
GO

--SP PARA BUSCACR MOVIMIENTOS
CREATE PROCEDURE SearchMoves @p1 VARCHAR(20) --Numero de Control
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