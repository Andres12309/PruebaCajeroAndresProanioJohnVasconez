USE [master]
GO
/****** Object:  Database [CajeroAutomatico]    Script Date: 10/01/2020 3:48:19 ******/
CREATE DATABASE [CajeroAutomatico]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CajeroAutomatico', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER01\MSSQL\DATA\CajeroAutomatico.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CajeroAutomatico_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER01\MSSQL\DATA\CajeroAutomatico_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CajeroAutomatico] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CajeroAutomatico].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CajeroAutomatico] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CajeroAutomatico] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CajeroAutomatico] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CajeroAutomatico] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CajeroAutomatico] SET ARITHABORT OFF 
GO
ALTER DATABASE [CajeroAutomatico] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CajeroAutomatico] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CajeroAutomatico] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CajeroAutomatico] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CajeroAutomatico] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CajeroAutomatico] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CajeroAutomatico] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CajeroAutomatico] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CajeroAutomatico] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CajeroAutomatico] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CajeroAutomatico] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CajeroAutomatico] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CajeroAutomatico] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CajeroAutomatico] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CajeroAutomatico] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CajeroAutomatico] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CajeroAutomatico] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CajeroAutomatico] SET RECOVERY FULL 
GO
ALTER DATABASE [CajeroAutomatico] SET  MULTI_USER 
GO
ALTER DATABASE [CajeroAutomatico] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CajeroAutomatico] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CajeroAutomatico] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CajeroAutomatico] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CajeroAutomatico] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CajeroAutomatico', N'ON'
GO
ALTER DATABASE [CajeroAutomatico] SET QUERY_STORE = OFF
GO
USE [CajeroAutomatico]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 10/01/2020 3:48:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[NombreCliente] [varchar](50) NOT NULL,
	[ApellidoCliente] [varchar](50) NOT NULL,
	[CedulaCliente] [varchar](50) NOT NULL,
	[PassCliente] [varchar](50) NOT NULL,
	[SaldoCliente] [varchar](50) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deposito_Retiro]    Script Date: 10/01/2020 3:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deposito_Retiro](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Deposito] [varchar](50) NULL,
	[Retiro] [varchar](50) NULL,
	[Saldo] [varchar](50) NULL,
 CONSTRAINT [PK_Deposito_Retiro] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Deposito_Retiro]  WITH CHECK ADD  CONSTRAINT [FK_Deposito_Retiro_Clientes] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Clientes] ([IdCliente])
GO
ALTER TABLE [dbo].[Deposito_Retiro] CHECK CONSTRAINT [FK_Deposito_Retiro_Clientes]
GO
/****** Object:  StoredProcedure [dbo].[depositos]    Script Date: 10/01/2020 3:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[depositos]		
@deposito varchar (50),
@saldo varchar (50)
as 
insert into Deposito_Retiro(Deposito)
values (@deposito)
GO
USE [master]
GO
ALTER DATABASE [CajeroAutomatico] SET  READ_WRITE 
GO
