USE [ICTSkillsDataBase]
GO
/****** Object:  Table [dbo].[Candidates]    Script Date: 10/22/2021 5:17:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Candidates](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[School] [nvarchar](50) NOT NULL,
	[Company] [nvarchar](50) NOT NULL,
	[CompetitionId] [int] NOT NULL,
 CONSTRAINT [PK_Candidates] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Competitions]    Script Date: 10/22/2021 5:17:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Competitions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Year] [int] NULL,
 CONSTRAINT [PK_Competitions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Criteria]    Script Date: 10/22/2021 5:17:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Criteria](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nr] [int] NOT NULL,
	[Criterion] [nvarchar](50) NOT NULL,
	[Points] [int] NOT NULL,
	[CompetitionId] [int] NOT NULL,
 CONSTRAINT [PK_Criteria] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Evaluation]    Script Date: 10/22/2021 5:17:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evaluation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IsCompleted] [bit] NOT NULL,
	[CandidateId] [int] NOT NULL,
	[CriterionId] [int] NOT NULL,
 CONSTRAINT [PK_Evaluation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Candidates] ON 

INSERT [dbo].[Candidates] ([Id], [Name], [School], [Company], [CompetitionId]) VALUES (5, N'123', N'12312', N'123', 3)
INSERT [dbo].[Candidates] ([Id], [Name], [School], [Company], [CompetitionId]) VALUES (6, N'123', N'123', N'123', 4)
INSERT [dbo].[Candidates] ([Id], [Name], [School], [Company], [CompetitionId]) VALUES (7, N'q', N'q', N'q', 4)
INSERT [dbo].[Candidates] ([Id], [Name], [School], [Company], [CompetitionId]) VALUES (8, N'w', N'w', N'w', 4)
INSERT [dbo].[Candidates] ([Id], [Name], [School], [Company], [CompetitionId]) VALUES (9, N'e', N'e', N'e', 4)
INSERT [dbo].[Candidates] ([Id], [Name], [School], [Company], [CompetitionId]) VALUES (10, N'r', N'r', N'r', 4)
INSERT [dbo].[Candidates] ([Id], [Name], [School], [Company], [CompetitionId]) VALUES (11, N't', N't', N't', 4)
INSERT [dbo].[Candidates] ([Id], [Name], [School], [Company], [CompetitionId]) VALUES (12, N'u', N'u', N'u', 4)
SET IDENTITY_INSERT [dbo].[Candidates] OFF
GO
SET IDENTITY_INSERT [dbo].[Competitions] ON 

INSERT [dbo].[Competitions] ([Id], [Name], [Year]) VALUES (3, N'123', 123)
INSERT [dbo].[Competitions] ([Id], [Name], [Year]) VALUES (4, N'1', 1)
SET IDENTITY_INSERT [dbo].[Competitions] OFF
GO
SET IDENTITY_INSERT [dbo].[Criteria] ON 

INSERT [dbo].[Criteria] ([Id], [Nr], [Criterion], [Points], [CompetitionId]) VALUES (5, 1, N'test1', 1, 4)
INSERT [dbo].[Criteria] ([Id], [Nr], [Criterion], [Points], [CompetitionId]) VALUES (6, 2, N'etesr', 1, 4)
INSERT [dbo].[Criteria] ([Id], [Nr], [Criterion], [Points], [CompetitionId]) VALUES (7, 3, N'sdgsf', 1, 4)
INSERT [dbo].[Criteria] ([Id], [Nr], [Criterion], [Points], [CompetitionId]) VALUES (8, 4, N'test2', 1, 4)
INSERT [dbo].[Criteria] ([Id], [Nr], [Criterion], [Points], [CompetitionId]) VALUES (10, 5, N'test', 1, 4)
SET IDENTITY_INSERT [dbo].[Criteria] OFF
GO
SET IDENTITY_INSERT [dbo].[Evaluation] ON 

INSERT [dbo].[Evaluation] ([Id], [IsCompleted], [CandidateId], [CriterionId]) VALUES (6, 1, 7, 5)
INSERT [dbo].[Evaluation] ([Id], [IsCompleted], [CandidateId], [CriterionId]) VALUES (7, 1, 7, 6)
INSERT [dbo].[Evaluation] ([Id], [IsCompleted], [CandidateId], [CriterionId]) VALUES (8, 1, 7, 7)
INSERT [dbo].[Evaluation] ([Id], [IsCompleted], [CandidateId], [CriterionId]) VALUES (9, 1, 7, 8)
INSERT [dbo].[Evaluation] ([Id], [IsCompleted], [CandidateId], [CriterionId]) VALUES (10, 1, 7, 10)
INSERT [dbo].[Evaluation] ([Id], [IsCompleted], [CandidateId], [CriterionId]) VALUES (11, 1, 11, 5)
INSERT [dbo].[Evaluation] ([Id], [IsCompleted], [CandidateId], [CriterionId]) VALUES (12, 0, 11, 6)
INSERT [dbo].[Evaluation] ([Id], [IsCompleted], [CandidateId], [CriterionId]) VALUES (13, 0, 11, 7)
INSERT [dbo].[Evaluation] ([Id], [IsCompleted], [CandidateId], [CriterionId]) VALUES (14, 0, 11, 8)
INSERT [dbo].[Evaluation] ([Id], [IsCompleted], [CandidateId], [CriterionId]) VALUES (15, 0, 11, 10)
INSERT [dbo].[Evaluation] ([Id], [IsCompleted], [CandidateId], [CriterionId]) VALUES (36, 1, 12, 5)
INSERT [dbo].[Evaluation] ([Id], [IsCompleted], [CandidateId], [CriterionId]) VALUES (37, 1, 12, 6)
INSERT [dbo].[Evaluation] ([Id], [IsCompleted], [CandidateId], [CriterionId]) VALUES (38, 1, 12, 7)
INSERT [dbo].[Evaluation] ([Id], [IsCompleted], [CandidateId], [CriterionId]) VALUES (39, 1, 12, 8)
INSERT [dbo].[Evaluation] ([Id], [IsCompleted], [CandidateId], [CriterionId]) VALUES (40, 1, 12, 10)
SET IDENTITY_INSERT [dbo].[Evaluation] OFF
GO
ALTER TABLE [dbo].[Candidates]  WITH CHECK ADD  CONSTRAINT [FK_Candidates_Competitions] FOREIGN KEY([CompetitionId])
REFERENCES [dbo].[Competitions] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Candidates] CHECK CONSTRAINT [FK_Candidates_Competitions]
GO
ALTER TABLE [dbo].[Criteria]  WITH CHECK ADD  CONSTRAINT [FK_Criteria_Competitions] FOREIGN KEY([CompetitionId])
REFERENCES [dbo].[Competitions] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Criteria] CHECK CONSTRAINT [FK_Criteria_Competitions]
GO
ALTER TABLE [dbo].[Evaluation]  WITH CHECK ADD  CONSTRAINT [FK_Evaluation_Candidates] FOREIGN KEY([CandidateId])
REFERENCES [dbo].[Candidates] ([Id])
GO
ALTER TABLE [dbo].[Evaluation] CHECK CONSTRAINT [FK_Evaluation_Candidates]
GO
ALTER TABLE [dbo].[Evaluation]  WITH CHECK ADD  CONSTRAINT [FK_Evaluation_Criteria] FOREIGN KEY([CriterionId])
REFERENCES [dbo].[Criteria] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Evaluation] CHECK CONSTRAINT [FK_Evaluation_Criteria]
GO
