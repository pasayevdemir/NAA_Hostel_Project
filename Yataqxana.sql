/****** Object:  Table [dbo].[Courpus]    Script Date: 17.05.2022 18:30:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courpus](
	[Corpus_ID] [int] IDENTITY(1,1) NOT NULL,
	[CorpusName] [nvarchar](15) NOT NULL,
	[RoomCount] [smallint] NOT NULL,
	[RoomNumber] [smallint] NOT NULL,
	[RoomCapacity] [smallint] NOT NULL,
	[Capacity] [smallint] NOT NULL,
 CONSTRAINT [PK_Courpus] PRIMARY KEY CLUSTERED 
(
	[Corpus_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 17.05.2022 18:30:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Student_ID] [int] IDENTITY(1,1) NOT NULL,
	[Corpus_ID] [int] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[DOB] [nvarchar](20) NOT NULL,
	[Qroup] [nvarchar](15) NOT NULL,
	[Phone] [nvarchar](25) NOT NULL,
	[Other] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Student_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[General1]    Script Date: 17.05.2022 18:30:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[General1]
AS
SELECT        dbo.Student.Student_ID, dbo.Student.Corpus_ID, dbo.Courpus.RoomNumber, dbo.Student.Name, dbo.Student.Address, dbo.Student.Qroup, dbo.Student.Phone, dbo.Student.Other
FROM            dbo.Courpus INNER JOIN
                         dbo.Student ON dbo.Courpus.Corpus_ID = dbo.Student.Corpus_ID
GO
/****** Object:  Table [dbo].[General]    Script Date: 17.05.2022 18:30:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[General](
	[General_ID] [int] IDENTITY(1,1) NOT NULL,
	[RoomNumber] [smallint] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Qroup] [nvarchar](15) NOT NULL,
	[Phone] [nvarchar](25) NOT NULL,
	[Other] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_General_1] PRIMARY KEY CLUSTERED 
(
	[General_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Courpus] ON 

INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (1, N'3', 36, 301, 2, 105)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (2, N'3', 36, 302, 3, 105)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (3, N'3', 36, 303, 2, 105)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (4, N'3', 36, 304, 3, 105)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (5, N'3', 36, 305, 3, 105)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (6, N'3', 36, 306, 3, 105)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (7, N'3', 36, 307, 2, 105)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (8, N'3', 36, 308, 3, 105)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (9, N'3', 36, 309, 3, 105)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (10, N'3', 36, 310, 3, 105)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (11, N'3', 36, 311, 2, 105)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (12, N'3', 36, 312, 4, 105)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (13, N'3', 36, 313, 2, 105)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (14, N'2', 23, 201, 2, 95)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (15, N'2', 23, 202, 2, 95)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (16, N'2', 23, 203, 3, 95)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (17, N'2', 23, 204, 2, 95)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (18, N'2', 23, 205, 3, 95)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (19, N'2', 23, 206, 3, 95)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (20, N'2', 23, 207, 3, 95)
SET IDENTITY_INSERT [dbo].[Courpus] OFF
GO
SET IDENTITY_INSERT [dbo].[General] ON 

INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (1, 304, N'Pasayev Damir Esqin', N'Gəncə şəhəri', N'1449a', N'125135561', N'655412654')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (2, 308, N'Cabbarov Mehdi Elsen', N'Göygöl rayonu', N'1449a', N'655412654', N'216551125')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (3, 301, N'Veliyev Abbas Qalib', N'Balakən rayonu', N'1159r', N'456484854', N'564848588')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (4, 302, N'Talibov Eli Sahib', N'Qax rayonu', N'2441a', N'652512314', N'456541511')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (5, 303, N'Eliyev Abutalib Abbas', N'Lənkaran', N'1159i', N'564541465', N'585444444')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (6, 305, N'Qenberov Esqin Veli', N'Lerik', N'1459a', N'465415454', N'656556212')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (7, 306, N'Memmedov Eli Talib', N'Gəncə', N'2440r', N'465654151', N'564848888')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (8, 307, N'Eliyev Mehemmed Xeqani', N'Daşkəsən', N'2441r', N'985565886', N'556588899')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (9, 304, N'Eliyev Eli Eli', N'Qax', N'1449a', N'554548665', N'845441215')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (10, 309, N'Xelilov Xalil Xeqani', N'Gəncə', N'1241a', N'564585448', N'668548228')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (11, 310, N'Ekbarov Veli Elsen', N'Lənkaran', N'1459a', N'654122558', N'884454747')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (12, 311, N'Memmedli Xelil Eli', N'Göycay', N'1159a', N'635448545', N'546588836')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (13, 312, N'Seferov Ruzi Bayram', N'Gəncə', N'1131i', N'456454155', N'645488665')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (14, 301, N'Bayramov Ferid Abbas', N'Daşkəsən', N'1121r', N'688688545', N'456848688')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (15, 313, N'Canbarev Umid Ramin', N'Lerik', N'1159a', N'645658885', N'546468888')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (16, 201, N'Əkbərov Dunyamali Aqil', N'Sumqayit', N'1449a', N'644885566', N'564566844')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (17, 203, N'Mammadzada Aqil Qabil', N'Lerik', N'1449a', N'545485555', N'457184187')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (18, 204, N'Bayramov Aqil Eli', N'Gəncə', N'1121i', N'665455548', N'545474744')
SET IDENTITY_INSERT [dbo].[General] OFF
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (1, 4, N'Pasayev Damir Esqin', N'Gəncə şəhəri', N'01/01/2001', N'1449a', N'125135561', N'655412654')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (2, 8, N'Cabbarov Mehdi Elsen', N'Göygöl rayonu', N'24/01/2002', N'1449a', N'655412654', N'216551125')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (3, 1, N'Veliyev Abbas Qalib', N'Balakən rayonu', N'02/01/2002', N'1159r', N'456484854', N'564848588')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (4, 2, N'Talibov Eli Sahib', N'Qax rayonu', N'12/01/2003', N'2441a', N'652512314', N'456541511')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (5, 3, N'Eliyev Abutalib Abbas', N'Lənkaran', N'06/10/2001', N'1159i', N'564541465', N'585444444')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (6, 5, N'Qenberov Esqin Veli', N'Lerik', N'08/06/2002', N'1459a', N'465415454', N'656556212')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (7, 6, N'Memmedov Eli Talib', N'Gəncə', N'07/11/2003', N'2440r', N'465654151', N'564848888')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (8, 7, N'Eliyev Mehemmed Xeqani', N'Daşkəsən', N'29/07/2003', N'2441r', N'985565886', N'556588899')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (9, 4, N'Eliyev Eli Eli', N'Qax', N'07/11/2002', N'1449a', N'554548665', N'845441215')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (10, 9, N'Xelilov Xalil Xeqani', N'Gəncə', N'08/03/2003', N'1241a', N'564585448', N'668548228')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (11, 10, N'Ekbarov Veli Elsen', N'Lənkaran', N'22/12/2002', N'1459a', N'654122558', N'884454747')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (12, 11, N'Memmedli Xelil Eli', N'Göycay', N'28/06/2002', N'1159a', N'635448545', N'546588836')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (13, 12, N'Seferov Ruzi Bayram', N'Gəncə', N'27/11/2002', N'1131i', N'456454155', N'645488665')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (14, 1, N'Bayramov Ferid Abbas', N'Daşkəsən', N'30/11/2002', N'1121r', N'688688545', N'456848688')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (15, 13, N'Canbarev Umid Ramin', N'Lerik', N'31/05/2002', N'1159a', N'645658885', N'546468888')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (16, 14, N'Əkbərov Dunyamali Aqil', N'Sumqayit', N'21/11/2001', N'1449a', N'644885566', N'564566844')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (17, 16, N'Mammadzada Aqil Qabil', N'Lerik', N'11/01/2002', N'1449a', N'545485555', N'457184187')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (18, 17, N'Bayramov Aqil Eli', N'Gəncə', N'12/02/2002', N'1121i', N'665455548', N'545474744')
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Courpus] FOREIGN KEY([Corpus_ID])
REFERENCES [dbo].[Courpus] ([Corpus_ID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Courpus]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Courpus"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Student"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'General1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'General1'
GO
