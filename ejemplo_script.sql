USE [master]
GO
/****** Object:  Database [Proyecto_basePav1]    Script Date: 14/10/2022 17:15:24 ******/
CREATE DATABASE [Proyecto_basePav1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Proyecto_basePav1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Proyecto_basePav1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Proyecto_basePav1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Proyecto_basePav1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Proyecto_basePav1] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Proyecto_basePav1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Proyecto_basePav1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Proyecto_basePav1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Proyecto_basePav1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Proyecto_basePav1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Proyecto_basePav1] SET ARITHABORT OFF 
GO
ALTER DATABASE [Proyecto_basePav1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Proyecto_basePav1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Proyecto_basePav1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Proyecto_basePav1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Proyecto_basePav1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Proyecto_basePav1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Proyecto_basePav1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Proyecto_basePav1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Proyecto_basePav1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Proyecto_basePav1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Proyecto_basePav1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Proyecto_basePav1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Proyecto_basePav1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Proyecto_basePav1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Proyecto_basePav1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Proyecto_basePav1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Proyecto_basePav1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Proyecto_basePav1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Proyecto_basePav1] SET  MULTI_USER 
GO
ALTER DATABASE [Proyecto_basePav1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Proyecto_basePav1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Proyecto_basePav1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Proyecto_basePav1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Proyecto_basePav1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Proyecto_basePav1] SET QUERY_STORE = OFF
GO
USE [Proyecto_basePav1]
GO
/****** Object:  Table [dbo].[carreras]    Script Date: 14/10/2022 17:15:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[carreras](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Descripcion] [varchar](max) NULL,
 CONSTRAINT [PK_carreras] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[personas]    Script Date: 14/10/2022 17:15:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Apellido] [varchar](100) NOT NULL,
	[FechaNacimiento] [datetime] NULL,
	[IdSexo] [int] NOT NULL,
	[IdTipoDocumento] [int] NOT NULL,
	[NroDocumento] [varchar](50) NOT NULL,
	[Calle] [varchar](50) NULL,
	[NroCasa] [varchar](50) NULL,
	[Soltero] [bit] NULL,
	[Casado] [bit] NULL,
	[Hijos] [bit] NULL,
	[CantidadHijos] [int] NULL,
	[IdCarrera] [int] NOT NULL,
 CONSTRAINT [PK_personas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sexos]    Script Date: 14/10/2022 17:15:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sexos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](max) NULL,
 CONSTRAINT [PK_sexos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_documentos]    Script Date: 14/10/2022 17:15:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_documentos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Descripcion] [varchar](max) NULL,
 CONSTRAINT [PK_Tipo_documentos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 14/10/2022 17:15:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[NombreDeUsuario] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[carreras] ON 

INSERT [dbo].[carreras] ([Id], [Nombre], [Descripcion]) VALUES (1, N'Ing. En Sistemas ', NULL)
INSERT [dbo].[carreras] ([Id], [Nombre], [Descripcion]) VALUES (2, N'Ing. Industrial', NULL)
INSERT [dbo].[carreras] ([Id], [Nombre], [Descripcion]) VALUES (3, N'Ing. Mecanica ', NULL)
INSERT [dbo].[carreras] ([Id], [Nombre], [Descripcion]) VALUES (4, N'Ing. Quimica', NULL)
SET IDENTITY_INSERT [dbo].[carreras] OFF
SET IDENTITY_INSERT [dbo].[personas] ON 

INSERT [dbo].[personas] ([Id], [Nombre], [Apellido], [FechaNacimiento], [IdSexo], [IdTipoDocumento], [NroDocumento], [Calle], [NroCasa], [Soltero], [Casado], [Hijos], [CantidadHijos], [IdCarrera]) VALUES (1, N'Sofia', N'Bearzotti', CAST(N'2001-07-24T00:00:00.000' AS DateTime), 2, 1, N'43450470', N'Truccone', N'215', 1, 0, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[personas] OFF
SET IDENTITY_INSERT [dbo].[sexos] ON 

INSERT [dbo].[sexos] ([Id], [Nombre], [Descripcion]) VALUES (1, N'Masculino', NULL)
INSERT [dbo].[sexos] ([Id], [Nombre], [Descripcion]) VALUES (2, N'Femenino', NULL)
INSERT [dbo].[sexos] ([Id], [Nombre], [Descripcion]) VALUES (3, N'Otro', NULL)
SET IDENTITY_INSERT [dbo].[sexos] OFF
SET IDENTITY_INSERT [dbo].[Tipo_documentos] ON 

INSERT [dbo].[Tipo_documentos] ([Id], [Nombre], [Descripcion]) VALUES (1, N'DNI', NULL)
INSERT [dbo].[Tipo_documentos] ([Id], [Nombre], [Descripcion]) VALUES (2, N'Pasaporte', NULL)
INSERT [dbo].[Tipo_documentos] ([Id], [Nombre], [Descripcion]) VALUES (3, N'Libreta Universitaria', NULL)
SET IDENTITY_INSERT [dbo].[Tipo_documentos] OFF
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([idUsuario], [NombreDeUsuario], [Password]) VALUES (1, N'Sofia', N'123456')
INSERT [dbo].[Usuarios] ([idUsuario], [NombreDeUsuario], [Password]) VALUES (2, N'usuario2', N'prueba')
INSERT [dbo].[Usuarios] ([idUsuario], [NombreDeUsuario], [Password]) VALUES (3, N'carlos', N'carlitos')
INSERT [dbo].[Usuarios] ([idUsuario], [NombreDeUsuario], [Password]) VALUES (4, N'admin', N'1234')
INSERT [dbo].[Usuarios] ([idUsuario], [NombreDeUsuario], [Password]) VALUES (5, N'rocio', N'1234')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
ALTER TABLE [dbo].[personas]  WITH CHECK ADD  CONSTRAINT [FK_personas_carreras] FOREIGN KEY([IdCarrera])
REFERENCES [dbo].[carreras] ([Id])
GO
ALTER TABLE [dbo].[personas] CHECK CONSTRAINT [FK_personas_carreras]
GO
ALTER TABLE [dbo].[personas]  WITH CHECK ADD  CONSTRAINT [FK_personas_sexos] FOREIGN KEY([IdSexo])
REFERENCES [dbo].[sexos] ([Id])
GO
ALTER TABLE [dbo].[personas] CHECK CONSTRAINT [FK_personas_sexos]
GO
ALTER TABLE [dbo].[personas]  WITH CHECK ADD  CONSTRAINT [FK_personas_Tipo_documentos] FOREIGN KEY([IdTipoDocumento])
REFERENCES [dbo].[Tipo_documentos] ([Id])
GO
ALTER TABLE [dbo].[personas] CHECK CONSTRAINT [FK_personas_Tipo_documentos]
GO
/****** Object:  StoredProcedure [dbo].[GetCarreras]    Script Date: 14/10/2022 17:15:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetCarreras]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM carreras
END
GO
/****** Object:  StoredProcedure [dbo].[GetTiposDocumentos]    Script Date: 14/10/2022 17:15:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetTiposDocumentos]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Tipo_documentos
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarNuevoUsuario]    Script Date: 14/10/2022 17:15:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertarNuevoUsuario]
	@nombreUsu varchar(50),
	@pass varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Usuarios (NombreDeUsuario, Password) VALUES(@nombreUsu, @pass)
END
GO
USE [master]
GO
ALTER DATABASE [Proyecto_basePav1] SET  READ_WRITE 
GO
