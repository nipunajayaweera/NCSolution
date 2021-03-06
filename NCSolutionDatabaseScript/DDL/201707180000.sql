IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.UserExamAttemptQuestion_dbo.UserExamAttempt_ExamId_LoginUserId_Attempt]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserExamAttemptQuestion]'))
ALTER TABLE [dbo].[UserExamAttemptQuestion] DROP CONSTRAINT [FK_dbo.UserExamAttemptQuestion_dbo.UserExamAttempt_ExamId_LoginUserId_Attempt]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.UserExamAttemptQuestion_dbo.Question_QuestionId]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserExamAttemptQuestion]'))
ALTER TABLE [dbo].[UserExamAttemptQuestion] DROP CONSTRAINT [FK_dbo.UserExamAttemptQuestion_dbo.Question_QuestionId]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.UserExamAttempt_dbo.LoginUser_LoginUserId]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserExamAttempt]'))
ALTER TABLE [dbo].[UserExamAttempt] DROP CONSTRAINT [FK_dbo.UserExamAttempt_dbo.LoginUser_LoginUserId]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.UserExamAttempt_dbo.Exam_ExamId]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserExamAttempt]'))
ALTER TABLE [dbo].[UserExamAttempt] DROP CONSTRAINT [FK_dbo.UserExamAttempt_dbo.Exam_ExamId]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.Sections_dbo.Chapter_ChapterId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Sections]'))
ALTER TABLE [dbo].[Sections] DROP CONSTRAINT [FK_dbo.Sections_dbo.Chapter_ChapterId]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.SavedPapers_dbo.Question_QuestionId]') AND parent_object_id = OBJECT_ID(N'[dbo].[SavedPapers]'))
ALTER TABLE [dbo].[SavedPapers] DROP CONSTRAINT [FK_dbo.SavedPapers_dbo.Question_QuestionId]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.SavedPapers_dbo.Exam_ExamId]') AND parent_object_id = OBJECT_ID(N'[dbo].[SavedPapers]'))
ALTER TABLE [dbo].[SavedPapers] DROP CONSTRAINT [FK_dbo.SavedPapers_dbo.Exam_ExamId]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.Question_dbo.Sections_SectionId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Question]'))
ALTER TABLE [dbo].[Question] DROP CONSTRAINT [FK_dbo.Question_dbo.Sections_SectionId]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.Image_dbo.Question_QuestionId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Image]'))
ALTER TABLE [dbo].[Image] DROP CONSTRAINT [FK_dbo.Image_dbo.Question_QuestionId]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.ExamChapter_dbo.Exam_ExamId]') AND parent_object_id = OBJECT_ID(N'[dbo].[ExamChapter]'))
ALTER TABLE [dbo].[ExamChapter] DROP CONSTRAINT [FK_dbo.ExamChapter_dbo.Exam_ExamId]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.ExamChapter_dbo.Chapter_ChapterId]') AND parent_object_id = OBJECT_ID(N'[dbo].[ExamChapter]'))
ALTER TABLE [dbo].[ExamChapter] DROP CONSTRAINT [FK_dbo.ExamChapter_dbo.Chapter_ChapterId]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.Exam_dbo.Algorithms_AlgorithmId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Exam]'))
ALTER TABLE [dbo].[Exam] DROP CONSTRAINT [FK_dbo.Exam_dbo.Algorithms_AlgorithmId]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.Choice_dbo.Question_QuestionId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Choice]'))
ALTER TABLE [dbo].[Choice] DROP CONSTRAINT [FK_dbo.Choice_dbo.Question_QuestionId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__UserExamA__Updat__693CA210]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[UserExamAttemptQuestion] DROP CONSTRAINT [DF__UserExamA__Updat__693CA210]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__UserExamA__Creat__68487DD7]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[UserExamAttemptQuestion] DROP CONSTRAINT [DF__UserExamA__Creat__68487DD7]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__UserExamA__Updat__6B24EA82]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[UserExamAttempt] DROP CONSTRAINT [DF__UserExamA__Updat__6B24EA82]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__UserExamA__Creat__6A30C649]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[UserExamAttempt] DROP CONSTRAINT [DF__UserExamA__Creat__6A30C649]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__Question__Sectio__02FC7413]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Question] DROP CONSTRAINT [DF__Question__Sectio__02FC7413]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__Question__Update__60A75C0F]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Question] DROP CONSTRAINT [DF__Question__Update__60A75C0F]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__Question__Create__5FB337D6]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Question] DROP CONSTRAINT [DF__Question__Create__5FB337D6]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__ExamChapt__Updat__571DF1D5]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ExamChapter] DROP CONSTRAINT [DF__ExamChapt__Updat__571DF1D5]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__ExamChapt__Creat__5629CD9C]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ExamChapter] DROP CONSTRAINT [DF__ExamChapt__Creat__5629CD9C]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__Exam__AlgorithmI__17F790F9]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Exam] DROP CONSTRAINT [DF__Exam__AlgorithmI__17F790F9]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__Chapter__Updated__59063A47]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Chapter] DROP CONSTRAINT [DF__Chapter__Updated__59063A47]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__Chapter__Created__5812160E]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Chapter] DROP CONSTRAINT [DF__Chapter__Created__5812160E]
END

