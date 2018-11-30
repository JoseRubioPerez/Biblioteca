CREATE TABLE [dbo].[RegLogeo] (
    [registro] INT          IDENTITY (1, 1) NOT NULL,
    [nc]       VARCHAR (9)  NOT NULL,
    [sistema]  VARCHAR (20) NULL,
    [hora]     TIME (7)     NULL,
    [fecha]    DATE         NULL,
    [accion]   VARCHAR (7)  NOT NULL,
    PRIMARY KEY CLUSTERED ([registro] ASC),
    CONSTRAINT [FK_RegLogeo_Administradores] FOREIGN KEY ([nc]) REFERENCES [dbo].[Administradores] ([nc])
);

