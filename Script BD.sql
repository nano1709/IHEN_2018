USE [master]
GO
/****** Object:  Database [Docencia]    Script Date: 26/09/2018 09:54:43 a. m. ******/
CREATE DATABASE [Docencia]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Docencia', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Docencia.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Docencia_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Docencia_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Docencia] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Docencia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Docencia] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Docencia] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Docencia] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Docencia] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Docencia] SET ARITHABORT OFF 
GO
ALTER DATABASE [Docencia] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Docencia] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Docencia] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Docencia] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Docencia] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Docencia] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Docencia] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Docencia] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Docencia] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Docencia] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Docencia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Docencia] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Docencia] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Docencia] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Docencia] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Docencia] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Docencia] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Docencia] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Docencia] SET  MULTI_USER 
GO
ALTER DATABASE [Docencia] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Docencia] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Docencia] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Docencia] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Docencia] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Docencia] SET QUERY_STORE = OFF
GO
USE [Docencia]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Docencia]
GO
/****** Object:  Table [dbo].[Curso]    Script Date: 26/09/2018 09:54:43 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curso](
	[NombreCurso] [varchar](100) NULL,
	[CodigoCurso] [varchar](50) NOT NULL,
	[Duracion] [varchar](100) NULL,
	[ObjetivoCurso] [varchar](150) NULL,
	[Metodologia] [varchar](150) NULL,
	[MaterialDidactico] [varchar](150) NULL,
	[Certificacion] [varchar](100) NULL,
	[Inversion] [varchar](100) NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Curso] PRIMARY KEY CLUSTERED 
(
	[CodigoCurso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CursoEstudiante]    Script Date: 26/09/2018 09:54:43 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CursoEstudiante](
	[CodigoCurso] [varchar](50) NOT NULL,
	[CodigoEstudiante] [int] NOT NULL,
	[Estado] [bit] NULL,
	[Condicion] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estudiante]    Script Date: 26/09/2018 09:54:43 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiante](
	[Nombre] [varchar](250) NULL,
	[Cedula] [int] NOT NULL,
	[FechaIngreso] [varchar](50) NULL,
	[CarreraTecnica] [varchar](100) NULL,
	[FechaNacimiento] [varchar](50) NULL,
	[Edad] [int] NULL,
	[Genero] [char](10) NULL,
	[TelefonoMovil] [varchar](50) NULL,
	[TelefonoDomicilio] [varchar](50) NULL,
	[CorreoElectronico] [varchar](150) NULL,
	[ReferenciaPersonal] [varchar](100) NULL,
	[TelefonoReferencia] [varchar](50) NULL,
	[Provincia] [varchar](50) NULL,
	[Canton] [varchar](50) NULL,
	[Distrito] [varchar](50) NULL,
	[DomicilioExacto] [varchar](200) NULL,
	[LugarTrabajo] [varchar](50) NULL,
	[Cargo] [varchar](100) NULL,
	[TelefonoTrabajo] [varchar](50) NULL,
	[DireccionTrabajo] [varchar](100) NULL,
	[GradoAcademico] [varchar](50) NULL,
	[Institucion] [varchar](100) NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Estudiante] PRIMARY KEY CLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modulo]    Script Date: 26/09/2018 09:54:43 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modulo](
	[CodigoModulo] [varchar](50) NOT NULL,
	[NombreModulo] [varchar](100) NULL,
	[Duracion] [varchar](50) NULL,
	[Creditos] [int] NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[CodigoModulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ModuloEstudiante]    Script Date: 26/09/2018 09:54:43 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ModuloEstudiante](
	[CodigoModulo] [varchar](50) NOT NULL,
	[CodigoEstudiante] [int] NOT NULL,
	[Nota] [int] NULL,
	[Estado] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ModuloProfesor]    Script Date: 26/09/2018 09:54:43 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ModuloProfesor](
	[CodigoModulo] [varchar](50) NULL,
	[CodigoProfesor] [int] NULL,
	[Estado] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesor]    Script Date: 26/09/2018 09:54:43 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesor](
	[Nombre] [varchar](150) NOT NULL,
	[Cedula] [int] NOT NULL,
	[FechaNacimiento] [varchar](50) NULL,
	[Edad] [int] NULL,
	[Genero] [char](10) NULL,
	[TelefonoMovil] [int] NULL,
	[TelefonoDomicilio] [int] NULL,
	[CorreoElectronico] [varchar](150) NULL,
	[Provincia] [varchar](50) NULL,
	[Canton] [varchar](50) NULL,
	[Distrito] [varchar](50) NULL,
	[DomicilioExacto] [varchar](200) NULL,
	[NumeroCuenta] [int] NOT NULL,
	[NombreBanco] [varchar](50) NOT NULL,
	[LugarTrabajo] [varchar](50) NULL,
	[TelefonoTrabajo] [int] NULL,
	[FechaIngreso] [varchar](50) NULL,
	[DireccionTrabajo] [varchar](200) NULL,
	[FechaFinalizacion] [varchar](50) NULL,
	[GradoAcademico] [varchar](100) NULL,
	[Institucion] [varchar](100) NULL,
	[Estado] [bit] NOT NULL,
	[FechaInicio] [varchar](50) NULL,
	[CarreraTecnica] [varchar](100) NULL,
 CONSTRAINT [PK_Profesor] PRIMARY KEY CLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tecnico]    Script Date: 26/09/2018 09:54:43 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tecnico](
	[CodigoTecnico] [varchar](50) NOT NULL,
	[NombreTecnico] [varchar](200) NULL,
	[PerfilOcupacional] [varchar](500) NULL,
	[Duracion] [varchar](100) NULL,
	[PracticaProf] [varchar](50) NULL,
	[Requisitos] [varchar](150) NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Tecnico] PRIMARY KEY CLUSTERED 
(
	[CodigoTecnico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TecnicoEstudiante]    Script Date: 26/09/2018 09:54:43 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TecnicoEstudiante](
	[CodigoTecnico] [varchar](50) NOT NULL,
	[CodigoEstudiante] [int] NOT NULL,
	[Estado] [bit] NULL,
	[PracticaProfesional] [bit] NULL,
	[Condicion] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 26/09/2018 09:54:43 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[NombreUsuario] [varchar](150) NULL,
	[Password] [varchar](200) NULL,
	[Email] [varchar](150) NULL,
	[Code] [varchar](50) NULL,
	[Rol] [varchar](50) NULL,
	[Estado] [bit] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CursoEstudiante]  WITH CHECK ADD  CONSTRAINT [FK_Curso] FOREIGN KEY([CodigoCurso])
REFERENCES [dbo].[Curso] ([CodigoCurso])
GO
ALTER TABLE [dbo].[CursoEstudiante] CHECK CONSTRAINT [FK_Curso]
GO
ALTER TABLE [dbo].[CursoEstudiante]  WITH CHECK ADD  CONSTRAINT [FK_EstudianteC] FOREIGN KEY([CodigoEstudiante])
REFERENCES [dbo].[Estudiante] ([Cedula])
GO
ALTER TABLE [dbo].[CursoEstudiante] CHECK CONSTRAINT [FK_EstudianteC]
GO
ALTER TABLE [dbo].[ModuloEstudiante]  WITH CHECK ADD  CONSTRAINT [FK_EstudianteM] FOREIGN KEY([CodigoEstudiante])
REFERENCES [dbo].[Estudiante] ([Cedula])
GO
ALTER TABLE [dbo].[ModuloEstudiante] CHECK CONSTRAINT [FK_EstudianteM]
GO
ALTER TABLE [dbo].[ModuloEstudiante]  WITH CHECK ADD  CONSTRAINT [FK_Modulo] FOREIGN KEY([CodigoModulo])
REFERENCES [dbo].[Modulo] ([CodigoModulo])
GO
ALTER TABLE [dbo].[ModuloEstudiante] CHECK CONSTRAINT [FK_Modulo]
GO
ALTER TABLE [dbo].[ModuloProfesor]  WITH CHECK ADD  CONSTRAINT [FK_ModuloP] FOREIGN KEY([CodigoModulo])
REFERENCES [dbo].[Modulo] ([CodigoModulo])
GO
ALTER TABLE [dbo].[ModuloProfesor] CHECK CONSTRAINT [FK_ModuloP]
GO
ALTER TABLE [dbo].[ModuloProfesor]  WITH CHECK ADD  CONSTRAINT [FK_Profesor] FOREIGN KEY([CodigoProfesor])
REFERENCES [dbo].[Profesor] ([Cedula])
GO
ALTER TABLE [dbo].[ModuloProfesor] CHECK CONSTRAINT [FK_Profesor]
GO
ALTER TABLE [dbo].[TecnicoEstudiante]  WITH CHECK ADD  CONSTRAINT [FK_EstudianteT] FOREIGN KEY([CodigoEstudiante])
REFERENCES [dbo].[Estudiante] ([Cedula])
GO
ALTER TABLE [dbo].[TecnicoEstudiante] CHECK CONSTRAINT [FK_EstudianteT]
GO
ALTER TABLE [dbo].[TecnicoEstudiante]  WITH CHECK ADD  CONSTRAINT [FK_Tecnico] FOREIGN KEY([CodigoTecnico])
REFERENCES [dbo].[Tecnico] ([CodigoTecnico])
GO
ALTER TABLE [dbo].[TecnicoEstudiante] CHECK CONSTRAINT [FK_Tecnico]
GO
USE [master]
GO
ALTER DATABASE [Docencia] SET  READ_WRITE 
GO
