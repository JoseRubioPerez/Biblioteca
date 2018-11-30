CREATE TABLE [dbo].[Movimientos] (
    [id]       INT         IDENTITY (1, 1) NOT NULL,
    [nc]       VARCHAR (9) NOT NULL,
    [servicio] TINYINT     NOT NULL,
    [hora]     TIME (7)    NOT NULL,
    [fecha]    DATE        NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Movimientos_Servicios] FOREIGN KEY ([servicio]) REFERENCES [dbo].[Servicios] ([id]),
    CONSTRAINT [FK_Movimientos_Usuarios] FOREIGN KEY ([nc]) REFERENCES [dbo].[Usuarios] ([nc])
);

