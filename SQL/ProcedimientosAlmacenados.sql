--PROCEDIMIENTOS ALMACENADOS DE LA BASE DE DATOS "pBiblioteca"

--SP PARA LOGEO DE USUARIO
CREATE PROCEDURE Logeo
@user VARCHAR(9),
@pass VARCHAR(32)
AS
SELECT nc,password,superus FROM Administradores WHERE nc = @user AND password = @pass
END

--SP PARA CAMBIO DE CONTRASEÑA
CREATE PROCEDURE ChangePassword
@user VARCHAR(9),
@pass VARCHAR(32),
@newpass VARCHAR(32)
AS
UPDATE Administradores SET password = @newpass WHERE password = @pass AND nc = @user
END

--SP PARA CAMBIO DE CONTRASEÑA DE OTROS ADMINISTRADORES
CREATE PROCEDURE ChangeOtherPassword
@nc VARCHAR(9),
@newpass VARCHAR(32)
AS
UPDATE Administradores SET password = @newpass WHERE nc = @nc
END

--SP PARA CONSULTAR TODOS LOS ADMINISTRADORES QUE NO SON SUPER USUARIOS Y MOSTRARLOS EN UN COMBOBOX
CREATE PROCEDURE ComboAdministradores
AS
BEGIN
SELECT nc, nombres, apellidopat, apellidomat FROM dbo.Administradores WHERE superus = 'N' ORDER BY nc
END

--SP PARA CARGAR TODOS LOS ADMINISTRADORES DEL SISTEMA SIN CARGAR LA CONTRASEÑA
CREATE PROCEDURE CargarAdministradores
AS
SELECT nc, nombres, apellidopat, apellidomat, sexo, hora, fecha, superus FROM dbo.Administradores

--SP PARA CARGAR TODOS LOS USUARIOS DEL SISTEMA
CREATE PROCEDURE CargarUsuarios
AS
SELECT nc, nombres, apellidopat, apellidomat, sexo, hora, fecha FROM dbo.Usuarios

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

--SP PARA COMPROBAR EXISTENCIA DE UN ADMINISTRADOR EN EL SISTEM
CREATE PROCEDURE ExistAdmin
@nc AS VARCHAR(9)
AS
SELECT * FROM dbo.Administradores WHERE nc = @nc

--SP PARA BORRAR UN ADMINISTRADOR EN EL SISTEMA
CREATE PROCEDURE BorrarAdmin
@nc VARCHAR(9)
AS
DELETE FROM Administradores WHERE nc = @nc

--SP PARA ACTUALIZAR EL PERMISO DE SUPER USUARIO DE UN ADMINISTRADOR
CREATE PROCEDURE UpdateAdmin
@nc AS VARCHAR (9),
@supersu AS CHAR(1)
AS
UPDATE dbo.Administradores SET superus = @supersu WHERE nc = @nc
GO