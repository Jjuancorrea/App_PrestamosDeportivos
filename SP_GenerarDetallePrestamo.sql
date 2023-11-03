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
-- Description:	<Description,,Generar detalle de prestamo>
-- =============================================
CREATE PROCEDURE [dbo].[SP_GenerarDetallePrestamo]
@cod_implemento varchar(10),@cantidad int
AS
BEGIN
	declare @existencias int
	declare @numero_prestamos bigint
	select @numero_prestamos =(select max(PkNumero) from tbl_prestamos)
	select @existencias =(select Cantidad from tbl_implemnentos where PkCodigo=@cod_implemento)
	insert into tbl_det_prestamos
	(FkNumero_tbl_prestamos,Fk_Codigo_tbl_implementos,Cantidad)
	values
	(@numero_prestamos,@cod_implemento,@cantidad)

	update tbl_implemnentos
	set Cantidad=(@existencias-@cantidad) where PkCodigo=@cod_implemento
END
