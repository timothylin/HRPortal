USE [master]
GO
/****** Object:  Database [HRPortal]    Script Date: 12/3/2015 10:06:15 PM ******/
CREATE DATABASE [HRPortal]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HRPortal', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL2014\MSSQL\DATA\HRPortal.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'HRPortal_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL2014\MSSQL\DATA\HRPortal_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [HRPortal] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HRPortal].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HRPortal] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HRPortal] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HRPortal] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HRPortal] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HRPortal] SET ARITHABORT OFF 
GO
ALTER DATABASE [HRPortal] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HRPortal] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HRPortal] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HRPortal] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HRPortal] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HRPortal] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HRPortal] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HRPortal] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HRPortal] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HRPortal] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HRPortal] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HRPortal] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HRPortal] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HRPortal] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HRPortal] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HRPortal] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HRPortal] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HRPortal] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HRPortal] SET  MULTI_USER 
GO
ALTER DATABASE [HRPortal] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HRPortal] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HRPortal] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HRPortal] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [HRPortal] SET DELAYED_DURABILITY = DISABLED 
GO
USE [HRPortal]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 12/3/2015 10:06:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryTitle] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Policies]    Script Date: 12/3/2015 10:06:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Policies](
	[PolicyID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[PolicyTitle] [nvarchar](100) NOT NULL,
	[ContentText] [text] NOT NULL,
	[DateCreated] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PolicyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [CategoryTitle]) VALUES (1, N'Attendance')
INSERT [dbo].[Categories] ([CategoryID], [CategoryTitle]) VALUES (2, N'Benefits')
INSERT [dbo].[Categories] ([CategoryID], [CategoryTitle]) VALUES (3, N'Code of Conduct')
INSERT [dbo].[Categories] ([CategoryID], [CategoryTitle]) VALUES (4, N'Dress Code')
INSERT [dbo].[Categories] ([CategoryID], [CategoryTitle]) VALUES (5, N'Time Off')
INSERT [dbo].[Categories] ([CategoryID], [CategoryTitle]) VALUES (6, N'Training')
SET IDENTITY_INSERT [dbo].[Categories] OFF
ALTER TABLE [dbo].[Policies]  WITH CHECK ADD FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
/****** Object:  StoredProcedure [dbo].[AddNewCategory]    Script Date: 12/3/2015 10:06:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[AddNewCategory]
(
	@CategoryID int output,
	@CategoryTitle nvarchar(50)

)
as
begin

insert into Categories(CategoryTitle)
values (@CategoryTitle)

set @CategoryID = SCOPE_IDENTITY();

end

GO
/****** Object:  StoredProcedure [dbo].[AddNewPolicy]    Script Date: 12/3/2015 10:06:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[AddNewPolicy]
(
	@PolicyID int output,
	@PolicyTitle nvarchar(100),
	@CategoryID int,
	@DateCreated date,
	@ContentText text
)
as
begin

insert into Policies(PolicyTitle, CategoryID, DateCreated, ContentText)
values (@PolicyTitle, @CategoryID, @DateCreated, @ContentText)

set @PolicyID = SCOPE_IDENTITY();

end

GO
USE [master]
GO
ALTER DATABASE [HRPortal] SET  READ_WRITE 
GO
