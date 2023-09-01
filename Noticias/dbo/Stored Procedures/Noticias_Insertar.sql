-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Noticias_Insertar]
	-- Add the parameters for the stored procedure here
	@Titulo nvarchar(100),
	@Cuerpo nvarchar(max),
	@FechaCreacion datetime,
	@Imagen varbinary(MAX) = NULL

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Noticias(Titulo,Cuerpo,FechaCreacion,Imagen)
	VALUES (@Titulo,@Cuerpo,@FechaCreacion,@Imagen)
END