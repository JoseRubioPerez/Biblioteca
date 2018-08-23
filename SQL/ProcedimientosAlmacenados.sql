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
SELECT dbo.Usuarios.nc, dbo.Usuarios.nombres, dbo.Usuarios.apellidopat, dbo.Usuarios.apellidomat, dbo.Usuarios.sexo, dbo.Areas.area, dbo.Usuarios.status, dbo.Usuarios.hora, dbo.Usuarios.fecha 
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
SELECT dbo.Movimientos.id,dbo.Movimientos.nc,dbo.Servicios.servicio,dbo.Movimientos.hora,dbo.Movimientos.fecha FROM dbo.Movimientos
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
@index TINYINT,
@sexo TINYINT
AS
BEGIN
IF @index = 0 --Baños
	IF @sexo = 1
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
		WHERE dbo.Servicios.servicio LIKE '%Baños%' AND dbo.Usuarios.sexo = 'M'
	ELSE
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
		WHERE dbo.Servicios.servicio LIKE '%Baños%' AND dbo.Usuarios.sexo = 'H'
ELSE IF @index = 1 --Bases de datos
	IF @sexo = 1
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
		WHERE dbo.Servicios.servicio LIKE '%Bases de datos%' AND dbo.Usuarios.sexo = 'M'
	ELSE
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
		WHERE dbo.Servicios.servicio LIKE '%Bases de datos%' AND dbo.Usuarios.sexo = 'H'
ELSE IF @index = 2 --Consulta o Referencia
	IF @sexo = 1
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
		WHERE dbo.Servicios.servicio LIKE '%Consulta o Referencia%'  AND dbo.Usuarios.sexo = 'M'
	ELSE
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
		WHERE dbo.Servicios.servicio LIKE '%Consulta o Referencia%'  AND dbo.Usuarios.sexo = 'H'
ELSE IF @index = 3 --Cubículos
	IF @sexo = 1
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
		WHERE dbo.Servicios.servicio LIKE 'Cubículos%' AND dbo.Usuarios.sexo = 'M'
	ELSE
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
		WHERE dbo.Servicios.servicio LIKE 'Cubículos%' AND dbo.Usuarios.sexo = 'H'
ELSE IF @index = 4 --Otros
	IF @sexo = 1
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
		WHERE dbo.Servicios.servicio LIKE '%Otros%' AND dbo.Usuarios.sexo = 'M'
	ELSE
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
		WHERE dbo.Servicios.servicio LIKE '%Otros%' AND dbo.Usuarios.sexo = 'H'
ELSE IF @index = 5 --Sala de Lectura
	IF @sexo = 1
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
		WHERE dbo.Servicios.servicio LIKE '%Sala de Lectura%' AND dbo.Usuarios.sexo = 'M'
	ELSE
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
		WHERE dbo.Servicios.servicio LIKE '%Sala de Lectura%' AND dbo.Usuarios.sexo = 'H'
ELSE IF @index = 6 --Sala de Trabajo en Equipo
	IF @sexo = 1
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
		WHERE dbo.Servicios.servicio LIKE '%Sala de Trabajo en Equipo%' AND dbo.Usuarios.sexo = 'M'
	ELSE
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
		WHERE dbo.Servicios.servicio LIKE '%Sala de Trabajo en Equipo%' AND dbo.Usuarios.sexo = 'H'
END
