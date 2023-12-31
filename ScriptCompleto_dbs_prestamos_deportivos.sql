USE [master]
GO
/****** Object:  Database [dbs_prestamos_deportivos]    Script Date: 9/11/2023 8:00:00 p. m. ******/
CREATE DATABASE [dbs_prestamos_deportivos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbs_prestamos_deportivos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\dbs_prestamos_deportivos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbs_prestamos_deportivos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\dbs_prestamos_deportivos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbs_prestamos_deportivos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET  ENABLE_BROKER 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET  MULTI_USER 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET QUERY_STORE = ON
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [dbs_prestamos_deportivos]
GO
/****** Object:  Table [dbo].[tbl_det_prestamos]    Script Date: 9/11/2023 8:00:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_det_prestamos](
	[PkItem] [bigint] IDENTITY(1,1) NOT NULL,
	[FkNumero_tbl_prestamos] [bigint] NOT NULL,
	[Fk_Codigo_tbl_implementos] [varchar](10) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Fecha_devolucion] [date] NULL,
	[Hora_devolucion] [time](7) NULL,
	[Observaciones] [varchar](5000) NULL,
PRIMARY KEY CLUSTERED 
(
	[PkItem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_estado]    Script Date: 9/11/2023 8:00:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_estado](
	[PkCodigo] [char](1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Nomenclatura] [varchar](5) NOT NULL,
 CONSTRAINT [PK__tbl_esta__47CD9045ECD59D3B] PRIMARY KEY CLUSTERED 
(
	[PkCodigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_implemnentos]    Script Date: 9/11/2023 8:00:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_implemnentos](
	[PkCodigo] [varchar](10) NOT NULL,
	[Nombre] [varchar](80) NOT NULL,
	[Especificaciones] [varchar](5000) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Valor] [float] NOT NULL,
	[Fecha] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[PkCodigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_personas]    Script Date: 9/11/2023 8:00:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_personas](
	[PkId] [varchar](10) NOT NULL,
	[P_nombre] [varchar](40) NOT NULL,
	[S_nombre] [varchar](40) NULL,
	[P_apellido] [varchar](40) NOT NULL,
	[S_apellido] [varchar](40) NULL,
	[Contacto] [varchar](10) NOT NULL,
	[Correo] [varchar](100) NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[FkId_tbl_sexo] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[PkId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_prestamos]    Script Date: 9/11/2023 8:00:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_prestamos](
	[PkNumero] [bigint] IDENTITY(1,1) NOT NULL,
	[FkId_tbl_personas] [varchar](10) NOT NULL,
	[FkUsuario_tbl_usuarios] [varchar](100) NOT NULL,
	[Fecha_registro] [date] NULL,
	[Hora_registro] [time](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[PkNumero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_rol]    Script Date: 9/11/2023 8:00:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_rol](
	[PkCodigo] [varchar](10) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Nomenclatura] [varchar](5) NOT NULL,
 CONSTRAINT [PK__tbl_rol__47CD90454B6A885D] PRIMARY KEY CLUSTERED 
(
	[PkCodigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_sexo]    Script Date: 9/11/2023 8:00:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_sexo](
	[PkId] [varchar](10) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Nomenclatura] [varchar](5) NOT NULL,
 CONSTRAINT [PK__tbl_sexo__A7C03FF8E2BEDE02] PRIMARY KEY CLUSTERED 
(
	[PkId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_usuarios]    Script Date: 9/11/2023 8:00:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_usuarios](
	[PkUsuario] [varchar](100) NOT NULL,
	[Contraseña] [varchar](10) NOT NULL,
	[FkId_tbl_personas] [varchar](10) NOT NULL,
	[Fecha] [date] NULL,
	[FkCodigo_tbl_estado] [char](1) NULL,
	[FkCodigo_tbl_rol] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[PkUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_det_prestamos] ON 

INSERT [dbo].[tbl_det_prestamos] ([PkItem], [FkNumero_tbl_prestamos], [Fk_Codigo_tbl_implementos], [Cantidad], [Fecha_devolucion], [Hora_devolucion], [Observaciones]) VALUES (1, 1, N'12', 1, NULL, NULL, NULL)
INSERT [dbo].[tbl_det_prestamos] ([PkItem], [FkNumero_tbl_prestamos], [Fk_Codigo_tbl_implementos], [Cantidad], [Fecha_devolucion], [Hora_devolucion], [Observaciones]) VALUES (2, 2, N'34', 10, NULL, NULL, NULL)
INSERT [dbo].[tbl_det_prestamos] ([PkItem], [FkNumero_tbl_prestamos], [Fk_Codigo_tbl_implementos], [Cantidad], [Fecha_devolucion], [Hora_devolucion], [Observaciones]) VALUES (3, 2, N'5', 4, NULL, NULL, NULL)
INSERT [dbo].[tbl_det_prestamos] ([PkItem], [FkNumero_tbl_prestamos], [Fk_Codigo_tbl_implementos], [Cantidad], [Fecha_devolucion], [Hora_devolucion], [Observaciones]) VALUES (4, 3, N'34', 10, NULL, NULL, NULL)
INSERT [dbo].[tbl_det_prestamos] ([PkItem], [FkNumero_tbl_prestamos], [Fk_Codigo_tbl_implementos], [Cantidad], [Fecha_devolucion], [Hora_devolucion], [Observaciones]) VALUES (5, 3, N'2', 4, NULL, NULL, NULL)
INSERT [dbo].[tbl_det_prestamos] ([PkItem], [FkNumero_tbl_prestamos], [Fk_Codigo_tbl_implementos], [Cantidad], [Fecha_devolucion], [Hora_devolucion], [Observaciones]) VALUES (6, 4, N'12', 20, NULL, NULL, NULL)
INSERT [dbo].[tbl_det_prestamos] ([PkItem], [FkNumero_tbl_prestamos], [Fk_Codigo_tbl_implementos], [Cantidad], [Fecha_devolucion], [Hora_devolucion], [Observaciones]) VALUES (7, 4, N'34', 20, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[tbl_det_prestamos] OFF
GO
INSERT [dbo].[tbl_estado] ([PkCodigo], [Nombre], [Nomenclatura]) VALUES (N'1', N'Activo', N'A')
INSERT [dbo].[tbl_estado] ([PkCodigo], [Nombre], [Nomenclatura]) VALUES (N'2', N'Inactivo', N'I')
GO
INSERT [dbo].[tbl_implemnentos] ([PkCodigo], [Nombre], [Especificaciones], [Cantidad], [Valor], [Fecha]) VALUES (N'1', N'Balon', N'De micro', 50, 50000, CAST(N'2023-10-26' AS Date))
INSERT [dbo].[tbl_implemnentos] ([PkCodigo], [Nombre], [Especificaciones], [Cantidad], [Valor], [Fecha]) VALUES (N'12', N'Balon ', N'De futbol', 980, 60000, CAST(N'2023-10-26' AS Date))
INSERT [dbo].[tbl_implemnentos] ([PkCodigo], [Nombre], [Especificaciones], [Cantidad], [Valor], [Fecha]) VALUES (N'2', N'Balon', N'De basketball', 500, 20000, CAST(N'2023-10-26' AS Date))
INSERT [dbo].[tbl_implemnentos] ([PkCodigo], [Nombre], [Especificaciones], [Cantidad], [Valor], [Fecha]) VALUES (N'34', N'Lazo', N'Para saltar', 503, 60000, CAST(N'2023-10-26' AS Date))
INSERT [dbo].[tbl_implemnentos] ([PkCodigo], [Nombre], [Especificaciones], [Cantidad], [Valor], [Fecha]) VALUES (N'5', N'Pelota', N'De ping pong', 45, 60000, CAST(N'2023-10-26' AS Date))
GO
INSERT [dbo].[tbl_personas] ([PkId], [P_nombre], [S_nombre], [P_apellido], [S_apellido], [Contacto], [Correo], [Direccion], [FkId_tbl_sexo]) VALUES (N'1001671132', N'jeyson', N'andres', N'cartagena', N'graciano', N'3114305102', N'jeyson@gmail.com', N'carepa', N'2')
INSERT [dbo].[tbl_personas] ([PkId], [P_nombre], [S_nombre], [P_apellido], [S_apellido], [Contacto], [Correo], [Direccion], [FkId_tbl_sexo]) VALUES (N'1007', N'Juan', N'Esteban', N'Correa', N'Manco', N'310', N'Juan@correa.com', N'Calle por allá ', N'1')
INSERT [dbo].[tbl_personas] ([PkId], [P_nombre], [S_nombre], [P_apellido], [S_apellido], [Contacto], [Correo], [Direccion], [FkId_tbl_sexo]) VALUES (N'435', N'gds', N'gfds', N'gsdf', N'sfd', N'gsd', N'sdfg', N'sfdg', N'1')
INSERT [dbo].[tbl_personas] ([PkId], [P_nombre], [S_nombre], [P_apellido], [S_apellido], [Contacto], [Correo], [Direccion], [FkId_tbl_sexo]) VALUES (N'454', N'hg', N'dghd', N'gh', N'fdgh', N'dfgh', N'1', N'dfg', N'f')
INSERT [dbo].[tbl_personas] ([PkId], [P_nombre], [S_nombre], [P_apellido], [S_apellido], [Contacto], [Correo], [Direccion], [FkId_tbl_sexo]) VALUES (N'4546', N'hg', N'dghd', N'gh', N'fdgh', N'dfgh', N'2', N'dfg', N'f')
INSERT [dbo].[tbl_personas] ([PkId], [P_nombre], [S_nombre], [P_apellido], [S_apellido], [Contacto], [Correo], [Direccion], [FkId_tbl_sexo]) VALUES (N'545', N'sdfg', N'sdfg', N'sdfg', N'dsfg', N'sdfg', N'sdfg', N'sdfg', N'1')
GO
SET IDENTITY_INSERT [dbo].[tbl_prestamos] ON 

INSERT [dbo].[tbl_prestamos] ([PkNumero], [FkId_tbl_personas], [FkUsuario_tbl_usuarios], [Fecha_registro], [Hora_registro]) VALUES (1, N'1007', N'1007.JuanCorrea', CAST(N'2023-11-02' AS Date), CAST(N'20:23:25.0466667' AS Time))
INSERT [dbo].[tbl_prestamos] ([PkNumero], [FkId_tbl_personas], [FkUsuario_tbl_usuarios], [Fecha_registro], [Hora_registro]) VALUES (2, N'1001671132', N'1007.JuanCorrea', CAST(N'2023-11-09' AS Date), CAST(N'19:18:50.1100000' AS Time))
INSERT [dbo].[tbl_prestamos] ([PkNumero], [FkId_tbl_personas], [FkUsuario_tbl_usuarios], [Fecha_registro], [Hora_registro]) VALUES (3, N'1001671132', N'1007.JuanCorrea', CAST(N'2023-11-09' AS Date), CAST(N'19:20:35.5366667' AS Time))
INSERT [dbo].[tbl_prestamos] ([PkNumero], [FkId_tbl_personas], [FkUsuario_tbl_usuarios], [Fecha_registro], [Hora_registro]) VALUES (4, N'1001671132', N'1007.JuanCorrea', CAST(N'2023-11-09' AS Date), CAST(N'19:48:18.1833333' AS Time))
SET IDENTITY_INSERT [dbo].[tbl_prestamos] OFF
GO
INSERT [dbo].[tbl_rol] ([PkCodigo], [Nombre], [Nomenclatura]) VALUES (N'1', N'Administrador', N'A')
INSERT [dbo].[tbl_rol] ([PkCodigo], [Nombre], [Nomenclatura]) VALUES (N'2', N'Entrenador', N'E')
INSERT [dbo].[tbl_rol] ([PkCodigo], [Nombre], [Nomenclatura]) VALUES (N'3', N'Prestador', N'P')
INSERT [dbo].[tbl_rol] ([PkCodigo], [Nombre], [Nomenclatura]) VALUES (N'4', N'Sin asignar', N'S')
GO
INSERT [dbo].[tbl_sexo] ([PkId], [Nombre], [Nomenclatura]) VALUES (N'1', N'Masculino', N'M')
INSERT [dbo].[tbl_sexo] ([PkId], [Nombre], [Nomenclatura]) VALUES (N'2', N'Femenino', N'F')
INSERT [dbo].[tbl_sexo] ([PkId], [Nombre], [Nomenclatura]) VALUES (N'3', N'Prefiero no decirlo', N'P')
GO
INSERT [dbo].[tbl_usuarios] ([PkUsuario], [Contraseña], [FkId_tbl_personas], [Fecha], [FkCodigo_tbl_estado], [FkCodigo_tbl_rol]) VALUES (N'1001671132.jeysoncartagena', N'1001671132', N'1001671132', CAST(N'2023-11-09' AS Date), N'1', N'4')
INSERT [dbo].[tbl_usuarios] ([PkUsuario], [Contraseña], [FkId_tbl_personas], [Fecha], [FkCodigo_tbl_estado], [FkCodigo_tbl_rol]) VALUES (N'1007.JuanCorrea', N'1007', N'1007', CAST(N'2023-10-31' AS Date), N'1', N'4')
INSERT [dbo].[tbl_usuarios] ([PkUsuario], [Contraseña], [FkId_tbl_personas], [Fecha], [FkCodigo_tbl_estado], [FkCodigo_tbl_rol]) VALUES (N'435.gdsgsdf', N'435', N'435', CAST(N'2023-11-09' AS Date), N'1', N'4')
INSERT [dbo].[tbl_usuarios] ([PkUsuario], [Contraseña], [FkId_tbl_personas], [Fecha], [FkCodigo_tbl_estado], [FkCodigo_tbl_rol]) VALUES (N'454.hggh', N'454', N'454', CAST(N'2023-11-09' AS Date), N'1', N'4')
INSERT [dbo].[tbl_usuarios] ([PkUsuario], [Contraseña], [FkId_tbl_personas], [Fecha], [FkCodigo_tbl_estado], [FkCodigo_tbl_rol]) VALUES (N'4546.hggh', N'4546', N'4546', CAST(N'2023-11-09' AS Date), N'1', N'4')
INSERT [dbo].[tbl_usuarios] ([PkUsuario], [Contraseña], [FkId_tbl_personas], [Fecha], [FkCodigo_tbl_estado], [FkCodigo_tbl_rol]) VALUES (N'545.sdfgsdfg', N'545', N'545', CAST(N'2023-11-09' AS Date), N'1', N'4')
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizarImplemento]    Script Date: 9/11/2023 8:00:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Juan Correa>
-- Create date: <Create Date,,31/10/2023>
-- Description:	<Description,,Actualizar implementos>
-- =============================================
CREATE PROCEDURE [dbo].[SP_ActualizarImplemento]
@codigo varchar(10), @nombre varchar(80),@especificaciones varchar (5000),@cantidad int, @valor float
AS
BEGIN
	update tbl_implemnentos set Nombre=@nombre, Especificaciones=@especificaciones, Cantidad=@cantidad, Valor=@valor where PkCodigo=@codigo
END
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarImplemento]    Script Date: 9/11/2023 8:00:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Juan Correa>
-- Create date: <Create Date,,26/10/2023>
-- Description:	<Description,,Buscar implementos>
-- =============================================
CREATE PROCEDURE [dbo].[SP_BuscarImplemento]
@codigo varchar(10)
AS
BEGIN
	select Nombre,Especificaciones,Cantidad,Valor,Fecha from tbl_implemnentos where PkCodigo=@codigo
END
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarPersona]    Script Date: 9/11/2023 8:00:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Juan Correa>
-- Create date: <Create Date,,31/10/2023>
-- Description:	<Description,,Buscar persona>
-- =============================================
CREATE PROCEDURE [dbo].[SP_BuscarPersona]
@id varchar(10)
AS
BEGIN
	select P_nombre+' '+S_nombre+' '+P_apellido+' '+S_apellido as completo from tbl_personas where PkId=@id
	
END
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarPrestamos]    Script Date: 9/11/2023 8:00:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Juan Correa>
-- Create date: <Create Date,,07/11/2023>
-- Description:	<Description,,Buscar prestamos>
-- =============================================
CREATE PROCEDURE [dbo].[SP_BuscarPrestamos]
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
GO
/****** Object:  StoredProcedure [dbo].[SP_GenerarDetallePrestamo]    Script Date: 9/11/2023 8:00:00 p. m. ******/
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
GO
/****** Object:  StoredProcedure [dbo].[SP_GenerarPrestamo]    Script Date: 9/11/2023 8:00:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Juan Correa>
-- Create date: <Create Date,,02/11/2023>
-- Description:	<Description,,Generar de prestamo>
-- =============================================
CREATE PROCEDURE [dbo].[SP_GenerarPrestamo]
@id_persona varchar(10),@user varchar(100)
AS
BEGIN
	insert into tbl_prestamos
	(FkId_tbl_personas,FkUsuario_tbl_usuarios,Fecha_registro,Hora_registro)
	values
	(@id_persona,@user,GETDATE(),CURRENT_TIMESTAMP)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_RegistrarEstado]    Script Date: 9/11/2023 8:00:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Juan Correa>
-- Create date: <Create Date,,24/10/2023>
-- Description:	<Description,,Registrar estado>
-- =============================================
CREATE PROCEDURE [dbo].[SP_RegistrarEstado]
@codigo varchar(10), @nombre varchar(50),@nomenclatura varchar (5)
AS
BEGIN
	insert into tbl_estado(PkCodigo,Nombre,Nomenclatura)
	values(@codigo,@nombre,@nomenclatura)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_RegistrarImplemento]    Script Date: 9/11/2023 8:00:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Juan Correa>
-- Create date: <Create Date,,26/10/2023>
-- Description:	<Description,,Registrar implementos>
-- =============================================
CREATE PROCEDURE [dbo].[SP_RegistrarImplemento]
@codigo varchar(10), @nombre varchar(80),@especificaciones varchar (5000),@cantidad int, @valor float
AS
BEGIN
	insert into tbl_implemnentos(PkCodigo,Nombre,Especificaciones,Cantidad,Valor,Fecha)
	values(@codigo,@nombre,@especificaciones,@cantidad,@valor,GETDATE())
END
GO
/****** Object:  StoredProcedure [dbo].[SP_RegistrarPersonas]    Script Date: 9/11/2023 8:00:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Juan Correa>
-- Create date: <Create Date,,12/10/2023>
-- Description:	<Description,,Registrar personas>
-- =============================================
CREATE PROCEDURE [dbo].[SP_RegistrarPersonas]
@id varchar(10),@pnombre varchar(40),@snombre varchar(40),@papellido varchar(40),@sapellido varchar(40),@contacto  varchar(10), @correo varchar(100),@direccion varchar(100),@fksexo char
AS
BEGIN
	insert into tbl_personas(PkId,P_nombre,S_nombre,P_apellido,S_apellido,Contacto,Correo,Direccion,FkId_tbl_sexo)
	values(@id,@pnombre,@snombre,@papellido,@sapellido,@contacto,@correo,@direccion,@fksexo)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_RegistrarRol]    Script Date: 9/11/2023 8:00:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Juan Correa>
-- Create date: <Create Date,,24/10/2023>
-- Description:	<Description,,Registrar rol>
-- =============================================
CREATE PROCEDURE [dbo].[SP_RegistrarRol]
@codigo varchar(10),@nombre varchar(50),@nomenclatura varchar (5)
AS
BEGIN
	insert into tbl_rol(PkCodigo,Nombre,Nomenclatura)
	values(@codigo,@nombre,@nomenclatura)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_RegistrarSexo]    Script Date: 9/11/2023 8:00:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Juan Correa>
-- Create date: <Create Date,,24/10/2023>
-- Description:	<Description,,Registrar sexo>
-- =============================================
CREATE PROCEDURE [dbo].[SP_RegistrarSexo]
@codigo varchar(10),@nombre varchar(50),@nomenclatura varchar (5)
AS
BEGIN
	insert into tbl_sexo(PkId,Nombre,Nomenclatura)
	values(@codigo,@nombre,@nomenclatura)
END
GO
USE [master]
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET  READ_WRITE 
GO
