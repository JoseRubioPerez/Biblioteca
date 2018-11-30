CREATE PROCEDURE [dbo].[DeleteAdmin]
@p1 VARCHAR(9)
AS
DELETE FROM dbo.Administradores
WHERE DBO.Administradores.nc = @p1