use dbs_prestamos_deportivos
go
-- =============================================
-- Author:		<Author,,Juan Correa>
-- Create date: <Create Date,,12/10/2023>
-- Description:	<Description,,Registrar personas>
-- =============================================
CREATE PROCEDURE SP_RegistrarPersonas
@id varchar(10),@pnombre varchar(40),@snombre varchar(40),@papellido varchar(40),@sapellido varchar(40),@contacto  varchar(10), @correo varchar(100),@direccion varchar(100),@fksexo char
AS
BEGIN
	insert into tbl_personas(PkId,P_nombre,S_nombre,P_apellido,S_apellido,Contacto,Correo,Direccion,FkId_tbl_sexo)
	values(@id,@pnombre,@snombre,@papellido,@sapellido,@contacto,@correo,@direccion,@fksexo)
END
