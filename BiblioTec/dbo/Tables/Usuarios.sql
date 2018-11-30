CREATE TABLE [dbo].[Usuarios] (
    [nc]          VARCHAR (9)  NOT NULL,
    [nombres]     VARCHAR (20) NOT NULL,
    [apellidopat] VARCHAR (20) NOT NULL,
    [apellidomat] VARCHAR (20) NOT NULL,
    [sexo]        CHAR (1)     NOT NULL,
    [area]        TINYINT      NOT NULL,
    [status]      CHAR (1)     NOT NULL,
    [foto]        IMAGE        NULL,
    [hora]        TIME (7)     NOT NULL,
    [fecha]       DATE         NOT NULL,
    PRIMARY KEY CLUSTERED ([nc] ASC),
    CONSTRAINT [FK_Usuarios_Areas] FOREIGN KEY ([area]) REFERENCES [dbo].[Areas] ([id])
);

