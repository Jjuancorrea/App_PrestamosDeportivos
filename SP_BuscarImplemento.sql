USE dbs_prestamos_deportivos
GO
-- =============================================
-- Author:		<Author,,Juan Correa>
-- Create date: <Create Date,,26/10/2023>
-- Description:	<Description,,Buscar implementos>
-- =============================================
CREATE PROCEDURE SP_BuscarImplemento
@codigo varchar(10)
AS
BEGIN
	select Nombre,Especificaciones,Cantidad,Valor,Fecha from tbl_implemnentos where PkCodigo=@codigo
END
