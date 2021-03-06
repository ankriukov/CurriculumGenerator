USE [master]
GO
/****** Object:  Database [DBWorkProcess]    Script Date: 12.10.2017 19:23:18 ******/
CREATE DATABASE [DBWorkProcess]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBWorkProcess', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.LOCALHOST\MSSQL\DATA\DBWorkProcess.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DBWorkProcess_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.LOCALHOST\MSSQL\DATA\DBWorkProcess_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DBWorkProcess] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBWorkProcess].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBWorkProcess] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBWorkProcess] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBWorkProcess] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBWorkProcess] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBWorkProcess] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBWorkProcess] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBWorkProcess] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBWorkProcess] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBWorkProcess] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBWorkProcess] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBWorkProcess] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBWorkProcess] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBWorkProcess] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBWorkProcess] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBWorkProcess] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBWorkProcess] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBWorkProcess] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBWorkProcess] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBWorkProcess] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBWorkProcess] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBWorkProcess] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBWorkProcess] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBWorkProcess] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DBWorkProcess] SET  MULTI_USER 
GO
ALTER DATABASE [DBWorkProcess] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBWorkProcess] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBWorkProcess] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBWorkProcess] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DBWorkProcess] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DBWorkProcess]
GO
/****** Object:  Table [dbo].[Group_]    Script Date: 12.10.2017 19:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group_](
	[Id] [int] NOT NULL,
	[Number] [varchar](40) NOT NULL,
	[Specialty] [varchar](40) NOT NULL,
 CONSTRAINT [PK_GROUP_] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GroupLessonTypeLesson]    Script Date: 12.10.2017 19:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupLessonTypeLesson](
	[Id_LessonTypeLesson] [int] NOT NULL,
	[Id_Group] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lesson]    Script Date: 12.10.2017 19:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lesson](
	[Id] [int] NOT NULL,
	[Name] [varchar](40) NOT NULL,
 CONSTRAINT [PK_LESSON] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LessonTypeLesson]    Script Date: 12.10.2017 19:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LessonTypeLesson](
	[Id] [int] NOT NULL,
	[Hours] [int] NOT NULL,
	[Id_TypeLesson] [int] NOT NULL,
	[Id_Lesson] [int] NOT NULL,
 CONSTRAINT [PK_LESSONTYPELESSON] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LessonTypeLessonTypeRoom]    Script Date: 12.10.2017 19:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LessonTypeLessonTypeRoom](
	[Id_TypeRoom] [int] NOT NULL,
	[Id_LessonTypeLesson] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pair]    Script Date: 12.10.2017 19:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pair](
	[Id] [int] NOT NULL,
	[number] [int] NOT NULL,
	[Id_Room] [int] NOT NULL,
	[Id_LessonTypeLesson] [int] NOT NULL,
	[Id_Teacher] [int] NOT NULL,
	[Id_Group] [int] NOT NULL,
 CONSTRAINT [PK_PAIR] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Room]    Script Date: 12.10.2017 19:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[Id] [int] NOT NULL,
	[Number] [varchar](40) NOT NULL,
 CONSTRAINT [PK_ROOM] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RoomTypeRoom]    Script Date: 12.10.2017 19:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomTypeRoom](
	[Id_Room] [int] NOT NULL,
	[Id_TypeRoom] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 12.10.2017 19:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[Id] [int] NOT NULL,
	[Name] [varchar](40) NOT NULL,
	[Patronomic] [varchar](40) NOT NULL,
	[Surname] [varchar](40) NOT NULL,
	[Age] [int] NOT NULL,
 CONSTRAINT [PK_TEACHER] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TeacherLesson]    Script Date: 12.10.2017 19:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeacherLesson](
	[Id_Lesson] [int] NOT NULL,
	[Id_Teacher] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TypeLesson]    Script Date: 12.10.2017 19:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeLesson](
	[Id] [int] NOT NULL,
	[Name] [varchar](40) NOT NULL,
 CONSTRAINT [PK_TYPELESSON] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TypeRoom]    Script Date: 12.10.2017 19:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeRoom](
	[Id] [int] NOT NULL,
	[Name] [varchar](40) NOT NULL,
 CONSTRAINT [PK_TYPEROOM] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WorkDay]    Script Date: 12.10.2017 19:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkDay](
	[Id] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
 CONSTRAINT [PK_WORKDAY] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WorkDayPairs]    Script Date: 12.10.2017 19:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkDayPairs](
	[Id_WorkDay] [int] NOT NULL,
	[Id_Pair] [int] NOT NULL
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[GroupLessonTypeLesson]  WITH CHECK ADD  CONSTRAINT [GroupLessonTypeLesson_fk0] FOREIGN KEY([Id_LessonTypeLesson])
REFERENCES [dbo].[LessonTypeLesson] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GroupLessonTypeLesson] CHECK CONSTRAINT [GroupLessonTypeLesson_fk0]
GO
ALTER TABLE [dbo].[GroupLessonTypeLesson]  WITH CHECK ADD  CONSTRAINT [GroupLessonTypeLesson_fk1] FOREIGN KEY([Id_Group])
REFERENCES [dbo].[Group_] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GroupLessonTypeLesson] CHECK CONSTRAINT [GroupLessonTypeLesson_fk1]
GO
ALTER TABLE [dbo].[LessonTypeLesson]  WITH CHECK ADD  CONSTRAINT [LessonTypeLesson_fk0] FOREIGN KEY([Id_TypeLesson])
REFERENCES [dbo].[TypeLesson] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LessonTypeLesson] CHECK CONSTRAINT [LessonTypeLesson_fk0]
GO
ALTER TABLE [dbo].[LessonTypeLesson]  WITH CHECK ADD  CONSTRAINT [LessonTypeLesson_fk1] FOREIGN KEY([Id_Lesson])
REFERENCES [dbo].[Lesson] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LessonTypeLesson] CHECK CONSTRAINT [LessonTypeLesson_fk1]
GO
ALTER TABLE [dbo].[LessonTypeLessonTypeRoom]  WITH CHECK ADD  CONSTRAINT [LessonTypeLessonTypeRoom_fk0] FOREIGN KEY([Id_TypeRoom])
REFERENCES [dbo].[TypeRoom] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LessonTypeLessonTypeRoom] CHECK CONSTRAINT [LessonTypeLessonTypeRoom_fk0]
GO
ALTER TABLE [dbo].[LessonTypeLessonTypeRoom]  WITH CHECK ADD  CONSTRAINT [LessonTypeLessonTypeRoom_fk1] FOREIGN KEY([Id_LessonTypeLesson])
REFERENCES [dbo].[LessonTypeLesson] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LessonTypeLessonTypeRoom] CHECK CONSTRAINT [LessonTypeLessonTypeRoom_fk1]
GO
ALTER TABLE [dbo].[Pair]  WITH CHECK ADD  CONSTRAINT [Pair_fk0] FOREIGN KEY([Id_Room])
REFERENCES [dbo].[Room] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Pair] CHECK CONSTRAINT [Pair_fk0]
GO
ALTER TABLE [dbo].[Pair]  WITH CHECK ADD  CONSTRAINT [Pair_fk1] FOREIGN KEY([Id_LessonTypeLesson])
REFERENCES [dbo].[LessonTypeLesson] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Pair] CHECK CONSTRAINT [Pair_fk1]
GO
ALTER TABLE [dbo].[Pair]  WITH CHECK ADD  CONSTRAINT [Pair_fk2] FOREIGN KEY([Id_Teacher])
REFERENCES [dbo].[Teacher] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Pair] CHECK CONSTRAINT [Pair_fk2]
GO
ALTER TABLE [dbo].[Pair]  WITH CHECK ADD  CONSTRAINT [Pair_fk3] FOREIGN KEY([Id_Group])
REFERENCES [dbo].[Group_] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Pair] CHECK CONSTRAINT [Pair_fk3]
GO
ALTER TABLE [dbo].[RoomTypeRoom]  WITH CHECK ADD  CONSTRAINT [RoomTypeRoom_fk0] FOREIGN KEY([Id_Room])
REFERENCES [dbo].[Room] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[RoomTypeRoom] CHECK CONSTRAINT [RoomTypeRoom_fk0]
GO
ALTER TABLE [dbo].[RoomTypeRoom]  WITH CHECK ADD  CONSTRAINT [RoomTypeRoom_fk1] FOREIGN KEY([Id_TypeRoom])
REFERENCES [dbo].[TypeRoom] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[RoomTypeRoom] CHECK CONSTRAINT [RoomTypeRoom_fk1]
GO
ALTER TABLE [dbo].[TeacherLesson]  WITH CHECK ADD  CONSTRAINT [TeacherLesson_fk0] FOREIGN KEY([Id_Lesson])
REFERENCES [dbo].[Lesson] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TeacherLesson] CHECK CONSTRAINT [TeacherLesson_fk0]
GO
ALTER TABLE [dbo].[TeacherLesson]  WITH CHECK ADD  CONSTRAINT [TeacherLesson_fk1] FOREIGN KEY([Id_Teacher])
REFERENCES [dbo].[Teacher] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TeacherLesson] CHECK CONSTRAINT [TeacherLesson_fk1]
GO
ALTER TABLE [dbo].[WorkDayPairs]  WITH CHECK ADD  CONSTRAINT [WorkDayPairs_fk0] FOREIGN KEY([Id_WorkDay])
REFERENCES [dbo].[WorkDay] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[WorkDayPairs] CHECK CONSTRAINT [WorkDayPairs_fk0]
GO
ALTER TABLE [dbo].[WorkDayPairs]  WITH CHECK ADD  CONSTRAINT [WorkDayPairs_fk1] FOREIGN KEY([Id_Pair])
REFERENCES [dbo].[Pair] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[WorkDayPairs] CHECK CONSTRAINT [WorkDayPairs_fk1]
GO
USE [master]
GO
ALTER DATABASE [DBWorkProcess] SET  READ_WRITE 
GO
