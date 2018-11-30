CREATE PROCEDURE [dbo].[UpdateAdmin]
@p1 AS VARCHAR (9),
@p2 AS CHAR(1)
AS
BEGIN
UPDATE dbo.Administradores SET superus = @p2
WHERE nc = @p1
END