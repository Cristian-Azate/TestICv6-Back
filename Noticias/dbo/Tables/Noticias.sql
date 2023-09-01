CREATE TABLE [dbo].[Noticias] (
    [NoticiaId]     INT             IDENTITY (1, 1) NOT NULL,
    [Titulo]        NVARCHAR (MAX)  NULL,
    [Cuerpo]        NVARCHAR (MAX)  NULL,
    [FechaCreacion] DATETIME        NULL,
    [Imagen]        VARBINARY (MAX) NULL,
    CONSTRAINT [PK_Noticias] PRIMARY KEY CLUSTERED ([NoticiaId] ASC)
);







