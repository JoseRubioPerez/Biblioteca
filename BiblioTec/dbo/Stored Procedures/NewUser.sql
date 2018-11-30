CREATE PROCEDURE NewUser
@p1 VARCHAR(9),
@p2 VARCHAR(20),
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