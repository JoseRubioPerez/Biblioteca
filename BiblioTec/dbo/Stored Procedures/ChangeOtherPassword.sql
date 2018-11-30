CREATE PROCEDURE ChangeOtherPassword
@nc VARCHAR(9),
@newpass VARCHAR(32)
AS
UPDATE Administradores SET password = @newpass WHERE nc = @nc