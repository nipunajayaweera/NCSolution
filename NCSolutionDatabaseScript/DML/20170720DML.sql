USE [NCSolutionDatabaseUpdateJuly]
GO
/****** Object:  StoredProcedure [dbo].[GetChapterByExam]    Script Date: 7/20/2017 3:21:05 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetChapterByExam]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetChapterByExam]
GO
/****** Object:  StoredProcedure [dbo].[GetAllExams]    Script Date: 7/20/2017 3:21:05 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAllExams]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetAllExams]
GO
/****** Object:  StoredProcedure [dbo].[GetAllExams]    Script Date: 7/20/2017 3:21:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAllExams]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetAllExams] AS' 
END
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllExams] 	
AS
BEGIN
	SELECT e.ExamDescription, e.TotalQuestions as TotalQuestions, e.CreatedDate as CreatedDate
	FROM Exam e 
END

GO
/****** Object:  StoredProcedure [dbo].[GetChapterByExam]    Script Date: 7/20/2017 3:21:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetChapterByExam]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetChapterByExam] AS' 
END
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	Get chapter names and  Number Of Questions From Chapter using examid
-- =============================================
CREATE PROCEDURE [dbo].[GetChapterByExam] 
	@examId int
AS
BEGIN
	SELECT c.ChapterName , ec.NumberOfQuestionsFromChapter 
	FROM  ExamChapter ec INNER JOIN Chapter c
	ON ec.ChapterId = c.ChapterId
	WHERE ec.ExamId = @examId
END

GO
