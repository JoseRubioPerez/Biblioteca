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

--SP DE BÚSQUEDAS

--SP PARA BUSCAR TODO EN LA TABLA USUARIOS TOMANDO EL NÚMERO DE CONTROL
CREATE PROCEDURE SearchNC
@nc VARCHAR(9) AS BEGIN SELECT * FROM dbo.Usuarios WHERE dbo.Usuarios.nc LIKE @nc END GO

--SP PARA BUSCAR TODO EN LA TABLA USUARIOS TOMANDO LOS NOMBRES
CREATE PROCEDURE SearchNombres
@nombres VARCHAR(20)
AS BEGIN SELECT * FROM dbo.Usuarios WHERE dbo.Usuarios.nombres LIKE @nombres END

--SP PARA BUSCAR TODO EN LA TABLA USUARIOS TOMANDO LOS 2 APELLIDOS
CREATE PROCEDURE SearchFullApellido
@apellidopat VARCHAR(20), @apellidomat VARCHAR(20)
AS
BEGIN
IF @apellidomat = ''
SELECT * FROM dbo.Usuarios WHERE dbo.Usuarios.apellidopat LIKE @apellidopat
ELSE
SELECT * FROM dbo.Usuarios WHERE dbo.Usuarios.apellidopat LIKE @apellidopat AND dbo.Usuarios.apellidomat LIKE @apellidomat
END GO

--SP PARA BUSCAR TODO EN LA TABLA USUARIOS TOMANDO EL APELLIDO PATERNO
CREATE PROCEDURE SearchApellidoPat
@apellidopat VARCHAR(20)
AS BEGIN SELECT * FROM dbo.Usuarios WHERE dbo.Usuarios.apellidopat LIKE @apellidopat END GO

--SP PARA BUSCAR TODO EN LA TABLA USUARIOS TOMANDO EL APELLIDO MATERNO
CREATE PROCEDURE SearchApellidoMat
@apellidomat VARCHAR(20)
AS BEGIN SELECT * FROM dbo.Usuarios WHERE dbo.Usuarios.apellidomat LIKE @apellidomat END GO

--SP PARA BUSCAR TODO EN LA TABLA USUARIOS TOMANDO LA CARRERA O DEPARTAMENTO
CREATE PROCEDURE SearchCarreraDepa
@carreraDepa VARCHAR(70)
AS BEGIN SELECT dbo.Usuarios.nc, dbo.Usuarios.nombres, dbo.Usuarios.apellidopat, dbo.Usuarios.apellidomat,
dbo.Usuarios.sexo, dbo.Areas.area, dbo.Usuarios.status, dbo.Usuarios.hora, dbo.Usuarios.fecha
FROM dbo.Usuarios 
INNER JOIN dbo.Areas ON Areas.id = Usuarios.area WHERE dbo.Areas.area LIKE '%' + @carreraDepa + '%' END GO

--SP PARA BUSCAR TODO EN LA TABLA USUARIOS TOMANDO EL STATUS DEL USUARIO
CREATE PROCEDURE SearchStatus
@status CHAR(1)
AS BEGIN SELECT * FROM dbo.Usuarios WHERE dbo.Usuarios.status LIKE @status END GO

--SP PARA BUSCAR CUALQUIER CAMPO DE LA TABLA USUARIOS
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
IF @index = 0 --Número de Control
SELECT dbo.Usuarios.nc, dbo.Usuarios.nombres, dbo.Usuarios.apellidopat, dbo.Usuarios.apellidomat,dbo.Usuarios.sexo,
dbo.Areas.area, dbo.Usuarios.status, dbo.Usuarios.hora, dbo.Usuarios.fecha
FROM dbo.Usuarios 
INNER JOIN dbo.Areas ON Areas.id = Usuarios.area WHERE dbo.Usuarios.nc LIKE '%' + @nc + '%'

ELSE IF @index = 1 --Nombres
SELECT dbo.Usuarios.nc, dbo.Usuarios.nombres, dbo.Usuarios.apellidopat, dbo.Usuarios.apellidomat,dbo.Usuarios.sexo,
dbo.Areas.area, dbo.Usuarios.status, dbo.Usuarios.hora, dbo.Usuarios.fecha
FROM dbo.Usuarios 
INNER JOIN dbo.Areas ON Areas.id = Usuarios.area WHERE dbo.Usuarios.nombres LIKE '%' + @nombres + '%'

ELSE IF @index = 2 --Ambos apellidos
SELECT dbo.Usuarios.nc, dbo.Usuarios.nombres, dbo.Usuarios.apellidopat, dbo.Usuarios.apellidomat,dbo.Usuarios.sexo,
dbo.Areas.area, dbo.Usuarios.status, dbo.Usuarios.hora, dbo.Usuarios.fecha
FROM dbo.Usuarios 
INNER JOIN dbo.Areas ON Areas.id = Usuarios.area WHERE dbo.Usuarios.apellidopat LIKE '%' + @apellidopat + '%' AND dbo.Usuarios.apellidomat LIKE '%' + @apellidomat + '%'

ELSE IF @index = 3 --Sexo
SELECT dbo.Usuarios.nc, dbo.Usuarios.nombres, dbo.Usuarios.apellidopat, dbo.Usuarios.apellidomat,dbo.Usuarios.sexo,
dbo.Areas.area, dbo.Usuarios.status, dbo.Usuarios.hora, dbo.Usuarios.fecha
FROM dbo.Usuarios 
INNER JOIN dbo.Areas ON Areas.id = Usuarios.area WHERE dbo.Usuarios.sexo LIKE '%' + @sexo + '%'

ELSE IF @index = 4 --Carrera o departamento
SELECT dbo.Usuarios.nc, dbo.Usuarios.nombres, dbo.Usuarios.apellidopat, dbo.Usuarios.apellidomat,dbo.Usuarios.sexo,
dbo.Areas.area, dbo.Usuarios.status, dbo.Usuarios.hora, dbo.Usuarios.fecha
FROM dbo.Usuarios 
INNER JOIN dbo.Areas ON Areas.id = Usuarios.area WHERE dbo.Areas.area LIKE '%' + @area + '%'

ELSE IF @index = 5 --Status del usuario
SELECT dbo.Usuarios.nc, dbo.Usuarios.nombres, dbo.Usuarios.apellidopat, dbo.Usuarios.apellidomat,dbo.Usuarios.sexo,
dbo.Areas.area, dbo.Usuarios.status, dbo.Usuarios.hora, dbo.Usuarios.fecha
FROM dbo.Usuarios 
INNER JOIN dbo.Areas ON Areas.id = Usuarios.area WHERE dbo.Usuarios.status LIKE '%' + @status + '%'
END