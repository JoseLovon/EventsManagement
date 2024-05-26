USE [master]
GO

IF EXISTS (SELECT * FROM sys.databases WHERE name = 'MusicDB')
DROP DATABASE MusicDB;
Go

CREATE DATABASE MusicDB
Go

GO
ALTER DATABASE [MusicDB] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MusicDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MusicDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MusicDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MusicDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MusicDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MusicDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MusicDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MusicDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MusicDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MusicDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MusicDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MusicDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MusicDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MusicDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MusicDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MusicDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MusicDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MusicDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MusicDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MusicDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MusicDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MusicDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MusicDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MusicDB] SET RECOVERY FULL 
GO
ALTER DATABASE [MusicDB] SET  MULTI_USER 
GO
ALTER DATABASE [MusicDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MusicDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MusicDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MusicDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MusicDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MusicDB', N'ON'
GO
ALTER DATABASE [MusicDB] SET QUERY_STORE = OFF
GO
USE [MusicDB]
GO
/****** Object:  Table [dbo].[Album]    Script Date: 5/7/2020 12:52:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Album]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Album](
	[AlbumId] [int] IDENTITY(1,1) NOT NULL,
	[ArtistId] [int] NOT NULL,
	[Title] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Album] PRIMARY KEY CLUSTERED 
(
	[AlbumId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Artist]    Script Date: 5/7/2020 12:52:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Artist]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Artist](
	[ArtistId] [int] IDENTITY(1,1) NOT NULL,
	[ArtistName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Artist] PRIMARY KEY CLUSTERED 
(
	[ArtistId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Track]    Script Date: 5/7/2020 12:52:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Track]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Track](
	[TrackId] [int] IDENTITY(1,1) NOT NULL,
	[AlbumId] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Genre] [int] NOT NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK_Track] PRIMARY KEY CLUSTERED 
(
	[TrackId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET IDENTITY_INSERT [dbo].[Album] ON 
GO
INSERT [dbo].[Album] ([AlbumId], [ArtistId], [Title]) VALUES (3, 2, N'Pablo Honey')
GO
INSERT [dbo].[Album] ([AlbumId], [ArtistId], [Title]) VALUES (4, 3, N'Exit Planet Dust')
GO
INSERT [dbo].[Album] ([AlbumId], [ArtistId], [Title]) VALUES (5, 5, N'Head Hunters')
GO
INSERT [dbo].[Album] ([AlbumId], [ArtistId], [Title]) VALUES (6, 5, N'Thrust')
GO
INSERT [dbo].[Album] ([AlbumId], [ArtistId], [Title]) VALUES (7, 5, N'Secrets')
GO
INSERT [dbo].[Album] ([AlbumId], [ArtistId], [Title]) VALUES (9, 1, N'The Unforgettable Fire')
GO
SET IDENTITY_INSERT [dbo].[Album] OFF
GO
SET IDENTITY_INSERT [dbo].[Artist] ON 
GO
INSERT [dbo].[Artist] ([ArtistId], [ArtistName]) VALUES (1, N'U2')
GO
INSERT [dbo].[Artist] ([ArtistId], [ArtistName]) VALUES (2, N'Radiohead')
GO
INSERT [dbo].[Artist] ([ArtistId], [ArtistName]) VALUES (3, N'Chemical Brothers')
GO
INSERT [dbo].[Artist] ([ArtistId], [ArtistName]) VALUES (4, N'Moby')
GO
INSERT [dbo].[Artist] ([ArtistId], [ArtistName]) VALUES (5, N'Herbie Hancock')
GO
SET IDENTITY_INSERT [dbo].[Artist] OFF
GO
SET IDENTITY_INSERT [dbo].[Track] ON 
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (23, 3, N'You', 1, 0.9900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (24, 3, N'Creep', 1, 0.9900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (25, 3, N'How Do You?', 1, 0.9900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (26, 3, N'Stop Whispering', 1, 0.9900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (27, 3, N'Thinking About You', 1, 0.9900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (28, 3, N'Anyone Can Play Guitar', 1, 0.9900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (29, 3, N'Ripcord', 1, 0.9900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (30, 3, N'Vegetable', 1, 0.9900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (31, 3, N'Prove Yourself', 1, 0.9900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (32, 3, N'I Can''t', 1, 0.9900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (33, 3, N'Blow Out', 1, 0.9900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (34, 4, N'Leave Home', 2, 1.2900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (35, 4, N'In Dust We Trust', 2, 1.2900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (36, 4, N'Song to the Siren', 2, 1.2900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (37, 4, N'Three Little Birdies Down Beats', 2, 1.2900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (38, 4, N'Chemical Beats', 2, 1.2900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (39, 4, N'Chico''s Groove', 2, 1.2900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (40, 4, N'One Too Many Mornings', 2, 1.2900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (41, 4, N'Life is Sweet', 2, 1.2900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (42, 4, N'Playground for a Wedgeless Firm', 2, 1.2900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (43, 4, N'Alive Alone', 2, 1.2900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (44, 5, N'Chameleon', 3, 1.3900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (45, 5, N'Watermelon Man', 3, 1.3900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (46, 5, N'Sly', 3, 1.3900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (47, 5, N'Vein Melter', 3, 1.3900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (48, 6, N'Doin'' it', 3, 1.3900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (49, 6, N'People Music', 3, 1.3900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (50, 6, N'Cantelope Island', 3, 1.3900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (51, 6, N'Spider', 3, 1.3900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (52, 6, N'Gentle Thoughts', 3, 1.3900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (53, 6, N'Swamp Rat', 3, 1.3900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (54, 6, N'Sansho Shima', 3, 1.3900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (55, 9, N'A Sort of Homecoming', 1, 1.7900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (56, 9, N'Pride (In The Name Of Love', 1, 1.7900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (57, 9, N'Wire', 1, 1.7900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (58, 9, N'The Unforgettable Fire', 1, 1.7900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (59, 9, N'Promenade', 1, 1.7900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (60, 9, N'4th of July', 1, 1.7900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (61, 9, N'Bad', 1, 1.7900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (62, 9, N'Indian Summer Sky', 1, 1.7900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (63, 9, N'Elvis Presley And America', 1, 1.7900)
GO
INSERT [dbo].[Track] ([TrackId], [AlbumId], [Title], [Genre], [Price]) VALUES (64, 9, N'MLK', 1, 1.7900)
GO
SET IDENTITY_INSERT [dbo].[Track] OFF
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Album_Artist]') AND parent_object_id = OBJECT_ID(N'[dbo].[Album]'))
ALTER TABLE [dbo].[Album]  WITH CHECK ADD  CONSTRAINT [FK_Album_Artist] FOREIGN KEY([ArtistId])
REFERENCES [dbo].[Artist] ([ArtistId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Album_Artist]') AND parent_object_id = OBJECT_ID(N'[dbo].[Album]'))
ALTER TABLE [dbo].[Album] CHECK CONSTRAINT [FK_Album_Artist]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Track_Album]') AND parent_object_id = OBJECT_ID(N'[dbo].[Track]'))
ALTER TABLE [dbo].[Track]  WITH CHECK ADD  CONSTRAINT [FK_Track_Album] FOREIGN KEY([AlbumId])
REFERENCES [dbo].[Album] ([AlbumId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Track_Album]') AND parent_object_id = OBJECT_ID(N'[dbo].[Track]'))
ALTER TABLE [dbo].[Track] CHECK CONSTRAINT [FK_Track_Album]
GO


USE [master]
GO
ALTER DATABASE [MusicDB] SET  READ_WRITE 
GO