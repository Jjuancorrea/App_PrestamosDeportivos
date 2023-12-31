USE [dbs_prestamos_deportivos]
GO
/****** Object:  StoredProcedure [dbo].[SP_GenerarPrestamo]    Script Date: 2/11/2023 8:08:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Juan Correa>
-- Create date: <Create Date,,02/11/2023>
-- Description:	<Description,,Generar de prestamo>
-- =============================================
ALTER PROCEDURE [dbo].[SP_GenerarPrestamo]
@id_persona varchar(10),@user varchar(100)
AS
BEGIN
	insert into tbl_prestamos
	(FkId_tbl_personas,FkUsuario_tbl_usuarios,Fecha_registro,Hora_registro)
	values
	(@id_persona,@user,GETDATE(),CURRENT_TIMESTAMP)
END
