USE [dbs_prestamos_deportivos]
GO
/****** Object:  StoredProcedure [dbo].[SP_RegistrarSexo]    Script Date: 24/10/2023 7:36:43 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Juan Correa>
-- Create date: <Create Date,,24/10/2023>
-- Description:	<Description,,Registrar sexo>
-- =============================================
ALTER PROCEDURE [dbo].[SP_RegistrarSexo]
@codigo varchar(10),@nombre varchar(50),@nomenclatura varchar (5)
AS
BEGIN
	insert into tbl_sexo(PkId,Nombre,Nomenclatura)
	values(@codigo,@nombre,@nomenclatura)
END
