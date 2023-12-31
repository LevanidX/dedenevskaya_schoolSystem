USE [master]
GO
/****** Object:  Database [dedenevskaya_school]    Script Date: 28.06.2023 9:53:04 ******/
CREATE DATABASE [dedenevskaya_school]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dedenevskaya_school', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\dedenevskaya_school.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dedenevskaya_school_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\dedenevskaya_school_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [dedenevskaya_school] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dedenevskaya_school].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dedenevskaya_school] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dedenevskaya_school] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dedenevskaya_school] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dedenevskaya_school] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dedenevskaya_school] SET ARITHABORT OFF 
GO
ALTER DATABASE [dedenevskaya_school] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dedenevskaya_school] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dedenevskaya_school] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dedenevskaya_school] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dedenevskaya_school] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dedenevskaya_school] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dedenevskaya_school] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dedenevskaya_school] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dedenevskaya_school] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dedenevskaya_school] SET  ENABLE_BROKER 
GO
ALTER DATABASE [dedenevskaya_school] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dedenevskaya_school] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dedenevskaya_school] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dedenevskaya_school] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dedenevskaya_school] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dedenevskaya_school] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dedenevskaya_school] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dedenevskaya_school] SET RECOVERY FULL 
GO
ALTER DATABASE [dedenevskaya_school] SET  MULTI_USER 
GO
ALTER DATABASE [dedenevskaya_school] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dedenevskaya_school] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dedenevskaya_school] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dedenevskaya_school] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dedenevskaya_school] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dedenevskaya_school] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'dedenevskaya_school', N'ON'
GO
ALTER DATABASE [dedenevskaya_school] SET QUERY_STORE = ON
GO
ALTER DATABASE [dedenevskaya_school] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [dedenevskaya_school]
GO
/****** Object:  Table [dbo].[diplom_qualifications]    Script Date: 28.06.2023 9:53:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[diplom_qualifications](
	[diplom_qualification_ID] [int] IDENTITY(10,1) NOT NULL,
	[diplom_qualification_name] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[diplom_qualification_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[teachers]    Script Date: 28.06.2023 9:53:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[teachers](
	[teacher_ID] [int] IDENTITY(10000,1) NOT NULL,
	[teacher_name] [varchar](100) NOT NULL,
	[teacher_diplom_qualification] [int] NOT NULL,
	[teacher_birth_date] [date] NOT NULL,
	[teacher_phone_number] [varchar](20) NOT NULL,
	[teacher_home_address] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[teacher_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[teachers_view]    Script Date: 28.06.2023 9:53:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[teachers_view] AS
SELECT teacher_ID, teacher_name, diplom_qualification_name, teacher_birth_date, teacher_phone_number, teacher_home_address
FROM teachers, diplom_qualifications
WHERE teacher_diplom_qualification = diplom_qualification_ID
GO
/****** Object:  Table [dbo].[grades]    Script Date: 28.06.2023 9:53:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grades](
	[grade_ID] [int] IDENTITY(100,1) NOT NULL,
	[grade_name] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[grade_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[students]    Script Date: 28.06.2023 9:53:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[students](
	[student_ID] [int] IDENTITY(5000,1) NOT NULL,
	[student_name] [varchar](100) NOT NULL,
	[student_grade_ID] [int] NOT NULL,
	[student_birth_date] [date] NOT NULL,
	[student_phone_number] [varchar](20) NOT NULL,
	[student_home_address] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[student_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[students_view]    Script Date: 28.06.2023 9:53:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[students_view] AS
SELECT student_ID, student_name, grade_name, student_birth_date, student_phone_number, student_home_address
FROM students, grades
WHERE student_grade_ID = grade_ID
GO
/****** Object:  Table [dbo].[school_subjects]    Script Date: 28.06.2023 9:53:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[school_subjects](
	[school_subject_ID] [int] IDENTITY(0,1) NOT NULL,
	[school_subject_name] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[school_subject_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[performance]    Script Date: 28.06.2023 9:53:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[performance](
	[performance_ID] [int] IDENTITY(25000,1) NOT NULL,
	[performance_student_ID] [int] NOT NULL,
	[performance_school_subject_ID] [int] NOT NULL,
	[performance_first_term_mark] [int] NULL,
	[performance_first_term_date] [date] NULL,
	[performance_first_term_teacher_ID] [int] NULL,
	[performance_second_term_mark] [int] NULL,
	[performance_second_term_date] [date] NULL,
	[performance_second_term_teacher_ID] [int] NULL,
	[performance_overall_mark] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[performance_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[performance_view]    Script Date: 28.06.2023 9:53:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[performance_view]
AS
SELECT performance_ID, student_name, school_subject_name,
	performance_first_term_mark, performance_first_term_date, 
	performance_first_term_teacher_ID, performance_second_term_mark,
	performance_second_term_date, performance_second_term_teacher_ID,
	performance_overall_mark
FROM performance, students, school_subjects
WHERE performance_student_ID = student_ID AND
	performance_school_subject_ID = school_subject_ID
GO
/****** Object:  View [dbo].[performance_new_view]    Script Date: 28.06.2023 9:53:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[performance_new_view]
AS
SELECT performance_ID, student_name, school_subject_name,
	performance_first_term_mark, performance_first_term_date, 
	teacher_name AS 'first_term_teacher', performance_second_term_mark,
	performance_second_term_date, teacher_name AS 'second_term_teacher',
	performance_overall_mark
FROM performance, students, school_subjects, teachers
WHERE performance_student_ID = student_ID AND
	performance_school_subject_ID = school_subject_ID AND
	performance_first_term_teacher_ID = teacher_ID AND
	performance_second_term_teacher_ID = teacher_ID
GO
SET IDENTITY_INSERT [dbo].[diplom_qualifications] ON 

INSERT [dbo].[diplom_qualifications] ([diplom_qualification_ID], [diplom_qualification_name]) VALUES (10, N'38.03.01 Экономика')
INSERT [dbo].[diplom_qualifications] ([diplom_qualification_ID], [diplom_qualification_name]) VALUES (11, N'44.03.04 Профессиональное обучение')
INSERT [dbo].[diplom_qualifications] ([diplom_qualification_ID], [diplom_qualification_name]) VALUES (12, N'38.03.05 Бизнес-информатика')
INSERT [dbo].[diplom_qualifications] ([diplom_qualification_ID], [diplom_qualification_name]) VALUES (13, N'15.03.05 Конструкторско-технологическое обеспечение машиностроительных производств ')
INSERT [dbo].[diplom_qualifications] ([diplom_qualification_ID], [diplom_qualification_name]) VALUES (14, N'30.05.01 Медицинская биохимия')
INSERT [dbo].[diplom_qualifications] ([diplom_qualification_ID], [diplom_qualification_name]) VALUES (15, N'09.03.01 Информатика и вычислительная техника')
INSERT [dbo].[diplom_qualifications] ([diplom_qualification_ID], [diplom_qualification_name]) VALUES (16, N'02.03.03 Математическое обеспечение и администрирование информационных систем')
INSERT [dbo].[diplom_qualifications] ([diplom_qualification_ID], [diplom_qualification_name]) VALUES (17, N'01.03.02 Прикладная математика и информатика')
INSERT [dbo].[diplom_qualifications] ([diplom_qualification_ID], [diplom_qualification_name]) VALUES (18, N'50.03.03 История искусств')
INSERT [dbo].[diplom_qualifications] ([diplom_qualification_ID], [diplom_qualification_name]) VALUES (19, N'46.03.03 Антропология и этнология')
INSERT [dbo].[diplom_qualifications] ([diplom_qualification_ID], [diplom_qualification_name]) VALUES (20, N'44.03.01 Педагогическое образование')
INSERT [dbo].[diplom_qualifications] ([diplom_qualification_ID], [diplom_qualification_name]) VALUES (21, N'46.03.01 История ')
SET IDENTITY_INSERT [dbo].[diplom_qualifications] OFF
GO
SET IDENTITY_INSERT [dbo].[grades] ON 

INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (100, N'1А')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (101, N'1Б')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (102, N'1В')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (103, N'2А')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (104, N'2Б')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (105, N'2В')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (106, N'3А')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (107, N'3Б')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (108, N'3В')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (109, N'4А')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (110, N'4Б')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (111, N'4В')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (112, N'5А')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (113, N'5Б')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (114, N'5В')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (115, N'6А')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (116, N'6Б')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (117, N'6В')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (118, N'7А')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (119, N'7Б')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (120, N'7В')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (121, N'8А')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (122, N'8Б')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (123, N'8В')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (124, N'9А')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (125, N'9Б')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (126, N'9В')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (127, N'10А')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (128, N'10Б')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (129, N'10В')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (130, N'11А')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (131, N'11Б')
INSERT [dbo].[grades] ([grade_ID], [grade_name]) VALUES (132, N'11В')
SET IDENTITY_INSERT [dbo].[grades] OFF
GO
SET IDENTITY_INSERT [dbo].[performance] ON 

INSERT [dbo].[performance] ([performance_ID], [performance_student_ID], [performance_school_subject_ID], [performance_first_term_mark], [performance_first_term_date], [performance_first_term_teacher_ID], [performance_second_term_mark], [performance_second_term_date], [performance_second_term_teacher_ID], [performance_overall_mark]) VALUES (25000, 5001, 0, 4, CAST(N'2022-12-31' AS Date), 10016, 4, CAST(N'2023-05-25' AS Date), 10016, 4)
INSERT [dbo].[performance] ([performance_ID], [performance_student_ID], [performance_school_subject_ID], [performance_first_term_mark], [performance_first_term_date], [performance_first_term_teacher_ID], [performance_second_term_mark], [performance_second_term_date], [performance_second_term_teacher_ID], [performance_overall_mark]) VALUES (25001, 5001, 1, 5, CAST(N'2022-12-31' AS Date), 10016, 3, CAST(N'2023-05-25' AS Date), 10016, 4)
INSERT [dbo].[performance] ([performance_ID], [performance_student_ID], [performance_school_subject_ID], [performance_first_term_mark], [performance_first_term_date], [performance_first_term_teacher_ID], [performance_second_term_mark], [performance_second_term_date], [performance_second_term_teacher_ID], [performance_overall_mark]) VALUES (25005, 5012, 3, 3, CAST(N'2022-12-23' AS Date), 10014, 4, CAST(N'2023-05-30' AS Date), 10014, 3.5)
INSERT [dbo].[performance] ([performance_ID], [performance_student_ID], [performance_school_subject_ID], [performance_first_term_mark], [performance_first_term_date], [performance_first_term_teacher_ID], [performance_second_term_mark], [performance_second_term_date], [performance_second_term_teacher_ID], [performance_overall_mark]) VALUES (25006, 5003, 1, 4, CAST(N'2022-12-23' AS Date), 10016, 3, CAST(N'2023-05-28' AS Date), 10016, 3.5)
INSERT [dbo].[performance] ([performance_ID], [performance_student_ID], [performance_school_subject_ID], [performance_first_term_mark], [performance_first_term_date], [performance_first_term_teacher_ID], [performance_second_term_mark], [performance_second_term_date], [performance_second_term_teacher_ID], [performance_overall_mark]) VALUES (25007, 5004, 1, 5, CAST(N'2022-12-23' AS Date), 10016, 5, CAST(N'2022-05-28' AS Date), 10016, 5)
INSERT [dbo].[performance] ([performance_ID], [performance_student_ID], [performance_school_subject_ID], [performance_first_term_mark], [performance_first_term_date], [performance_first_term_teacher_ID], [performance_second_term_mark], [performance_second_term_date], [performance_second_term_teacher_ID], [performance_overall_mark]) VALUES (25008, 5011, 1, 3, CAST(N'2022-12-28' AS Date), 10016, 3, CAST(N'2023-05-28' AS Date), 10016, 3)
INSERT [dbo].[performance] ([performance_ID], [performance_student_ID], [performance_school_subject_ID], [performance_first_term_mark], [performance_first_term_date], [performance_first_term_teacher_ID], [performance_second_term_mark], [performance_second_term_date], [performance_second_term_teacher_ID], [performance_overall_mark]) VALUES (25009, 5001, 2, 3, CAST(N'2022-12-24' AS Date), 10005, 5, CAST(N'2023-05-30' AS Date), 10005, 4)
INSERT [dbo].[performance] ([performance_ID], [performance_student_ID], [performance_school_subject_ID], [performance_first_term_mark], [performance_first_term_date], [performance_first_term_teacher_ID], [performance_second_term_mark], [performance_second_term_date], [performance_second_term_teacher_ID], [performance_overall_mark]) VALUES (25010, 5021, 0, 4, CAST(N'2022-12-31' AS Date), 10016, 4, CAST(N'2023-05-25' AS Date), 10016, 4)
INSERT [dbo].[performance] ([performance_ID], [performance_student_ID], [performance_school_subject_ID], [performance_first_term_mark], [performance_first_term_date], [performance_first_term_teacher_ID], [performance_second_term_mark], [performance_second_term_date], [performance_second_term_teacher_ID], [performance_overall_mark]) VALUES (25011, 5011, 5, 4, CAST(N'2022-12-27' AS Date), 10019, 3, CAST(N'2023-05-27' AS Date), 10019, 3.5)
SET IDENTITY_INSERT [dbo].[performance] OFF
GO
SET IDENTITY_INSERT [dbo].[school_subjects] ON 

INSERT [dbo].[school_subjects] ([school_subject_ID], [school_subject_name]) VALUES (0, N'Русский язык')
INSERT [dbo].[school_subjects] ([school_subject_ID], [school_subject_name]) VALUES (1, N'Литература')
INSERT [dbo].[school_subjects] ([school_subject_ID], [school_subject_name]) VALUES (2, N'Алгебра')
INSERT [dbo].[school_subjects] ([school_subject_ID], [school_subject_name]) VALUES (3, N'Геометрия')
INSERT [dbo].[school_subjects] ([school_subject_ID], [school_subject_name]) VALUES (4, N'История')
INSERT [dbo].[school_subjects] ([school_subject_ID], [school_subject_name]) VALUES (5, N'Обществознание')
INSERT [dbo].[school_subjects] ([school_subject_ID], [school_subject_name]) VALUES (6, N'Физика')
INSERT [dbo].[school_subjects] ([school_subject_ID], [school_subject_name]) VALUES (7, N'Химия')
INSERT [dbo].[school_subjects] ([school_subject_ID], [school_subject_name]) VALUES (8, N'Биология')
INSERT [dbo].[school_subjects] ([school_subject_ID], [school_subject_name]) VALUES (9, N'Информатика')
INSERT [dbo].[school_subjects] ([school_subject_ID], [school_subject_name]) VALUES (10, N'Иностранный язык')
INSERT [dbo].[school_subjects] ([school_subject_ID], [school_subject_name]) VALUES (11, N'Физическая культура')
INSERT [dbo].[school_subjects] ([school_subject_ID], [school_subject_name]) VALUES (12, N'Основы безопасности жизнедеятельности')
INSERT [dbo].[school_subjects] ([school_subject_ID], [school_subject_name]) VALUES (13, N'Технология')
SET IDENTITY_INSERT [dbo].[school_subjects] OFF
GO
SET IDENTITY_INSERT [dbo].[students] ON 

INSERT [dbo].[students] ([student_ID], [student_name], [student_grade_ID], [student_birth_date], [student_phone_number], [student_home_address]) VALUES (5001, N'Фролов Юрин Викторович', 130, CAST(N'2006-01-01' AS Date), N'+7 (316) 364-88-39', N'Россия, г. Москва, Якуба Коласа ул., 42, корп. 1, кв. 48')
INSERT [dbo].[students] ([student_ID], [student_name], [student_grade_ID], [student_birth_date], [student_phone_number], [student_home_address]) VALUES (5003, N'Самойлова Рада Васильевна', 130, CAST(N'2006-02-02' AS Date), N'+7 (893) 364-21-23', N'Россия, г. Москва, Озерная ул., 77, корп. 9, кв. 176')
INSERT [dbo].[students] ([student_ID], [student_name], [student_grade_ID], [student_birth_date], [student_phone_number], [student_home_address]) VALUES (5004, N'Архипов Филипп Акимович', 130, CAST(N'2006-03-03' AS Date), N'+7 (540) 486-83-85', N'Россия, г. Москва, Дзержинского ул., 65, корп. 2, кв. 98')
INSERT [dbo].[students] ([student_ID], [student_name], [student_grade_ID], [student_birth_date], [student_phone_number], [student_home_address]) VALUES (5005, N'Белякова Антония Феодосьевна', 127, CAST(N'2007-01-16' AS Date), N'+7 (594) 260-69-50', N'Россия, г. Москва, Центральный пер., 18, корп. 3, кв. 110')
INSERT [dbo].[students] ([student_ID], [student_name], [student_grade_ID], [student_birth_date], [student_phone_number], [student_home_address]) VALUES (5006, N'Кошелев Прокоп Тимофеевич', 127, CAST(N'2007-05-19' AS Date), N'+7 (660) 794-57-53', N'Россия, г. Москва, Совхозная ул., 43, корп. 1, кв. 125')
INSERT [dbo].[students] ([student_ID], [student_name], [student_grade_ID], [student_birth_date], [student_phone_number], [student_home_address]) VALUES (5007, N'Рожкова Юстина Филипповна', 127, CAST(N'2007-07-23' AS Date), N'+7 (923) 895-76-74', N'Россия, г. Москва, Первомайская ул., 97, корп. 6, кв. 183')
INSERT [dbo].[students] ([student_ID], [student_name], [student_grade_ID], [student_birth_date], [student_phone_number], [student_home_address]) VALUES (5008, N'Комиссаров Прокоп Игнатьевич', 124, CAST(N'2008-03-12' AS Date), N'+7 (806) 806-37-47', N'Россия, г. Москва, Ленинская ул., 33, корп. 1, кв. 157')
INSERT [dbo].[students] ([student_ID], [student_name], [student_grade_ID], [student_birth_date], [student_phone_number], [student_home_address]) VALUES (5009, N'Лыткин Павел Ильич', 124, CAST(N'2008-09-27' AS Date), N'+7 (992) 399-11-40', N'Россия, г. Москва, Ленинская ул., 2, корп. 8, кв. 198')
INSERT [dbo].[students] ([student_ID], [student_name], [student_grade_ID], [student_birth_date], [student_phone_number], [student_home_address]) VALUES (5010, N'Брагин Кирилл Денисович', 124, CAST(N'2008-04-14' AS Date), N'+7 (840) 281-93-31', N'Россия, г. Москва, Березовая ул., 72, корп. 1, кв. 164')
INSERT [dbo].[students] ([student_ID], [student_name], [student_grade_ID], [student_birth_date], [student_phone_number], [student_home_address]) VALUES (5011, N'Ковалева Найда Всеволодовна', 130, CAST(N'2006-07-13' AS Date), N'+7 (910) 295-90-81', N'Россия, г. Москва, Западная ул., 67, корп. 6, кв. 25')
INSERT [dbo].[students] ([student_ID], [student_name], [student_grade_ID], [student_birth_date], [student_phone_number], [student_home_address]) VALUES (5012, N'Мишин Василий Константинович', 100, CAST(N'2017-06-01' AS Date), N'+7 (918) 023-95-89', N'Россия, г. Москва, Космонавтов ул., 75, корп. 9, кв. 156')
INSERT [dbo].[students] ([student_ID], [student_name], [student_grade_ID], [student_birth_date], [student_phone_number], [student_home_address]) VALUES (5013, N'Стрелков Арсений Григорьевич', 130, CAST(N'2006-07-15' AS Date), N'+7 (919) 280-94-81', N'Россия, г. Москва, Школьная ул., 14, корп. 7, кв. 73')
INSERT [dbo].[students] ([student_ID], [student_name], [student_grade_ID], [student_birth_date], [student_phone_number], [student_home_address]) VALUES (5014, N'Сысоева Марфа Лукьяновна', 100, CAST(N'2017-03-27' AS Date), N'+7 (919) 283-50-98', N'Россия, г. Москва, Лесная ул., 5, корп. 8, кв. 27')
INSERT [dbo].[students] ([student_ID], [student_name], [student_grade_ID], [student_birth_date], [student_phone_number], [student_home_address]) VALUES (5015, N'Харитонова Анна Максимовна', 100, CAST(N'2017-04-07' AS Date), N'+7 (991) 820-98-40', N'Россия, г. Москва, Октябрьская ул., 16, корп. 8, кв. 136')
INSERT [dbo].[students] ([student_ID], [student_name], [student_grade_ID], [student_birth_date], [student_phone_number], [student_home_address]) VALUES (5016, N'Игнатьев Юрий Вячеславович', 100, CAST(N'2017-05-17' AS Date), N'+7 (921) 095-98-10', N'Россия, г. Москва, Сельская ул., 79, корп. 9, кв. 118')
INSERT [dbo].[students] ([student_ID], [student_name], [student_grade_ID], [student_birth_date], [student_phone_number], [student_home_address]) VALUES (5017, N'Воробьев Виктор Прохорович', 100, CAST(N'2017-08-14' AS Date), N'+7 (932) 095-80-91', N'Россия, г. Москва, Социалистическая ул., 28, корп. 9, кв. 16')
INSERT [dbo].[students] ([student_ID], [student_name], [student_grade_ID], [student_birth_date], [student_phone_number], [student_home_address]) VALUES (5018, N'Хохлов Давид Никандрович', 123, CAST(N'2009-09-18' AS Date), N'+7 (921) 908-05-97', N'Россия, г. Москва, Дружбы ул., 97, корп. 6, кв. 112')
INSERT [dbo].[students] ([student_ID], [student_name], [student_grade_ID], [student_birth_date], [student_phone_number], [student_home_address]) VALUES (5019, N'Васильев Иван Герасимович', 123, CAST(N'2009-05-19' AS Date), N'+7 (901) 209-54-98', N'Россия, г. Москва, Новоселов ул., 76, корп. 2, кв. 11')
INSERT [dbo].[students] ([student_ID], [student_name], [student_grade_ID], [student_birth_date], [student_phone_number], [student_home_address]) VALUES (5020, N'Кошелев Федор Иванович', 123, CAST(N'2009-01-27' AS Date), N'+7 (918) 350-97-82', N'Россия, г. Москва, Хуторская ул., 91, корп. 1, кв. 124')
INSERT [dbo].[students] ([student_ID], [student_name], [student_grade_ID], [student_birth_date], [student_phone_number], [student_home_address]) VALUES (5021, N'Носова Валерия Макаровна', 127, CAST(N'2007-05-13' AS Date), N'+7 (991) 809-52-10', N'Россия, г. Москва, Победы ул. 26, корп. 8, кв. 158')
INSERT [dbo].[students] ([student_ID], [student_name], [student_grade_ID], [student_birth_date], [student_phone_number], [student_home_address]) VALUES (5022, N'Курчанов Иван Николаевич', 100, CAST(N'2016-06-12' AS Date), N'+7 (919) 875-67-16', N'Россия, г. Москва, Советский пер., 88, корп. 1, кв. 198')
SET IDENTITY_INSERT [dbo].[students] OFF
GO
SET IDENTITY_INSERT [dbo].[teachers] ON 

INSERT [dbo].[teachers] ([teacher_ID], [teacher_name], [teacher_diplom_qualification], [teacher_birth_date], [teacher_phone_number], [teacher_home_address]) VALUES (10000, N'Эсце Денис Прокопьевич', 10, CAST(N'1995-12-23' AS Date), N'+7 (918) 793-99-48', N'Россия, г. Москва, Радужная ул., 74, корп. 5, кв. 146')
INSERT [dbo].[teachers] ([teacher_ID], [teacher_name], [teacher_diplom_qualification], [teacher_birth_date], [teacher_phone_number], [teacher_home_address]) VALUES (10002, N'Кулаков Леонтий Петрович', 11, CAST(N'1977-09-09' AS Date), N'+7 (914) 253-79-56', N'Россия, г. Копейск, Железнодорожная ул., д. 21 кв.66')
INSERT [dbo].[teachers] ([teacher_ID], [teacher_name], [teacher_diplom_qualification], [teacher_birth_date], [teacher_phone_number], [teacher_home_address]) VALUES (10003, N'Янборисов Тарас Валентинович', 12, CAST(N'1986-03-18' AS Date), N'+7 (986) 488-98-88', N'Россия, г. Пятигорск, Сельская ул., д. 3 кв.130')
INSERT [dbo].[teachers] ([teacher_ID], [teacher_name], [teacher_diplom_qualification], [teacher_birth_date], [teacher_phone_number], [teacher_home_address]) VALUES (10004, N'Проничева Раиса Нифонтовна', 13, CAST(N'1980-11-09' AS Date), N'+7 (946) 388-25-84', N'Россия, г. Домодедово, Садовая ул., д. 11 кв.217')
INSERT [dbo].[teachers] ([teacher_ID], [teacher_name], [teacher_diplom_qualification], [teacher_birth_date], [teacher_phone_number], [teacher_home_address]) VALUES (10005, N'Шишов Иван Георгиевич', 14, CAST(N'1966-02-12' AS Date), N'+7 (917) 204-76-57', N'Россия, г. Мурманск, Севернаяул., д. 23 кв.12')
INSERT [dbo].[teachers] ([teacher_ID], [teacher_name], [teacher_diplom_qualification], [teacher_birth_date], [teacher_phone_number], [teacher_home_address]) VALUES (10009, N'Черников Ефим Павлович', 15, CAST(N'1972-10-25' AS Date), N'+7 (924) 793-89-64', N'Россия, г. Тула, Рабочая ул., д. 25 кв.175')
INSERT [dbo].[teachers] ([teacher_ID], [teacher_name], [teacher_diplom_qualification], [teacher_birth_date], [teacher_phone_number], [teacher_home_address]) VALUES (10010, N'Машлыкина Ника Георгьевна', 16, CAST(N'1988-09-06' AS Date), N'+7 (994) 181-13-25', N'Россия, г. Раменское, Набережная ул., д. 8 кв.24')
INSERT [dbo].[teachers] ([teacher_ID], [teacher_name], [teacher_diplom_qualification], [teacher_birth_date], [teacher_phone_number], [teacher_home_address]) VALUES (10012, N'Шукшин Дмитрий Захарович', 17, CAST(N'1977-04-24' AS Date), N'+7 (980) 441-93-77', N'Россия, г. Тольятти, Первомайская ул., д. 18 кв.214')
INSERT [dbo].[teachers] ([teacher_ID], [teacher_name], [teacher_diplom_qualification], [teacher_birth_date], [teacher_phone_number], [teacher_home_address]) VALUES (10013, N'Скоробогатова Серафима Валентиновна', 18, CAST(N'1963-12-08' AS Date), N'+7 (937) 946-63-69', N'Россия, г. Железногорск, Солнечная ул., д. 7 кв.121')
INSERT [dbo].[teachers] ([teacher_ID], [teacher_name], [teacher_diplom_qualification], [teacher_birth_date], [teacher_phone_number], [teacher_home_address]) VALUES (10014, N'Мурогова Марианна Кирилловна', 19, CAST(N'1966-11-01' AS Date), N'+7 (938) 305-47-15', N'Россия, г. Курган, Победы ул., д. 23 кв.178')
INSERT [dbo].[teachers] ([teacher_ID], [teacher_name], [teacher_diplom_qualification], [teacher_birth_date], [teacher_phone_number], [teacher_home_address]) VALUES (10016, N'Тотенков Герман Никандрович', 20, CAST(N'1974-04-14' AS Date), N'+7 (968) 272-45-93', N'Россия, г. Рыбинск, Восточная ул., д. 1 кв.150')
INSERT [dbo].[teachers] ([teacher_ID], [teacher_name], [teacher_diplom_qualification], [teacher_birth_date], [teacher_phone_number], [teacher_home_address]) VALUES (10017, N'Дутов Семен Викторович', 21, CAST(N'1969-03-06' AS Date), N'+7 (969) 899-10-65', N'Россия, г. Белгород, Полевая ул., д. 18 кв.185')
INSERT [dbo].[teachers] ([teacher_ID], [teacher_name], [teacher_diplom_qualification], [teacher_birth_date], [teacher_phone_number], [teacher_home_address]) VALUES (10018, N'Красильникова Любовь Викторовна', 18, CAST(N'1981-08-21' AS Date), N'+7 (990) 259-48-19', N'Россия, г. Москва, Южная ул., 59, корп. 4, кв. 174')
INSERT [dbo].[teachers] ([teacher_ID], [teacher_name], [teacher_diplom_qualification], [teacher_birth_date], [teacher_phone_number], [teacher_home_address]) VALUES (10019, N'Родионов Юрий Макарович', 10, CAST(N'1971-11-01' AS Date), N'+7 (918) 923-75-98', N'Россия, г. Москва, Полевой пер., 87, корп. 1, кв. 187')
INSERT [dbo].[teachers] ([teacher_ID], [teacher_name], [teacher_diplom_qualification], [teacher_birth_date], [teacher_phone_number], [teacher_home_address]) VALUES (10020, N'Корнилов Степан Серафимович', 15, CAST(N'1989-04-27' AS Date), N'+7 (912) 098-59-18', N'Россия, г. Москва, Рабочая ул., 25, корп. 2, кв. 166')
SET IDENTITY_INSERT [dbo].[teachers] OFF
GO
ALTER TABLE [dbo].[performance]  WITH CHECK ADD FOREIGN KEY([performance_student_ID])
REFERENCES [dbo].[students] ([student_ID])
GO
ALTER TABLE [dbo].[performance]  WITH CHECK ADD FOREIGN KEY([performance_school_subject_ID])
REFERENCES [dbo].[school_subjects] ([school_subject_ID])
GO
ALTER TABLE [dbo].[performance]  WITH CHECK ADD FOREIGN KEY([performance_first_term_teacher_ID])
REFERENCES [dbo].[teachers] ([teacher_ID])
GO
ALTER TABLE [dbo].[performance]  WITH CHECK ADD FOREIGN KEY([performance_second_term_teacher_ID])
REFERENCES [dbo].[teachers] ([teacher_ID])
GO
ALTER TABLE [dbo].[students]  WITH CHECK ADD FOREIGN KEY([student_grade_ID])
REFERENCES [dbo].[grades] ([grade_ID])
GO
ALTER TABLE [dbo].[teachers]  WITH CHECK ADD FOREIGN KEY([teacher_diplom_qualification])
REFERENCES [dbo].[diplom_qualifications] ([diplom_qualification_ID])
GO
/****** Object:  StoredProcedure [dbo].[show_avg_mark]    Script Date: 28.06.2023 9:53:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[show_avg_mark]
 @school_subject_ID INT
AS
 SELECT school_subject_name, AVG(performance_first_term_mark) AS 'performance_AVG_first_term_mark', 
	AVG(performance_second_term_mark) AS 'performance_AVG_second_term_mark', 
	AVG(performance_overall_mark) AS 'performance_AVG_overall_mark'
FROM performance, school_subjects
WHERE performance_school_subject_ID = @school_subject_ID AND
	performance_school_subject_ID = school_subject_ID
GROUP BY school_subject_name
GO
USE [master]
GO
ALTER DATABASE [dedenevskaya_school] SET  READ_WRITE 
GO
