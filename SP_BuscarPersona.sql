USE dbs_prestamos_deportivos
GO
-- =============================================
-- Author:		<Author,,Juan Correa>
-- Create date: <Create Date,,31/10/2023>
-- Description:	<Description,,Buscar persona>
-- =============================================
CREATE PROCEDURE SP_BuscarPersona
@id varchar(10)
AS
BEGIN
	select P_nombre+' '+S_nombre+' '+P_apellido+' '+S_apellido as completo from tbl_personas where PkId=@id
	
END
