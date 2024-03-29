USE [master]
GO

/****** Object:  Database [EntitledDB]    Script Date: 12/4/2019 1:39:49 PM ******/
CREATE DATABASE [EntitledDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EntitledDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\EntitledDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EntitledDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\EntitledDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EntitledDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [EntitledDB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [EntitledDB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [EntitledDB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [EntitledDB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [EntitledDB] SET ARITHABORT OFF 
GO

ALTER DATABASE [EntitledDB] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [EntitledDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [EntitledDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [EntitledDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [EntitledDB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [EntitledDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [EntitledDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [EntitledDB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [EntitledDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [EntitledDB] SET  ENABLE_BROKER 
GO

ALTER DATABASE [EntitledDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [EntitledDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [EntitledDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [EntitledDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [EntitledDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [EntitledDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [EntitledDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [EntitledDB] SET RECOVERY FULL 
GO

ALTER DATABASE [EntitledDB] SET  MULTI_USER 
GO

ALTER DATABASE [EntitledDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [EntitledDB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [EntitledDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [EntitledDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [EntitledDB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [EntitledDB] SET QUERY_STORE = OFF
GO

ALTER DATABASE [EntitledDB] SET  READ_WRITE 
GO

