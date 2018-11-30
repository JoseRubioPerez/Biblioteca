CREATE PROCEDURE [ChangeMyPassword]
@user VARCHAR(9),
@pass VARCHAR(32),
@newpass VARCHAR(32)
AS
UPDATE Administradores SET password = @newpass WHERE password = @pass AND nc = @user