USE [master]
GO
/****** Object:  Database [HW5db]    Script Date: 2021/09/14 14:45:43 ******/
CREATE DATABASE [HW5db]
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HW5db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HW5db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HW5db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HW5db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HW5db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HW5db] SET ARITHABORT OFF 
GO
ALTER DATABASE [HW5db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HW5db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HW5db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HW5db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HW5db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HW5db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HW5db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HW5db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HW5db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HW5db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HW5db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HW5db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HW5db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HW5db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HW5db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HW5db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HW5db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HW5db] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HW5db] SET  MULTI_USER 
GO
ALTER DATABASE [HW5db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HW5db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HW5db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HW5db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HW5db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HW5db] SET QUERY_STORE = OFF
GO
USE [HW5db]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Image](
	[ID] [varchar](50) NOT NULL,
	[Base64] [varchar](max) NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_Image] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [HW5db] SET  READ_WRITE 
GO