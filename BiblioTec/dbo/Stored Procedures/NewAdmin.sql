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