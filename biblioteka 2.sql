USE [master]
GO
/****** Object:  Database [biblioteka]    Script Date: 22.01.2025 00:29:31 ******/
CREATE DATABASE [biblioteka]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'biblioteka', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\biblioteka.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'biblioteka_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\biblioteka_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [biblioteka] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [biblioteka].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [biblioteka] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [biblioteka] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [biblioteka] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [biblioteka] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [biblioteka] SET ARITHABORT OFF 
GO
ALTER DATABASE [biblioteka] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [biblioteka] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [biblioteka] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [biblioteka] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [biblioteka] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [biblioteka] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [biblioteka] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [biblioteka] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [biblioteka] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [biblioteka] SET  ENABLE_BROKER 
GO
ALTER DATABASE [biblioteka] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [biblioteka] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [biblioteka] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [biblioteka] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [biblioteka] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [biblioteka] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [biblioteka] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [biblioteka] SET RECOVERY FULL 
GO
ALTER DATABASE [biblioteka] SET  MULTI_USER 
GO
ALTER DATABASE [biblioteka] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [biblioteka] SET DB_CHAINING OFF 
GO
ALTER DATABASE [biblioteka] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [biblioteka] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [biblioteka] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [biblioteka] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'biblioteka', N'ON'
GO
ALTER DATABASE [biblioteka] SET QUERY_STORE = OFF
GO
USE [biblioteka]
GO
/****** Object:  Table [dbo].[Cennik]    Script Date: 22.01.2025 00:29:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cennik](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Produkt] [varchar](50) NULL,
	[CenaZaDzien] [int] NULL,
	[CenaZaNowe] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistoriaWypozyczen]    Script Date: 22.01.2025 00:29:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistoriaWypozyczen](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UzytkownikId] [int] NOT NULL,
	[ZasobId] [int] NOT NULL,
	[DataWypozyczenia] [date] NOT NULL,
	[DataZwrotu] [date] NULL,
	[LoginUzytkownika] [nvarchar](50) NULL,
	[TytulPozycji] [nvarchar](100) NULL,
	[TypProduktu] [nvarchar](50) NULL,
	[StatusZwrotu] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kary]    Script Date: 22.01.2025 00:29:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kary](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IloscDniKary] [int] NOT NULL,
	[KwotaKary] [int] NULL,
	[Login] [varchar](50) NULL,
	[Tytul] [varchar](200) NULL,
	[Typ] [varchar](50) NULL,
	[StatusKary] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[osoba]    Script Date: 22.01.2025 00:29:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[osoba](
	[IdOsoby] [int] NOT NULL,
	[RodzajOsoby] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdOsoby] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[uzytkownicy]    Script Date: 22.01.2025 00:29:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[uzytkownicy](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Imie] [nvarchar](100) NOT NULL,
	[Nazwisko] [nvarchar](100) NOT NULL,
	[NumerTelefonu] [bigint] NOT NULL,
	[Login] [nvarchar](100) NOT NULL,
	[Haslo] [nvarchar](255) NOT NULL,
	[KodPocztowy] [nvarchar](10) NOT NULL,
	[Ulica] [nvarchar](100) NOT NULL,
	[NrPosesji] [nvarchar](10) NOT NULL,
	[NrLokalu] [nvarchar](10) NULL,
	[Pesel] [nvarchar](11) NOT NULL,
	[DataUrodzenia] [date] NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[ImieOpiekuna] [nvarchar](100) NULL,
	[NazwiskoOpiekuna] [nvarchar](100) NULL,
	[NumerTelefonuOpiekuna] [bigint] NULL,
	[EmailOpiekuna] [nvarchar](100) NULL,
	[IdOsoby] [int] NULL,
	[Stan] [varchar](50) NOT NULL,
	[DataUtworzenia] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[zasoby]    Script Date: 22.01.2025 00:29:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[zasoby](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tytul] [nvarchar](255) NOT NULL,
	[Autor] [nvarchar](255) NOT NULL,
	[RokWydania] [int] NOT NULL,
	[NumerKatalogowy] [nvarchar](50) NOT NULL,
	[Typ] [nvarchar](50) NOT NULL,
	[Ocena] [decimal](3, 2) NULL,
	[Ilosc] [int] NOT NULL,
	[Kategoria] [nvarchar](100) NOT NULL,
	[Wydawnictwo] [nvarchar](255) NOT NULL,
	[StanZasobu] [varchar](50) NOT NULL,
	[DataUtworzenia] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cennik] ON 

INSERT [dbo].[Cennik] ([Id], [Produkt], [CenaZaDzien], [CenaZaNowe]) VALUES (1, N'Książka', 1, 50)
INSERT [dbo].[Cennik] ([Id], [Produkt], [CenaZaDzien], [CenaZaNowe]) VALUES (2, N'Film', 2, 70)
INSERT [dbo].[Cennik] ([Id], [Produkt], [CenaZaDzien], [CenaZaNowe]) VALUES (3, N'Album', 3, 100)
SET IDENTITY_INSERT [dbo].[Cennik] OFF
GO
SET IDENTITY_INSERT [dbo].[HistoriaWypozyczen] ON 

INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (1003, 16, 2, CAST(N'2024-11-02' AS Date), CAST(N'2024-12-02' AS Date), N'lil.now', N'Lalka', N'Książka', N'KARA')
INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (1004, 11, 3, CAST(N'2024-11-02' AS Date), CAST(N'2024-12-02' AS Date), N'wik.wik', N'Władca Pierścieni', N'Książka', N'KARA')
INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (1005, 12, 8, CAST(N'2024-11-02' AS Date), CAST(N'2024-12-02' AS Date), N'jan.jankowski', N'Matrix', N'Film', N'KARA')
INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (2003, 17, 8, CAST(N'2024-11-06' AS Date), CAST(N'2024-12-06' AS Date), N'leo.kow', N'Matrix', N'Film', N'KARA')
INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (2004, 16, 23, CAST(N'2024-11-06' AS Date), CAST(N'2024-12-06' AS Date), N'lil.now', N'Duma i uprzedzenie', N'Książka', N'KARA')
INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (2005, 16, 22, CAST(N'2024-11-06' AS Date), CAST(N'2024-12-06' AS Date), N'lil.now', N'Anna Karenina', N'Książka', N'KARA')
INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (2006, 16, 2, CAST(N'2024-11-06' AS Date), CAST(N'2024-12-06' AS Date), N'lil.now', N'Lalka', N'Książka', N'KARA')
INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (2007, 11, 5, CAST(N'2024-11-13' AS Date), CAST(N'2024-12-13' AS Date), N'wik.wik', N'Harry Potter i Kamień Filozoficzny', N'Książka', N'KARA')
INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (2008, 11, 4, CAST(N'2024-11-13' AS Date), CAST(N'2024-12-13' AS Date), N'wik.wik', N'Pan Tadeusz', N'Książka', N'KARA')
INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (2009, 16, 4, CAST(N'2024-11-15' AS Date), CAST(N'2025-02-15' AS Date), N'lil.now', N'Pan Tadeusz', N'Książka', N'Nie zwrócono')
INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (2010, 17, 9, CAST(N'2024-09-01' AS Date), CAST(N'2024-10-01' AS Date), N'leo.kow', N'Avatar', N'Film', N'KARA')
INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (2011, 17, 9, CAST(N'2024-09-01' AS Date), CAST(N'2024-10-01' AS Date), N'leo.kow', N'Avatar', N'Film', N'KARA')
INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (2012, 17, 5, CAST(N'2024-11-23' AS Date), CAST(N'2024-12-23' AS Date), N'leo.kow', N'Harry Potter i Kamień Filozoficzny', N'Książka', N'Zwrócono')
INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (2013, 16, 5, CAST(N'2024-11-23' AS Date), CAST(N'2024-12-23' AS Date), N'lil.now', N'Harry Potter i Kamień Filozoficzny', N'Książka', N'KARA')
INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (2014, 11, 5, CAST(N'2024-11-23' AS Date), CAST(N'2024-12-23' AS Date), N'wik.wik', N'Harry Potter i Kamień Filozoficzny', N'Książka', N'KARA')
INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (2015, 11, 7, CAST(N'2024-12-08' AS Date), CAST(N'2025-01-08' AS Date), N'wik.wik', N'Gladiator', N'Film', N'KARA')
INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (2016, 16, 7, CAST(N'2024-12-08' AS Date), CAST(N'2025-01-08' AS Date), N'lil.now', N'Gladiator', N'Film', N'KARA')
INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (2019, 16, 2, CAST(N'2024-11-23' AS Date), CAST(N'2024-12-23' AS Date), N'lil.now', N'Lalka', N'Książka', N'KARA')
INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (2021, 11, 8, CAST(N'2024-12-01' AS Date), CAST(N'2025-01-01' AS Date), N'wik.wik', N'Matrix', N'Film', N'KARA')
INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (2022, 4012, 19, CAST(N'2025-01-01' AS Date), CAST(N'2025-01-02' AS Date), N'tomasz.jankowski', N'Mały Książę', N'Książka', N'KARA')
INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (2023, 4009, 1007, CAST(N'2025-01-01' AS Date), CAST(N'2025-01-02' AS Date), N'kasia.wisniewska', N'Planeta małp', N'Książka', N'KARA')
INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (2024, 4008, 2, CAST(N'2025-01-04' AS Date), CAST(N'2025-03-04' AS Date), N'anna.nowak', N'Lalka', N'Książka', N'Zwrócono')
INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (2025, 8, 5, CAST(N'2025-01-04' AS Date), CAST(N'2025-02-04' AS Date), N'kas.now', N'Harry Potter i Kamień Filozoficzny', N'Książka', N'Nie zwrócono')
INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (2026, 4011, 21, CAST(N'2025-01-08' AS Date), CAST(N'2025-02-08' AS Date), N'joanna.dabrowska', N'Imię róży', N'Książka', N'Zwrócono')
INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (2027, 4018, 46, CAST(N'2025-01-14' AS Date), CAST(N'2025-02-14' AS Date), N'dam.kow', N'Polskie krajobrazy', N'Album', N'Nie zwrócono')
INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (2028, 16, 18, CAST(N'2025-01-14' AS Date), CAST(N'2025-02-14' AS Date), N'lil.now', N'To', N'Książka', N'Zwrócono')
INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (2029, 4008, 6, CAST(N'2025-01-21' AS Date), CAST(N'2025-02-21' AS Date), N'anna.nowak', N'Incepcja', N'Film', N'Zwrócono')
INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (2030, 8, 3, CAST(N'2025-01-21' AS Date), CAST(N'2025-02-21' AS Date), N'kas.now', N'Władca Pierścieni', N'Książka', N'Nie zwrócono')
INSERT [dbo].[HistoriaWypozyczen] ([Id], [UzytkownikId], [ZasobId], [DataWypozyczenia], [DataZwrotu], [LoginUzytkownika], [TytulPozycji], [TypProduktu], [StatusZwrotu]) VALUES (2031, 4018, 2045, CAST(N'2025-01-21' AS Date), CAST(N'2025-02-21' AS Date), N'dam.kow', N'W górach szaleństwa i inne opowieści', N'Książka', N'Nie zwrócono')
SET IDENTITY_INSERT [dbo].[HistoriaWypozyczen] OFF
GO
SET IDENTITY_INSERT [dbo].[kary] ON 

INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (1, 6, 6, N'lil.now', N'Lalka', N'Książka', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (2, 6, 6, N'wik.wik', N'Władca Pierścieni', N'Książka', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (3, 6, 12, N'jan.jankowski', N'Matrix', N'Film', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (4, 2, 4, N'leo.kow', N'Matrix', N'Film', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (5, 2, 2, N'lil.now', N'Duma i uprzedzenie', N'Książka', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (6, 2, 2, N'lil.now', N'Anna Karenina', N'Książka', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (7, 2, 2, N'lil.now', N'Lalka', N'Książka', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (8, 68, 136, N'leo.kow', N'Avatar', N'Film', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (9, 68, 136, N'leo.kow', N'Avatar', N'Film', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (10, 11, 11, N'lil.now', N'Lalka', N'Książka', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (12, 2, 4, N'wik.wik', N'Matrix', N'Film', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (13, 32, 32, N'lil.now', N'Lalka', N'Książka', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (14, 32, 32, N'wik.wik', N'Władca Pierścieni', N'Książka', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (15, 32, 64, N'jan.jankowski', N'Matrix', N'Film', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (16, 28, 56, N'leo.kow', N'Matrix', N'Film', N'KARA')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (17, 28, 28, N'lil.now', N'Duma i uprzedzenie', N'Książka', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (18, 28, 28, N'lil.now', N'Anna Karenina', N'Książka', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (19, 28, 28, N'lil.now', N'Lalka', N'Książka', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (20, 21, 21, N'wik.wik', N'Harry Potter i Kamień Filozoficzny', N'Książka', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (21, 21, 21, N'wik.wik', N'Pan Tadeusz', N'Książka', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (22, 94, 188, N'leo.kow', N'Avatar', N'Film', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (23, 94, 188, N'leo.kow', N'Avatar', N'Film', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (24, 11, 11, N'leo.kow', N'Harry Potter i Kamień Filozoficzny', N'Książka', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (25, 11, 11, N'lil.now', N'Harry Potter i Kamień Filozoficzny', N'Książka', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (26, 11, 11, N'wik.wik', N'Harry Potter i Kamień Filozoficzny', N'Książka', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (27, 11, 11, N'lil.now', N'Lalka', N'Książka', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (28, 2, 4, N'wik.wik', N'Matrix', N'Film', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (29, 1, 1, N'kasia.wisniewska', N'Planeta małp', N'Książka', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (30, 49, 49, N'lil.now', N'Lalka', N'Książka', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (31, 49, 49, N'wik.wik', N'Władca Pierścieni', N'Książka', N'KARA')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (32, 49, 98, N'jan.jankowski', N'Matrix', N'Film', N'KARA')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (33, 45, 45, N'lil.now', N'Duma i uprzedzenie', N'Książka', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (34, 45, 45, N'lil.now', N'Anna Karenina', N'Książka', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (35, 45, 45, N'lil.now', N'Lalka', N'Książka', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (36, 38, 38, N'wik.wik', N'Harry Potter i Kamień Filozoficzny', N'Książka', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (37, 38, 38, N'wik.wik', N'Pan Tadeusz', N'Książka', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (38, 111, 222, N'leo.kow', N'Avatar', N'Film', N'KARA')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (39, 111, 222, N'leo.kow', N'Avatar', N'Film', N'KARA')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (40, 28, 28, N'leo.kow', N'Harry Potter i Kamień Filozoficzny', N'Książka', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (41, 28, 28, N'lil.now', N'Harry Potter i Kamień Filozoficzny', N'Książka', N'KARA')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (42, 28, 28, N'wik.wik', N'Harry Potter i Kamień Filozoficzny', N'Książka', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (43, 12, 24, N'wik.wik', N'Gladiator', N'Film', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (44, 12, 24, N'lil.now', N'Gladiator', N'Film', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (45, 28, 28, N'lil.now', N'Lalka', N'Książka', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (46, 19, 38, N'wik.wik', N'Matrix', N'Film', N'KARA')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (47, 18, 18, N'kasia.wisniewska', N'Planeta małp', N'Książka', N'KARA')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (48, 18, 18, N'tomasz.jankowski', N'Mały Książę', N'Książka', N'Zwrócono')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (49, 39, 39, N'wik.wik', N'Pan Tadeusz', N'Książka', N'KARA')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (50, 19, 19, N'tomasz.jankowski', N'Mały Książę', N'Książka', N'KARA')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (51, 46, 46, N'lil.now', N'Anna Karenina', N'Książka', N'KARA')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (52, 13, 26, N'wik.wik', N'Gladiator', N'Film', N'KARA')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (53, 50, 50, N'lil.now', N'Lalka', N'Książka', N'KARA')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (54, 46, 46, N'lil.now', N'Duma i uprzedzenie', N'Książka', N'KARA')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (55, 46, 46, N'lil.now', N'Lalka', N'Książka', N'KARA')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (56, 39, 39, N'wik.wik', N'Harry Potter i Kamień Filozoficzny', N'Książka', N'KARA')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (57, 29, 29, N'wik.wik', N'Harry Potter i Kamień Filozoficzny', N'Książka', N'KARA')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (58, 29, 29, N'lil.now', N'Lalka', N'Książka', N'KARA')
INSERT [dbo].[kary] ([Id], [IloscDniKary], [KwotaKary], [Login], [Tytul], [Typ], [StatusKary]) VALUES (59, 13, 26, N'lil.now', N'Gladiator', N'Film', N'KARA')
SET IDENTITY_INSERT [dbo].[kary] OFF
GO
INSERT [dbo].[osoba] ([IdOsoby], [RodzajOsoby]) VALUES (1, N'Użytkownik')
INSERT [dbo].[osoba] ([IdOsoby], [RodzajOsoby]) VALUES (2, N'Pracownik')
INSERT [dbo].[osoba] ([IdOsoby], [RodzajOsoby]) VALUES (3, N'Administrator')
GO
SET IDENTITY_INSERT [dbo].[uzytkownicy] ON 

INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (1, N'Jan', N'Kowalski', 123456789, N'jan.kowalski', N'haslo123', N'00-123', N'Warszawska', N'10', NULL, N'90010112345', CAST(N'1990-01-01' AS Date), N'jan.kowalski@example.com', NULL, NULL, NULL, NULL, NULL, N'Aktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (2, N'Nina', N'Łopacińska', 123456789, N'nina.lop', N'haslo123', N'90-765', N'Piękna', N'11', NULL, N'11122233344', CAST(N'1990-07-12' AS Date), N'nina.lop@gmail', NULL, NULL, NULL, NULL, NULL, N'Aktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (3, N'Kasia', N'Nowak', 222444555, N'kasia.nowak', N'haslo1', N'90-777', N'Łączna', N'2', NULL, N'11122255567', CAST(N'2015-07-14' AS Date), N'kasia.nowak@gamil', N'Anna', N'Nowak', 222333555, N'anna.nowak@gmail', NULL, N'Aktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (4, N'Jan', N'Kowalski', 123456789, N'jkowalski', N'haslo123', N'00-001', N'Warszawska', N'1', NULL, N'90010112345', CAST(N'1990-01-01' AS Date), N'jan.kowalski@example.com', NULL, NULL, NULL, NULL, 1, N'Aktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (5, N'Anna', N'Nowak', 987654321, N'anowak', N'haslo456', N'00-002', N'Krakowska', N'2', N'3', N'85020123456', CAST(N'1985-02-01' AS Date), N'anna.nowak@example.com', NULL, NULL, NULL, NULL, 2, N'Aktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (6, N'Marek', N'Zieliński', 123123123, N'mzielinski', N'haslo789', N'00-003', N'Poznańska', N'3', NULL, N'75030134567', CAST(N'1975-03-01' AS Date), N'marek.zielinski@example.com', NULL, NULL, NULL, NULL, 3, N'Aktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (7, N'Anna', N'Lis', 456789000, N'anna.lis', N'haslo123', N'90-999', N'Lisia', N'47', N'5', N'11122288877', CAST(N'1994-01-14' AS Date), N'anna.lis@gmail', NULL, NULL, NULL, NULL, 1, N'Aktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (8, N'Kasia', N'Now', 111222333, N'kas.now', N'haslo123', N'90-866', N'Ładna', N'11', N'1a', N'11122233323', CAST(N'1999-07-16' AS Date), N'kasia.now@.gmail', NULL, NULL, NULL, NULL, 1, N'Aktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (9, N'Witold', N'Kowalski', 123456789, N'witold.kowalski', N'haslo123', N'90-009', N'Uliczna', N'678', N'33', N'45678912334', CAST(N'2004-03-24' AS Date), N'witold.kowalski@gamil', NULL, NULL, NULL, NULL, 2, N'Aktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (10, N'wiogfvgf', N'gbb gv', 111222777, N'witold.kowalsky', N'dfgv33', N'90-888', N'fgbfd', N'fdc', N'dfvcc', N'11111111111', CAST(N'2000-02-02' AS Date), N'wiktol.@hdc', NULL, NULL, NULL, NULL, 2, N'Nieaktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (11, N'Wiktoria', N'Wiktorowska', 444666237, N'wik.wik', N'haslo123', N'92-876', N'Piotrkowska', N'11s', N'5d', N'12345678900', CAST(N'1989-01-18' AS Date), N'wik.wik@gmail', NULL, NULL, NULL, NULL, 1, N'Aktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (12, N'Jan', N'Jankowiski', 555666888, N'jan.jankowski', N'haslo123', N'90-877', N'Ogrodowa', N'1234', N'22', N'11122233345', CAST(N'1969-06-12' AS Date), N'jan.jankowski@gmail', NULL, NULL, NULL, NULL, 2, N'Aktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (13, N'Alicja', N'Alicjowa', 555444333, N'alicja.al', N'haslo789', N'91-345', N'Nijscdfcrd', N'11', N'11', N'12345634553', CAST(N'1994-06-08' AS Date), N'ali.ali@', NULL, NULL, NULL, NULL, 2, N'Aktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (16, N'Lila', N'Nowakowska', 876543211, N'lil.now', N'haslo123', N'94-222', N'Praska', N'22', NULL, N'11122244456', CAST(N'2000-02-02' AS Date), N'lil.now@', NULL, NULL, NULL, NULL, 1, N'Aktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (17, N'Leokadia', N'Kowalska', 111222333, N'leo.kow', N'haslo123', N'93-432', N'Uliaaaa', N'756', NULL, N'11122233344', CAST(N'2014-06-05' AS Date), N'leo.kow@', N'Janina', N'Kowalska', 123123123, N'jaann.kow@', 1, N'Aktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (4007, N'Jan', N'Kowalski', 123456789, N'jan.kowalski', N'haslo123', N'00-001', N'Wiejska', N'12', N'5', N'87010112345', CAST(N'1987-01-01' AS Date), N'jan.kowalski@example.com', NULL, NULL, NULL, NULL, 1, N'Aktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (4008, N'Anna', N'Nowak', 987654321, N'anna.nowak', N'pass1234', N'11-222', N'Polna', N'3', N'1', N'90120156789', CAST(N'1990-12-01' AS Date), N'anna.nowak@example.com', NULL, NULL, NULL, NULL, 1, N'Aktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (4009, N'Katarzyna', N'Wiśniewska', 111222333, N'kasia.wisniewska', N'wisnia123', N'22-333', N'Leśna', N'45', N'2', N'88010167890', CAST(N'1988-01-01' AS Date), N'kasia.wisniewska@example.com', NULL, NULL, NULL, NULL, 1, N'Aktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (4010, N'Michał', N'Zieliński', 444555666, N'michal.zielinski', N'zielony123', N'33-444', N'Słoneczna', N'8', N'10', N'87080123456', CAST(N'1987-08-01' AS Date), N'michal.zielinski@example.com', NULL, NULL, NULL, NULL, 1, N'Aktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (4011, N'Joanna', N'Dąbrowska', 555666777, N'joanna.dabrowska', N'joanna123', N'44-555', N'Kwiatowa', N'16', N'3', N'89050134567', CAST(N'1989-05-01' AS Date), N'joanna.dabrowska@example.com', NULL, NULL, NULL, NULL, 1, N'Aktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (4012, N'Tomasz', N'Jankowski', 666777888, N'tomasz.jankowski', N'janek123', N'55-666', N'Lipowa', N'22', N'7', N'88030145678', CAST(N'1988-03-01' AS Date), N'tomasz.jankowski@example.com', NULL, NULL, NULL, NULL, 1, N'Aktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (4013, N'Alicja', N'Kaczmarek', 777888999, N'alicja.kaczmarek', N'ala123', N'66-777', N'Wiosenna', N'9', N'4', N'89010156789', CAST(N'1989-01-01' AS Date), N'alicja.kaczmarek@example.com', NULL, NULL, NULL, NULL, 1, N'Nieaktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (4014, N'Piotr', N'Malinowski', 888999000, N'piotr.malinowski', N'piotr123', N'77-888', N'Jesienna', N'14', N'6', N'20200101234', CAST(N'2020-01-01' AS Date), N'piotr.malinowski@example.com', N'Adam', N'Malinowski', 123123123, N'adam.malinowski@example.com', 2, N'Aktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (4015, N'Zofia', N'Nowicka', 999000111, N'zofia.nowicka', N'zofia123', N'88-999', N'Zimowa', N'20', N'9', N'20150123456', CAST(N'2015-01-01' AS Date), N'zofia.nowicka@example.com', N'Magdalena', N'Nowicka', 321321321, N'magdalena.nowicka@example.com', 2, N'Aktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (4016, N'Paweł', N'Kowalczyk', 111222333, N'pawel.kowalczyk', N'pawel123', N'99-000', N'Jesionowa', N'25', N'11', N'20130323456', CAST(N'2013-03-01' AS Date), N'pawel.kowalczyk@example.com', N'Ewa', N'Kowalczyk', 987987987, N'ewa.kowalczyk@example.com', 2, N'Aktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (4017, N'Anja', N'Aninaiai', 765432123, N'anja.an', N'haslo123', N'90-100', N'Piotrkowska', N'89', N'2', N'09876543123', CAST(N'2020-06-03' AS Date), N'anja.an@', N'Basia', N'Aninin', 999888666, N'basia@a.ian', 1, N'Nieaktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (4018, N'Damian', N'Kowalski', 123456789, N'dam.kow', N'haslo123', N'90-765', N'Piotrkowska', N'123', NULL, N'09876543211', CAST(N'2003-07-17' AS Date), N'damian.kow@gmail', NULL, NULL, NULL, NULL, 1, N'Aktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (4019, N'Emilia', N'Wilczek', 345543435, N'emilia.wilczek', N'haslo123', N'90-234', N'Pogodna', N'2', NULL, N'00099988876', CAST(N'2012-01-07' AS Date), N'emila.wil@gmail', NULL, NULL, NULL, NULL, 1, N'Aktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
INSERT [dbo].[uzytkownicy] ([Id], [Imie], [Nazwisko], [NumerTelefonu], [Login], [Haslo], [KodPocztowy], [Ulica], [NrPosesji], [NrLokalu], [Pesel], [DataUrodzenia], [Email], [ImieOpiekuna], [NazwiskoOpiekuna], [NumerTelefonuOpiekuna], [EmailOpiekuna], [IdOsoby], [Stan], [DataUtworzenia]) VALUES (4020, N'Emilia', N'Wilczek', 345543435, N'emi.wilczek', N'haslo789', N'90-654', N'Pogodna', N'2', NULL, N'00099988876', CAST(N'2008-05-12' AS Date), N'emi.wil@gmail', NULL, NULL, NULL, NULL, 2, N'Aktywny', CAST(N'2025-01-20T10:21:46.230' AS DateTime))
SET IDENTITY_INSERT [dbo].[uzytkownicy] OFF
GO
SET IDENTITY_INSERT [dbo].[zasoby] ON 

INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (1, N'Mistrz i Małgorzata', N'Michaił Bułhakow', 1967, N'K001', N'Książka', CAST(9.50 AS Decimal(3, 2)), 16, N'Literatura piękna', N'Nowe wydawnictwo', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2, N'Lalka', N'Bolesław Prus', 1890, N'K002', N'Książka', CAST(9.00 AS Decimal(3, 2)), 8, N'Literatura klasyczna', N'Czytelnik', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (3, N'Władca Pierścieni', N'J.R.R. Tolkien', 1954, N'K003', N'Książka', CAST(9.80 AS Decimal(3, 2)), 13, N'Fantasy', N'Media Rodzina', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (4, N'Pan Tadeusz', N'Adam Mickiewicz', 1834, N'K004', N'Książka', CAST(8.50 AS Decimal(3, 2)), 5, N'Epika', N'Państwowy Instytut Wydawniczy', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (5, N'Harry Potter i Kamień Filozoficzny', N'J.K. Rowling', 1997, N'K005', N'Książka', CAST(9.70 AS Decimal(3, 2)), 6, N'Fantasy', N'Czytelnik', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (6, N'Incepcja', N'Christopher Nolan', 2010, N'F001', N'Film', CAST(9.40 AS Decimal(3, 2)), 9, N'Science Fiction', N'Media Rodzina', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (7, N'Gladiator', N'Ridley Scott', 2000, N'F002', N'Film', CAST(8.80 AS Decimal(3, 2)), 6, N'Historyczny', N'Wydawnictwo Literackie', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (8, N'Matrix', N'Lana Wachowski, Lilly Wachowski', 1999, N'F003', N'Film', CAST(9.20 AS Decimal(3, 2)), 8, N'Science Fiction', N'Zysk i S-ka', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (9, N'Avatar', N'James Cameron', 2009, N'F004', N'Film', CAST(8.70 AS Decimal(3, 2)), 7, N'Fantasy', N'Wydawnictwo Literackie', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (10, N'Titanic', N'James Cameron', 1997, N'F005', N'Film', CAST(8.90 AS Decimal(3, 2)), 8, N'Romantyczny', N'Państwowy Instytut Wydawniczy', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (13, N'Thriller', N'Michael Jackson', 1982, N'A003', N'Album', CAST(9.80 AS Decimal(3, 2)), 8, N'Pop', N'Media Rodzina', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (15, N'Back in Black', N'AC/DC', 1980, N'A005', N'Album', CAST(9.40 AS Decimal(3, 2)), 6, N'Hard Rock', N'Wydawnictwo Literackie', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (16, N'Zbrodnia i kara', N'Fiodor Dostojewski', 1866, N'K006', N'Książka', CAST(9.30 AS Decimal(3, 2)), 9, N'Literatura piękna', N'Państwowy Instytut Wydawniczy', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (17, N'Cień wiatru', N'Carlos Ruiz Zafón', 2001, N'K007', N'Książka', CAST(9.10 AS Decimal(3, 2)), 10, N'Thriller', N'Zysk i S-ka', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (18, N'To', N'Stephen King', 1986, N'K008', N'Książka', CAST(8.90 AS Decimal(3, 2)), 5, N'Horror', N'Czytelnik', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (19, N'Mały Książę', N'Antoine de Saint-Exupéry', 1943, N'K009', N'Książka', CAST(9.50 AS Decimal(3, 2)), 11, N'Dziecięca', N'Państwowy Instytut Wydawniczy', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (20, N'Człowiek w poszukiwaniu sensu', N'Viktor E. Frankl', 1946, N'K010', N'Książka', CAST(9.20 AS Decimal(3, 2)), 5, N'Psychologia', N'Media Rodzina', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (21, N'Imię róży', N'Umberto Eco', 1980, N'K011', N'Książka', CAST(8.70 AS Decimal(3, 2)), 9, N'Historyczna', N'Wydawnictwo Literackie', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (22, N'Anna Karenina', N'Lew Tołstoj', 1877, N'K012', N'Książka', CAST(9.00 AS Decimal(3, 2)), 6, N'Literatura klasyczna', N'Państwowy Instytut Wydawniczy', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (23, N'Duma i uprzedzenie', N'Jane Austen', 1813, N'K013', N'Książka', CAST(8.80 AS Decimal(3, 2)), 10, N'Romans', N'Czytelnik', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (24, N'Moby Dick', N'Herman Melville', 1851, N'K014', N'Książka', CAST(8.50 AS Decimal(3, 2)), 6, N'Przygodowa', N'Media Rodzina', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (25, N'Hobbit', N'J.R.R. Tolkien', 1937, N'K015', N'Książka', CAST(9.30 AS Decimal(3, 2)), 9, N'Fantasy', N'Wydawnictwo Literackie', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (26, N'Pulp Fiction', N'Quentin Tarantino', 1994, N'F006', N'Film', CAST(9.50 AS Decimal(3, 2)), 10, N'Kryminalny', N'Zysk i S-ka', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (27, N'Ojciec chrzestny', N'Francis Ford Coppola', 1972, N'F007', N'Film', CAST(9.80 AS Decimal(3, 2)), 12, N'Kryminalny', N'Państwowy Instytut Wydawniczy', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (28, N'Człowiek z blizną', N'Brian De Palma', 1983, N'F008', N'Film', CAST(8.90 AS Decimal(3, 2)), 6, N'Kryminalny', N'Czytelnik', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (29, N'Zielona mila', N'Frank Darabont', 1999, N'F009', N'Film', CAST(9.40 AS Decimal(3, 2)), 5, N'Dramat', N'Media Rodzina', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (30, N'Forrest Gump', N'Robert Zemeckis', 1994, N'F010', N'Film', CAST(9.60 AS Decimal(3, 2)), 7, N'Dramat', N'Czytelnik', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (31, N'Interstellar', N'Christopher Nolan', 2014, N'F011', N'Film', CAST(9.70 AS Decimal(3, 2)), 9, N'Science Fiction', N'Wydawnictwo Literackie', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (32, N'Szeregowiec Ryan', N'Steven Spielberg', 1998, N'F012', N'Film', CAST(8.80 AS Decimal(3, 2)), 8, N'Wojenny', N'Media Rodzina', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (33, N'Gwiezdne wojny: Nowa nadzieja', N'George Lucas', 1977, N'F013', N'Film', CAST(9.20 AS Decimal(3, 2)), 10, N'Science Fiction', N'Zysk i S-ka', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (34, N'Terminator 2: Dzień sądu', N'James Cameron', 1991, N'F014', N'Film', CAST(9.00 AS Decimal(3, 2)), 9, N'Akcja', N'Wydawnictwo Literackie', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (35, N'Obcy: 8. pasażer Nostromo', N'Ridley Scott', 1979, N'F015', N'Film', CAST(9.10 AS Decimal(3, 2)), 5, N'Horror', N'Zysk i S-ka', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (41, N'Podróż dookoła świata', N'Anna Kowalska', 2020, N'A001', N'Album', CAST(9.50 AS Decimal(3, 2)), 5, N'Podróże', N'Zysk i S-ka', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (42, N'Czarno-białe portrety', N'Jan Nowak', 2018, N'A002', N'Album', CAST(9.70 AS Decimal(3, 2)), 6, N'Fotografia', N'Prószyński i S-ka', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (43, N'Architektura nowoczesna', N'Marta Wiśniewska', 2015, N'A003', N'Album', CAST(9.80 AS Decimal(3, 2)), 8, N'Architektura', N'Arkady', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (44, N'Przyroda i dzikie zwierzęta', N'Piotr Zieliński', 2022, N'A004', N'Album', CAST(9.60 AS Decimal(3, 2)), 4, N'Przyroda', N'Arkady', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (45, N'Zabytki Europy', N'Karolina Szymańska', 2019, N'A005', N'Album', CAST(9.40 AS Decimal(3, 2)), 6, N'Historia', N'Prószyński i S-ka', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (46, N'Polskie krajobrazy', N'Katarzyna Lewandowska', 2017, N'A006', N'Album', CAST(9.30 AS Decimal(3, 2)), 7, N'Krajobrazy', N'Arkady', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (47, N'Życie na wsi', N'Paweł Piotrowski', 2016, N'A007', N'Album', CAST(9.00 AS Decimal(3, 2)), 7, N'Społeczeństwo', N'Prószyński i S-ka', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (48, N'Kosmos i gwiazdy', N'Łukasz Walczak', 2021, N'A008', N'Album', CAST(9.80 AS Decimal(3, 2)), 5, N'Nauka', N'Arkady', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (49, N'Wielkie miasta świata', N'Marta Kalinowska', 2014, N'A009', N'Album', CAST(9.40 AS Decimal(3, 2)), 5, N'Architektura', N'Prószyński i S-ka', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (1007, N'Planeta małp', N'Pierre Boulle', 1963, N'KS-0002', N'Książka', CAST(6.00 AS Decimal(3, 2)), 19, N'Fantastyka', N'Prószyński i S-ka', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (1008, N' W pustyni i w puszczy', N' Henryk Sienkiewicz', 1911, N' KS-0001', N'Książka', CAST(8.50 AS Decimal(3, 2)), 30, N'Lektury szkolne', N'Prószyński i S-ka', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2007, N'Mistrz i Małgorzata', N'Michaił Bułhakow', 1980, N'G009', N'Książka', CAST(9.50 AS Decimal(3, 2)), 21, N'Lektury szkolne', N'Czytelnik', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2008, N'Mistrz i Małgorzata', N'Michaił Bułhakow', 1975, N'K101', N'Książka', CAST(9.50 AS Decimal(3, 2)), 16, N'Literatura piękna', N'Media Rodzina', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2009, N'Lalka', N'Bolesław Prus', 1900, N'K102', N'Książka', CAST(9.00 AS Decimal(3, 2)), 9, N'Literatura klasyczna', N'Zysk i S-ka', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2010, N'Władca Pierścieni', N'J.R.R. Tolkien', 1960, N'K103', N'Książka', CAST(9.80 AS Decimal(3, 2)), 14, N'Fantasy', N'Prószyński i S-ka', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2011, N'Pan Tadeusz', N'Adam Mickiewicz', 1840, N'K104', N'Książka', CAST(8.50 AS Decimal(3, 2)), 5, N'Epika', N'Arkady', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2012, N'Harry Potter i Kamień Filozoficzny', N'J.K. Rowling', 2000, N'K105', N'Książka', CAST(9.70 AS Decimal(3, 2)), 10, N'Fantasy', N'Prószyński i S-ka', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2013, N'Incepcja', N'Christopher Nolan', 2015, N'F101', N'Film', CAST(9.40 AS Decimal(3, 2)), 5, N'Science Fiction', N'Arkady', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2014, N'Gladiator', N'Ridley Scott', 2005, N'F102', N'Film', CAST(8.80 AS Decimal(3, 2)), 8, N'Historyczny', N'Media Rodzina', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2015, N'Matrix', N'Lana Wachowski, Lilly Wachowski', 2005, N'F103', N'Film', CAST(9.20 AS Decimal(3, 2)), 8, N'Science Fiction', N'Czytelnik', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2016, N'Avatar', N'James Cameron', 2015, N'F104', N'Film', CAST(8.70 AS Decimal(3, 2)), 7, N'Fantasy', N'Arkady', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2017, N'Titanic', N'James Cameron', 2005, N'F105', N'Film', CAST(8.90 AS Decimal(3, 2)), 8, N'Romantyczny', N'Prószyński i S-ka', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2018, N'Thriller', N'Michael Jackson', 1990, N'A103', N'Album', CAST(9.80 AS Decimal(3, 2)), 8, N'Pop', N'Czytelnik', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2019, N'Back in Black', N'AC/DC', 1995, N'A105', N'Album', CAST(9.40 AS Decimal(3, 2)), 6, N'Hard Rock', N'Arkady', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2020, N'Zbrodnia i kara', N'Fiodor Dostojewski', 1880, N'K106', N'Książka', CAST(9.30 AS Decimal(3, 2)), 9, N'Literatura piękna', N'Media Rodzina', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2021, N'Cień wiatru', N'Carlos Ruiz Zafón', 2010, N'K107', N'Książka', CAST(9.10 AS Decimal(3, 2)), 20, N'Thriller', N'Arkady', N'Nieaktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2022, N'To', N'Stephen King', 1990, N'K108', N'Książka', CAST(8.90 AS Decimal(3, 2)), 6, N'Horror', N'Prószyński i S-ka', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2023, N'Mały Książę', N'Antoine de Saint-Exupéry', 1950, N'K109', N'Książka', CAST(9.50 AS Decimal(3, 2)), 12, N'Dziecięca', N'Arkady', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2024, N'Człowiek w poszukiwaniu sensu', N'Viktor E. Frankl', 1955, N'K110', N'Książka', CAST(9.20 AS Decimal(3, 2)), 5, N'Psychologia', N'Czytelnik', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2025, N'Mistrz i Małgorzata', N'Michaił Bułhakow', 1985, N'K201', N'Książka', CAST(9.50 AS Decimal(3, 2)), 16, N'Literatura piękna', N'Arkady', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2026, N'Lalka', N'Bolesław Prus', 1910, N'K202', N'Książka', CAST(9.00 AS Decimal(3, 2)), 9, N'Literatura klasyczna', N'Media Rodzina', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2027, N'Władca Pierścieni', N'J.R.R. Tolkien', 1970, N'K203', N'Książka', CAST(9.80 AS Decimal(3, 2)), 14, N'Fantasy', N'Czytelnik', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2028, N'Pan Tadeusz', N'Adam Mickiewicz', 1850, N'K204', N'Książka', CAST(8.50 AS Decimal(3, 2)), 5, N'Epika', N'Zysk i S-ka', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2029, N'Harry Potter i Kamień Filozoficzny', N'J.K. Rowling', 2010, N'K205', N'Książka', CAST(9.70 AS Decimal(3, 2)), 10, N'Fantasy', N'Arkady', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2030, N'Incepcja', N'Christopher Nolan', 2020, N'F201', N'Film', CAST(9.40 AS Decimal(3, 2)), 5, N'Science Fiction', N'Prószyński i S-ka', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2031, N'Gladiator', N'Ridley Scott', 2010, N'F202', N'Film', CAST(8.80 AS Decimal(3, 2)), 8, N'Historyczny', N'Czytelnik', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2032, N'Matrix', N'Lana Wachowski, Lilly Wachowski', 2010, N'F203', N'Film', CAST(9.20 AS Decimal(3, 2)), 8, N'Science Fiction', N'Media Rodzina', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2033, N'Avatar', N'James Cameron', 2020, N'F204', N'Film', CAST(8.70 AS Decimal(3, 2)), 7, N'Fantasy', N'Prószyński i S-ka', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2034, N'Titanic', N'James Cameron', 2010, N'F205', N'Film', CAST(8.90 AS Decimal(3, 2)), 8, N'Romantyczny', N'Arkady', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2035, N'Thriller', N'Michael Jackson', 2000, N'A203', N'Album', CAST(9.80 AS Decimal(3, 2)), 8, N'Pop', N'Zysk i S-ka', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2036, N'Back in Black', N'AC/DC', 2000, N'A205', N'Album', CAST(9.40 AS Decimal(3, 2)), 6, N'Hard Rock', N'Czytelnik', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2037, N'Zbrodnia i kara', N'Fiodor Dostojewski', 1890, N'K206', N'Książka', CAST(9.30 AS Decimal(3, 2)), 9, N'Literatura piękna', N'Prószyński i S-ka', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2038, N'Cień wiatru', N'Carlos Ruiz Zafón', 2015, N'K207', N'Książka', CAST(9.10 AS Decimal(3, 2)), 10, N'Thriller', N'Czytelnik', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2039, N'To', N'Stephen King', 2000, N'K208', N'Książka', CAST(8.90 AS Decimal(3, 2)), 6, N'Horror', N'Arkady', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2040, N'Mały Książę', N'Antoine de Saint-Exupéry', 1960, N'K209', N'Książka', CAST(9.50 AS Decimal(3, 2)), 12, N'Dziecięca', N'Prószyński i S-ka', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2041, N'Człowiek w poszukiwaniu sensu', N'Viktor E. Frankl', 1960, N'K210', N'Książka', CAST(9.20 AS Decimal(3, 2)), 10, N'Psychologia', N'Arkady', N'Nieaktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2042, N'Bla', N'Bla', 1999, N'Bla123', N'Album', CAST(9.00 AS Decimal(3, 2)), 10, N'Kryminał', N'BlaBla', N'Nieaktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2043, N'Brawo', N'Nieznany', 2003, N'G555', N'Gazata', CAST(8.00 AS Decimal(3, 2)), 10, N'Edukacja ', N'Nieznane', N'Nieaktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2044, N'Lalka', N'Bolesław Prus', 2025, N'L002', N'Książka', CAST(9.00 AS Decimal(3, 2)), 20, N'Lektury szkolne', N'Czytelnika', N'Aktywny', CAST(N'2025-01-20T10:21:46.250' AS DateTime))
INSERT [dbo].[zasoby] ([Id], [Tytul], [Autor], [RokWydania], [NumerKatalogowy], [Typ], [Ocena], [Ilosc], [Kategoria], [Wydawnictwo], [StanZasobu], [DataUtworzenia]) VALUES (2045, N'W górach szaleństwa i inne opowieści', N'H.P. Lovecraft', 2017, N'HP001', N'Książka', CAST(9.00 AS Decimal(3, 2)), 19, N'Fantastyka', N'Zysk i S-ka', N'Aktywny', CAST(N'2025-01-20T10:40:35.677' AS DateTime))
SET IDENTITY_INSERT [dbo].[zasoby] OFF
GO
ALTER TABLE [dbo].[HistoriaWypozyczen] ADD  DEFAULT (getdate()) FOR [DataWypozyczenia]
GO
ALTER TABLE [dbo].[HistoriaWypozyczen] ADD  DEFAULT ('Nie zwrócono') FOR [StatusZwrotu]
GO
ALTER TABLE [dbo].[uzytkownicy] ADD  DEFAULT ('Aktywny') FOR [Stan]
GO
ALTER TABLE [dbo].[uzytkownicy] ADD  DEFAULT (getdate()) FOR [DataUtworzenia]
GO
ALTER TABLE [dbo].[zasoby] ADD  DEFAULT ('Aktywny') FOR [StanZasobu]
GO
ALTER TABLE [dbo].[zasoby] ADD  DEFAULT (getdate()) FOR [DataUtworzenia]
GO
ALTER TABLE [dbo].[HistoriaWypozyczen]  WITH CHECK ADD FOREIGN KEY([UzytkownikId])
REFERENCES [dbo].[uzytkownicy] ([Id])
GO
ALTER TABLE [dbo].[HistoriaWypozyczen]  WITH CHECK ADD FOREIGN KEY([ZasobId])
REFERENCES [dbo].[zasoby] ([Id])
GO
ALTER TABLE [dbo].[uzytkownicy]  WITH CHECK ADD  CONSTRAINT [FK_uzytkownicy_osoba] FOREIGN KEY([IdOsoby])
REFERENCES [dbo].[osoba] ([IdOsoby])
GO
ALTER TABLE [dbo].[uzytkownicy] CHECK CONSTRAINT [FK_uzytkownicy_osoba]
GO
/****** Object:  StoredProcedure [dbo].[OdświeżKary]    Script Date: 22.01.2025 00:29:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OdświeżKary]
AS
BEGIN
    -- Wstawianie nowych kar do tabeli kary
    INSERT INTO kary (IloscDniKary, KwotaKary, Login, Tytul, Typ, StatusKary)
    SELECT 
        DATEDIFF(DAY, H.DataZwrotu, GETDATE()) AS IloscDniKary, -- Liczba dni opóźnienia
        DATEDIFF(DAY, H.DataZwrotu, GETDATE()) * C.CenaZaDzien AS KwotaKary, -- Kwota kary na podstawie cennika
        H.LoginUzytkownika, -- Login użytkownika
        H.TytulPozycji, -- Tytuł wypożyczonej pozycji
        H.TypProduktu, -- Typ produktu
        'KARA' AS StatusKary -- Status kary
    FROM 
        HistoriaWypozyczen H
    INNER JOIN 
        Cennik C ON H.TypProduktu = C.Produkt -- Powiązanie typu produktu z cennikiem
    WHERE 
        H.StatusZwrotu = 'KARA' -- Tylko rekordy ze statusem KARA
        AND GETDATE() > H.DataZwrotu -- Data zwrotu już minęła
        AND NOT EXISTS (
            SELECT 1
            FROM kary K
            WHERE 
                K.Login = H.LoginUzytkownika 
                AND K.Tytul = H.TytulPozycji
                AND K.StatusKary = 'KARA'
        ); -- Sprawdzamy, czy kara już istnieje w tabeli kary

    -- Informacja o powodzeniu operacji
    PRINT 'Kary zostały odświeżone';
END;
GO
USE [master]
GO
ALTER DATABASE [biblioteka] SET  READ_WRITE 
GO
