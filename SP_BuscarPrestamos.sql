USE dbs_prestamos_deportivos
GO
-- =============================================
-- Author:		<Author,,Juan Correa>
-- Create date: <Create Date,,07/11/2023>
-- Description:	<Description,,Buscar prestamos>
-- =============================================
CREATE PROCEDURE SP_BuscarPrestamos
@idPersona varchar(10)
AS
BEGIN
	select  dp.FkNumero_tbl_prestamos as 'Prestamo No°',
	i.Nombre +' '+i.Especificaciones as 'Implemento',
	dp.Cantidad,
	p.Fecha_registro as 'Fecha de prestamo',
	dp.Fecha_devolucion as 'Fecha devolución',
	dp.Hora_devolucion as 'Hora devolución',
	dp.Observaciones
	from tbl_det_prestamos as dp, tbl_prestamos as p, tbl_personas as pe, tbl_implemnentos as i
	where p.PkNumero=dp.FkNumero_tbl_prestamos
	and i.PkCodigo=dp.Fk_Codigo_tbl_implementos
	and pe.PkId=p.FkId_tbl_personas
	and pe.PkId=@idPersona
END
