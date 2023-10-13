create database dbs_prestamos_deportivos
go
use dbs_prestamos_deportivos
go
create table tbl_sexo
(
	PkId char primary key,
	Nombre varchar(50) not null,
	Nomenclatura varchar(5) not null
)
create table tbl_estado
(
	PkCodigo char primary key,
	Nombre varchar(50) not null,
	Nomenclatura varchar(5) not null
)
create table tbl_rol
(
	PkCodigo char primary key,
	Nombre varchar(50) not null,
	Nomenclatura varchar(5) not null
)
create table tbl_personas
(
	PkId varchar(10) primary key, 
	P_nombre varchar(40) not null,
	S_nombre varchar(40),
	P_apellido varchar(40) not null,
	S_apellido varchar(40),
	Contacto varchar(10) not null,
	Correo varchar(100) not null,
	Direccion varchar(100) not null,
	FkId_tbl_sexo char
)
create table tbl_usuarios
(
	PkUsuario varchar(100) primary key,
	Contraseña varchar(10) not null,
	FkId_tbl_personas varchar(10) not null,
	Fecha date, 
	FkCodigo_tbl_estado char,
	FkCodigo_tbl_rol char
)
create table tbl_prestamos
(
	PkNumero bigint primary key identity(1,1),
	FkId_tbl_personas varchar(10) not null,
	FkUsuario_tbl_usuarios varchar(100) not null,
	Fecha_registro date,
	Hora_registro time,
	Fecha_devolucion date,
	Hora_devolucion time,
	Observaciones varchar(5000)
)
create table tbl_det_prestamos
(
	PkItem bigint identity(1,1) primary key,
	FkNumero_tbl_prestamos bigint not null,
	Fk_Codigo_tbl_implementos varchar(10)not null,
	Cantidad int not null,
	Fecha_devolucion date,
	Hora_devolucion time,
	Observaciones varchar(5000)
)
create table tbl_implemnentos
(
	PkCodigo varchar(10) primary key,
	Nombre varchar(80) not null,
	Especificaciones varchar(5000) not null,
	Cantidad int not null,
	Valor float not null,
	Fecha date
)