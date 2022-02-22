
/*
#region database 
USE[master]
GO
//****** Object:  Database [acuario]    Script Date: 22/02/2022 14:36:02 ******
CREATE DATABASE [acuario]
CONTAINMENT = NONE
 ON PRIMARY
(NAME = N'acuario', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\acuario.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON
(NAME = N'acuario_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\acuario_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [acuario] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC[acuario].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [acuario] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [acuario] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [acuario] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [acuario] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [acuario] SET ARITHABORT OFF 
GO
ALTER DATABASE [acuario] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [acuario] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [acuario] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [acuario] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [acuario] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [acuario] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [acuario] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [acuario] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [acuario] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [acuario] SET DISABLE_BROKER 
GO
ALTER DATABASE [acuario] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [acuario] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [acuario] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [acuario] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [acuario] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [acuario] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [acuario] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [acuario] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [acuario] SET MULTI_USER 
GO
ALTER DATABASE [acuario] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [acuario] SET DB_CHAINING OFF 
GO
ALTER DATABASE [acuario] SET FILESTREAM(NON_TRANSACTED_ACCESS = OFF)
GO
ALTER DATABASE [acuario] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [acuario] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [acuario] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [acuario] SET QUERY_STORE = OFF
GO
USE [acuario]
GO
//****** Object:  Table [dbo].[pDulce]    Script Date: 22/02/2022 14:36:02 ******
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pDulce](

[id][int] IDENTITY(1, 1) NOT NULL,

[fecha] [date] NOT NULL,

[ph] [decimal](2, 1) NULL,
	[gh] [int] NULL,
	[kh] [int] NULL,
	[no2] [decimal](2, 2) NULL,
	[no3] [decimal](2, 2) NULL,
	[nh4] [decimal](2, 1) NULL,
	[temperatura] [decimal](3, 1) NULL,
 CONSTRAINT[PK_pDulce_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
) ON[PRIMARY]
GO
//****** Object:  Table [dbo].[pMarino]    Script Date: 22/02/2022 14:36:02 ******
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pMarino](

[id][int] IDENTITY(1, 1) NOT NULL,

[fecha] [date] NOT NULL,

[calcio] [int] NULL,
	[alcalinidad] [int] NULL,
	[salinidad] [int] NULL,
	[temperatura] [decimal](3, 2) NULL,
	[ph] [decimal](3, 1) NULL,
	[magnesio] [int] NULL,
	[fosfato] [decimal](3, 2) NULL,
	[amoniaco] [decimal](2, 1) NULL,
	[potasio] [int] NULL,
	[silicio] [decimal](3, 2) NULL,
	[nitritos] [decimal](2, 1) NULL,
	[nitratos] [decimal](2, 1) NULL,
	[estroncio] [int] NULL,
	[boro] [decimal](2, 1) NULL,
	[hierro] [decimal](2, 1) NULL,
 CONSTRAINT[PK_pMarino] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
) ON[PRIMARY]
GO
//****** Object:  Table [dbo].[usuarios]    Script Date: 22/02/2022 14:36:02 ******
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](

[idUsuario][int] IDENTITY(1, 1) NOT NULL,

[usuario] [nchar](20) NOT NULL,

[password] [nchar](20) NOT NULL,
CONSTRAINT[PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
) ON[PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[pDulce] ON
GO
INSERT [dbo].[pDulce] ([id], [fecha], [ph], [gh], [kh], [no2], [no3], [nh4], [temperatura]) VALUES(1, CAST(N'2022-01-02' AS Date), NULL, NULL, NULL, NULL, NULL, NULL, CAST(25.3 AS Decimal(3, 1)))
GO
SET IDENTITY_INSERT [dbo].[pDulce] OFF
GO

SET IDENTITY_INSERT [dbo].[pMarino] ON
GO
INSERT [dbo].[pMarino] ([id], [fecha], [calcio], [alcalinidad], [salinidad], [temperatura], [ph], [magnesio], [fosfato], [amoniaco], [potasio], [silicio], [nitritos], [nitratos], [estroncio], [boro], [hierro]) VALUES(1, CAST(N'2022-01-01' AS Date), NULL, NULL, NULL, NULL, CAST(10.2 AS Decimal(3, 1)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT[dbo].[pMarino] ([id], [fecha], [calcio], [alcalinidad], [salinidad], [temperatura], [ph], [magnesio], [fosfato], [amoniaco], [potasio], [silicio], [nitritos], [nitratos], [estroncio], [boro], [hierro]) VALUES(2, CAST(N'2022-01-01' AS Date), NULL, NULL, NULL, NULL, CAST(9.2 AS Decimal(3, 1)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[pMarino] OFF
GO
SET ANSI_PADDING ON
GO
//****** Object:  Index [IX_usuarios]    Script Date: 22/02/2022 14:36:02 ******
CREATE UNIQUE NONCLUSTERED INDEX [IX_usuarios] ON[dbo].[usuarios]
(
	[usuario] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
GO
USE[master]
GO
ALTER DATABASE [acuario] SET READ_WRITE 
GO

#endregion database
*/