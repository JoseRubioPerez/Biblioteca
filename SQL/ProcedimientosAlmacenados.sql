--PROCEDIMIENTOS ALMACENADOS DE LA BASE DE DATOS "pBiblioteca"

--SP PARA LOGEO DE USUARIO
CREATE PROCEDURE Logeo
@user VARCHAR(9),
@pass VARCHAR(32)
AS
SELECT nc,password,superus FROM Administradores WHERE nc = @user AND password = @pass

--SP PARA CAMBIO DE CONTRASEÑA
CREATE PROCEDURE ChangePassword
@user VARCHAR(9),
@pass VARCHAR(32),
@newpass VARCHAR(32)
AS
UPDATE Administradores SET password = @newpass WHERE password = @pass AND nc = @user