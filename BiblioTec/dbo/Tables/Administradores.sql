CREATE TABLE [dbo].[Administradores] (
    [nc]          VARCHAR (9)  NOT NULL,
    [nombres]     VARCHAR (20) NOT NULL,
    [apellidopat] VARCHAR (20) NOT NULL,
    [apellidomat] VARCHAR (20) NOT NULL,
    [sexo]        CHAR (1)     NOT NULL,
    [password]    VARCHAR (32) NOT NULL,
    [foto]        IMAGE        NULL,
    [hora]        TIME (7)     NOT NULL,
    [fecha]       DATE         NOT NULL,
    [superus]     CHAR (1)     NOT NULL,
    PRIMARY KEY CLUSTERED ([nc] ASC)
);

