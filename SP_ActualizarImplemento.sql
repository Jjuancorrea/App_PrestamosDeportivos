USE dbs_prestamos_deportivos
GO
-- =============================================
-- Author:		<Author,,Juan Correa>
-- Create date: <Create Date,,31/10/2023>
-- Description:	<Description,,Actualizar implementos>
-- =============================================
CREATE PROCEDURE SP_ActualizarImplemento
@codigo varchar(10), @nombre varchar(80),@especificaciones varchar (5000),@cantidad int, @valor float
AS
BEGIN
	update tbl_implemnentos set Nombre=@nombre, Especificaciones=@especificaciones, Cantidad=@cantidad, Valor=@valor where PkCodigo=@codigo
END