GO
/****** Object:  Table [dbo].[UserExamAttemptQuestion]    Script Date: 7/17/2017 11:52:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserExamAttemptQuestion]') AND type in (N'U'))
DROP TABLE [dbo].[UserExamAttemptQuestion]
GO
/****** Object:  Table [dbo].[UserExamAttempt]    Script Date: 7/17/2017 11:52:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserExamAttempt]') AND type in (N'U'))
DROP TABLE [dbo].[UserExamAttempt]
GO
/****** Object:  Table [dbo].[Sections]    Script Date: 7/17/2017 11:52:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Sections]') AND type in (N'U'))
DROP TABLE [dbo].[Sections]
GO
/****** Object:  Table [dbo].[SavedPapers]    Script Date: 7/17/2017 11:52:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SavedPapers]') AND type in (N'U'))
DROP TABLE [dbo].[SavedPapers]
GO
/****** Object:  Table [dbo].[Question]    Script Date: 7/17/2017 11:52:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Question]') AND type in (N'U'))
DROP TABLE [dbo].[Question]
GO
/****** Object:  Table [dbo].[LoginUser]    Script Date: 7/17/2017 11:52:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LoginUser]') AND type in (N'U'))
DROP TABLE [dbo].[LoginUser]
GO
/****** Object:  Table [dbo].[Image]    Script Date: 7/17/2017 11:52:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Image]') AND type in (N'U'))
DROP TABLE [dbo].[Image]
GO
/****** Object:  Table [dbo].[ExamChapter]    Script Date: 7/17/2017 11:52:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ExamChapter]') AND type in (N'U'))
DROP TABLE [dbo].[ExamChapter]
GO
/****** Object:  Table [dbo].[Exam]    Script Date: 7/17/2017 11:52:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Exam]') AND type in (N'U'))
DROP TABLE [dbo].[Exam]
GO
/****** Object:  Table [dbo].[Choice]    Script Date: 7/17/2017 11:52:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Choice]') AND type in (N'U'))
DROP TABLE [dbo].[Choice]
GO
/****** Object:  Table [dbo].[Chapter]    Script Date: 7/17/2017 11:52:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Chapter]') AND type in (N'U'))
DROP TABLE [dbo].[Chapter]
GO
/****** Object:  Table [dbo].[Algorithms]    Script Date: 7/17/2017 11:52:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Algorithms]') AND type in (N'U'))
DROP TABLE [dbo].[Algorithms]
GO
/****** Object:  Table [dbo].[Algorithms]    Script Date: 7/17/2017 11:52:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Algorithms]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Algorithms](
	[AlgorithmId] [int] IDENTITY(1,1) NOT NULL,
	[AlgorithmName] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Algorithms] PRIMARY KEY CLUSTERED 
(
	[AlgorithmId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Chapter]    Script Date: 7/17/2017 11:52:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Chapter]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Chapter](
	[ChapterId] [int] IDENTITY(1,1) NOT NULL,
	[ChapterName] [nvarchar](max) NULL,
	[ChapterDescription] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](256) NULL,
	[UpdatedDate] [datetime] NOT NULL,
	[UpdatedBy] [nvarchar](256) NULL,
 CONSTRAINT [PK_dbo.Chapter] PRIMARY KEY CLUSTERED 
(
	[ChapterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Choice]    Script Date: 7/17/2017 11:52:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Choice]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Choice](
	[ChoiceId] [int] IDENTITY(1,1) NOT NULL,
	[ChoiceString] [nvarchar](max) NULL,
	[Order] [int] NOT NULL,
	[IsJumble] [bit] NOT NULL,
	[CorrentOrWrong] [bit] NOT NULL,
	[QuestionId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Choice] PRIMARY KEY CLUSTERED 
(
	[ChoiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Exam]    Script Date: 7/17/2017 11:52:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Exam]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Exam](
	[ExamId] [int] IDENTITY(1,1) NOT NULL,
	[ExamDescription] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[TotalQuestions] [int] NOT NULL,
	[CreatedBy] [nvarchar](256) NULL,
	[UpdatedDate] [datetime] NOT NULL,
	[UpdatedBy] [nvarchar](256) NULL,
	[AlgorithmId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Exam] PRIMARY KEY CLUSTERED 
(
	[ExamId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ExamChapter]    Script Date: 7/17/2017 11:52:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ExamChapter]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ExamChapter](
	[ExamId] [int] NOT NULL,
	[ChapterId] [int] NOT NULL,
	[NumberOfQuestionsFromChapter] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](256) NULL,
	[UpdatedDate] [datetime] NOT NULL,
	[UpdatedBy] [nvarchar](256) NULL,
 CONSTRAINT [PK_dbo.ExamChapter] PRIMARY KEY CLUSTERED 
(
	[ExamId] ASC,
	[ChapterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Image]    Script Date: 7/17/2017 11:52:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Image]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Image](
	[ImageId] [int] IDENTITY(1,1) NOT NULL,
	[Url] [nvarchar](max) NULL,
	[QuestionId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Image] PRIMARY KEY CLUSTERED 
(
	[ImageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[LoginUser]    Script Date: 7/17/2017 11:52:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LoginUser]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LoginUser](
	[LoginUserId] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[LoginUserName] [nvarchar](max) NULL,
	[PhoneNumber] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](256) NULL,
	[UpdatedDate] [datetime] NOT NULL,
	[UpdatedBy] [nvarchar](256) NULL,
	[Nic] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.LoginUser] PRIMARY KEY CLUSTERED 
(
	[LoginUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Question]    Script Date: 7/17/2017 11:52:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Question]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Question](
	[QuestionId] [int] IDENTITY(1,1) NOT NULL,
	[QuestionContent] [nvarchar](max) NULL,
	[Explantion] [nvarchar](max) NULL,
	[NumberOfChoices] [int] NOT NULL,
	[Priority] [int] NOT NULL,
	[CanRandomizeChoices] [bit] NOT NULL,
	[DifficultyLevel] [int] NOT NULL,
	[Language] [nvarchar](max) NULL,
	[Tag] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](256) NULL,
	[UpdatedDate] [datetime] NOT NULL,
	[UpdatedBy] [nvarchar](256) NULL,
	[SectionId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Question] PRIMARY KEY CLUSTERED 
(
	[QuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[SavedPapers]    Script Date: 7/17/2017 11:52:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SavedPapers]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[SavedPapers](
	[SavedPaperId] [int] IDENTITY(1,1) NOT NULL,
	[ExamId] [int] NOT NULL,
	[QuestionId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.SavedPapers] PRIMARY KEY CLUSTERED 
(
	[SavedPaperId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Sections]    Script Date: 7/17/2017 11:52:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Sections]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Sections](
	[SectionId] [int] IDENTITY(1,1) NOT NULL,
	[SectionName] [nvarchar](max) NULL,
	[ChapterId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Sections] PRIMARY KEY CLUSTERED 
(
	[SectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[UserExamAttempt]    Script Date: 7/17/2017 11:52:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserExamAttempt]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UserExamAttempt](
	[ExamId] [int] NOT NULL,
	[LoginUserId] [int] NOT NULL,
	[Attempt] [int] NOT NULL,
	[Marks] [int] NOT NULL,
	[PassofFail] [bit] NOT NULL,
	[ExamDate] [datetime] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](256) NULL,
	[UpdatedDate] [datetime] NOT NULL,
	[UpdatedBy] [nvarchar](256) NULL,
 CONSTRAINT [PK_dbo.UserExamAttempt] PRIMARY KEY CLUSTERED 
(
	[ExamId] ASC,
	[LoginUserId] ASC,
	[Attempt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[UserExamAttemptQuestion]    Script Date: 7/17/2017 11:52:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserExamAttemptQuestion]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UserExamAttemptQuestion](
	[ExamId] [int] NOT NULL,
	[LoginUserId] [int] NOT NULL,
	[Attempt] [int] NOT NULL,
	[QuestionId] [int] NOT NULL,
	[ChoiceId] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](256) NULL,
	[UpdatedDate] [datetime] NOT NULL,
	[UpdatedBy] [nvarchar](256) NULL,
 CONSTRAINT [PK_dbo.UserExamAttemptQuestion] PRIMARY KEY CLUSTERED 
(
	[ExamId] ASC,
	[LoginUserId] ASC,
	[Attempt] ASC,
	[QuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__Chapter__Created__5812160E]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Chapter] ADD  DEFAULT ('1900-01-01T00:00:00.000') FOR [CreatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__Chapter__Updated__59063A47]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Chapter] ADD  DEFAULT ('1900-01-01T00:00:00.000') FOR [UpdatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__Exam__AlgorithmI__17F790F9]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Exam] ADD  DEFAULT ((0)) FOR [AlgorithmId]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__ExamChapt__Creat__5629CD9C]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ExamChapter] ADD  DEFAULT ('1900-01-01T00:00:00.000') FOR [CreatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__ExamChapt__Updat__571DF1D5]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ExamChapter] ADD  DEFAULT ('1900-01-01T00:00:00.000') FOR [UpdatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__Question__Create__5FB337D6]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Question] ADD  DEFAULT ('1900-01-01T00:00:00.000') FOR [CreatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__Question__Update__60A75C0F]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Question] ADD  DEFAULT ('1900-01-01T00:00:00.000') FOR [UpdatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__Question__Sectio__02FC7413]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Question] ADD  DEFAULT ((0)) FOR [SectionId]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__UserExamA__Creat__6A30C649]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[UserExamAttempt] ADD  DEFAULT ('1900-01-01T00:00:00.000') FOR [CreatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__UserExamA__Updat__6B24EA82]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[UserExamAttempt] ADD  DEFAULT ('1900-01-01T00:00:00.000') FOR [UpdatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__UserExamA__Creat__68487DD7]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[UserExamAttemptQuestion] ADD  DEFAULT ('1900-01-01T00:00:00.000') FOR [CreatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__UserExamA__Updat__693CA210]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[UserExamAttemptQuestion] ADD  DEFAULT ('1900-01-01T00:00:00.000') FOR [UpdatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.Choice_dbo.Question_QuestionId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Choice]'))
ALTER TABLE [dbo].[Choice]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Choice_dbo.Question_QuestionId] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[Question] ([QuestionId])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.Choice_dbo.Question_QuestionId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Choice]'))
ALTER TABLE [dbo].[Choice] CHECK CONSTRAINT [FK_dbo.Choice_dbo.Question_QuestionId]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.Exam_dbo.Algorithms_AlgorithmId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Exam]'))
ALTER TABLE [dbo].[Exam]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Exam_dbo.Algorithms_AlgorithmId] FOREIGN KEY([AlgorithmId])
REFERENCES [dbo].[Algorithms] ([AlgorithmId])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.Exam_dbo.Algorithms_AlgorithmId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Exam]'))
ALTER TABLE [dbo].[Exam] CHECK CONSTRAINT [FK_dbo.Exam_dbo.Algorithms_AlgorithmId]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.ExamChapter_dbo.Chapter_ChapterId]') AND parent_object_id = OBJECT_ID(N'[dbo].[ExamChapter]'))
ALTER TABLE [dbo].[ExamChapter]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ExamChapter_dbo.Chapter_ChapterId] FOREIGN KEY([ChapterId])
REFERENCES [dbo].[Chapter] ([ChapterId])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.ExamChapter_dbo.Chapter_ChapterId]') AND parent_object_id = OBJECT_ID(N'[dbo].[ExamChapter]'))
ALTER TABLE [dbo].[ExamChapter] CHECK CONSTRAINT [FK_dbo.ExamChapter_dbo.Chapter_ChapterId]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.ExamChapter_dbo.Exam_ExamId]') AND parent_object_id = OBJECT_ID(N'[dbo].[ExamChapter]'))
ALTER TABLE [dbo].[ExamChapter]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ExamChapter_dbo.Exam_ExamId] FOREIGN KEY([ExamId])
REFERENCES [dbo].[Exam] ([ExamId])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.ExamChapter_dbo.Exam_ExamId]') AND parent_object_id = OBJECT_ID(N'[dbo].[ExamChapter]'))
ALTER TABLE [dbo].[ExamChapter] CHECK CONSTRAINT [FK_dbo.ExamChapter_dbo.Exam_ExamId]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.Image_dbo.Question_QuestionId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Image]'))
ALTER TABLE [dbo].[Image]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Image_dbo.Question_QuestionId] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[Question] ([QuestionId])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.Image_dbo.Question_QuestionId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Image]'))
ALTER TABLE [dbo].[Image] CHECK CONSTRAINT [FK_dbo.Image_dbo.Question_QuestionId]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.Question_dbo.Sections_SectionId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Question]'))
ALTER TABLE [dbo].[Question]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Question_dbo.Sections_SectionId] FOREIGN KEY([SectionId])
REFERENCES [dbo].[Sections] ([SectionId])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.Question_dbo.Sections_SectionId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Question]'))
ALTER TABLE [dbo].[Question] CHECK CONSTRAINT [FK_dbo.Question_dbo.Sections_SectionId]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.SavedPapers_dbo.Exam_ExamId]') AND parent_object_id = OBJECT_ID(N'[dbo].[SavedPapers]'))
ALTER TABLE [dbo].[SavedPapers]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SavedPapers_dbo.Exam_ExamId] FOREIGN KEY([ExamId])
REFERENCES [dbo].[Exam] ([ExamId])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.SavedPapers_dbo.Exam_ExamId]') AND parent_object_id = OBJECT_ID(N'[dbo].[SavedPapers]'))
ALTER TABLE [dbo].[SavedPapers] CHECK CONSTRAINT [FK_dbo.SavedPapers_dbo.Exam_ExamId]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.SavedPapers_dbo.Question_QuestionId]') AND parent_object_id = OBJECT_ID(N'[dbo].[SavedPapers]'))
ALTER TABLE [dbo].[SavedPapers]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SavedPapers_dbo.Question_QuestionId] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[Question] ([QuestionId])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.SavedPapers_dbo.Question_QuestionId]') AND parent_object_id = OBJECT_ID(N'[dbo].[SavedPapers]'))
ALTER TABLE [dbo].[SavedPapers] CHECK CONSTRAINT [FK_dbo.SavedPapers_dbo.Question_QuestionId]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.Sections_dbo.Chapter_ChapterId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Sections]'))
ALTER TABLE [dbo].[Sections]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Sections_dbo.Chapter_ChapterId] FOREIGN KEY([ChapterId])
REFERENCES [dbo].[Chapter] ([ChapterId])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.Sections_dbo.Chapter_ChapterId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Sections]'))
ALTER TABLE [dbo].[Sections] CHECK CONSTRAINT [FK_dbo.Sections_dbo.Chapter_ChapterId]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.UserExamAttempt_dbo.Exam_ExamId]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserExamAttempt]'))
ALTER TABLE [dbo].[UserExamAttempt]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UserExamAttempt_dbo.Exam_ExamId] FOREIGN KEY([ExamId])
REFERENCES [dbo].[Exam] ([ExamId])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.UserExamAttempt_dbo.Exam_ExamId]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserExamAttempt]'))
ALTER TABLE [dbo].[UserExamAttempt] CHECK CONSTRAINT [FK_dbo.UserExamAttempt_dbo.Exam_ExamId]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.UserExamAttempt_dbo.LoginUser_LoginUserId]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserExamAttempt]'))
ALTER TABLE [dbo].[UserExamAttempt]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UserExamAttempt_dbo.LoginUser_LoginUserId] FOREIGN KEY([LoginUserId])
REFERENCES [dbo].[LoginUser] ([LoginUserId])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.UserExamAttempt_dbo.LoginUser_LoginUserId]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserExamAttempt]'))
ALTER TABLE [dbo].[UserExamAttempt] CHECK CONSTRAINT [FK_dbo.UserExamAttempt_dbo.LoginUser_LoginUserId]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.UserExamAttemptQuestion_dbo.Question_QuestionId]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserExamAttemptQuestion]'))
ALTER TABLE [dbo].[UserExamAttemptQuestion]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UserExamAttemptQuestion_dbo.Question_QuestionId] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[Question] ([QuestionId])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.UserExamAttemptQuestion_dbo.Question_QuestionId]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserExamAttemptQuestion]'))
ALTER TABLE [dbo].[UserExamAttemptQuestion] CHECK CONSTRAINT [FK_dbo.UserExamAttemptQuestion_dbo.Question_QuestionId]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.UserExamAttemptQuestion_dbo.UserExamAttempt_ExamId_LoginUserId_Attempt]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserExamAttemptQuestion]'))
ALTER TABLE [dbo].[UserExamAttemptQuestion]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UserExamAttemptQuestion_dbo.UserExamAttempt_ExamId_LoginUserId_Attempt] FOREIGN KEY([ExamId], [LoginUserId], [Attempt])
REFERENCES [dbo].[UserExamAttempt] ([ExamId], [LoginUserId], [Attempt])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.UserExamAttemptQuestion_dbo.UserExamAttempt_ExamId_LoginUserId_Attempt]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserExamAttemptQuestion]'))
ALTER TABLE [dbo].[UserExamAttemptQuestion] CHECK CONSTRAINT [FK_dbo.UserExamAttemptQuestion_dbo.UserExamAttempt_ExamId_LoginUserId_Attempt]
GO
