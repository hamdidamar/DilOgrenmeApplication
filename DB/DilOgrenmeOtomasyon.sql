USE [master]
GO
/****** Object:  Database [DilOgrenmeOtomasyon]    Script Date: 6.09.2019 00:15:33 ******/
CREATE DATABASE [DilOgrenmeOtomasyon]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DilOgrenmeOtomasyon', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL_2014\MSSQL\DATA\DilOgrenmeOtomasyon.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DilOgrenmeOtomasyon_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL_2014\MSSQL\DATA\DilOgrenmeOtomasyon_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DilOgrenmeOtomasyon].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET ARITHABORT OFF 
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET  MULTI_USER 
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DilOgrenmeOtomasyon]
GO
/****** Object:  Table [dbo].[KelimeHavuzu]    Script Date: 6.09.2019 00:15:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KelimeHavuzu](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ingilizce] [nvarchar](50) NULL,
	[turkce] [nvarchar](50) NULL,
	[icumle] [nvarchar](50) NULL,
	[tcumle] [nvarchar](50) NULL,
	[sozcukturu] [nvarchar](50) NULL,
	[fotoyolu] [nvarchar](50) NULL,
	[kategori] [nvarchar](50) NULL,
	[asamaNo] [int] NULL,
	[sormaTarihi] [nvarchar](50) NULL,
 CONSTRAINT [PK_KelimeHavuzu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [DilOgrenmeOtomasyon] SET  READ_WRITE 
GO
