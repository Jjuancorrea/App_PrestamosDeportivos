USE dbs_prestamos_deportivos
GO
-- =============================================
-- Author:		<Author,,Juan Correa>
-- Create date: <Create Date,,26/10/2023>
-- Description:	<Description,,Registrar implementos>
-- =============================================
CREATE PROCEDURE SP_RegistrarImplemento
@codigo varchar(10), @nombre varchar(80),@especificaciones varchar (5000),@cantidad int, @valor float
AS
BEGIN
	insert into tbl_implemnentos(PkCodigo,Nombre,Especificaciones,Cantidad,Valor,Fecha)
	values(@codigo,@nombre,@especificaciones,@cantidad,@valor,GETDATE())
END
