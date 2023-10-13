use dbs_prestamos_deportivos
go
-- =============================================
-- Author:		<Author,,Juan Correa>
-- Create date: <Create Date,,12/10/2023>
-- Description:	<Description,,Crear usuario>
-- =============================================
CREATE TRIGGER TRG_CrearUsuario
   ON  tbl_personas
   AFTER Insert
AS 
BEGIN
		declare @id varchar(10)
	declare @p_nombre varchar(40)
	declare @p_apellido varchar(40)
	declare @usuario varchar(100)
	
	SET NOCOUNT ON;

	select @id=(select PKId from inserted)
	select @p_nombre=(select P_nombre from inserted)
	select @p_apellido=(select P_apellido from inserted)
	select @usuario=@id+'.'+@p_nombre+@p_apellido

	insert into tbl_usuarios(PkUsuario,Contraseña,FKId_tbl_personas,Fecha,FkCodigo_tbl_estado,FkCodigo_tbl_rol)
	values(@usuario,@id,@id,GETDATE(),1,4)
END
GO
