﻿CREATE PROCEDURE [dbo].[LogRegistry]
@p1 VARCHAR(9),
@p2 VARCHAR(10)
AS
INSERT INTO dbo.RegLogeo (nc,sistema,hora,fecha)
VALUES (@p1,@p2,CONVERT(TIME,GETDATE(),108),CONVERT(DATE,GETDATE(),103))