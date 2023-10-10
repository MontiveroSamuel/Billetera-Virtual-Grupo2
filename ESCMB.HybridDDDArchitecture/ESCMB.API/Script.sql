CREATE TABLE [dbo].[Client] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [Apellido] VARCHAR (50) NOT NULL,
    [Nombre]   VARCHAR (50) NOT NULL,
    [Email]    VARCHAR (50) NOT NULL,
    [CuilCuit] VARCHAR (11) NOT NULL,
    [Status]   INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
