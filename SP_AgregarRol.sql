USE [dbs_prestamos_deportivos]
GO
/****** Object:  StoredProcedure [dbo].[SP_RegistrarRol]    Script Date: 24/10/2023 7:35:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Juan Correa>
-- Create date: <Create Date,,24/10/2023>
-- Description:	<Description,,Registrar rol>
-- =============================================
ALTER PROCEDURE [dbo].[SP_RegistrarRol]
@codigo varchar(10),@nombre varchar(50),@nomenclatura varchar (5)
AS
BEGIN
	insert into tbl_rol(PkCodigo,Nombre,Nomenclatura)
	values(@codigo,@nombre,@nomenclatura)
END
