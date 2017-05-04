namespace NCSolution.Migrations.Migrations
{
    using DataAccessLayer;
    using DomainModel.Model;
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    public partial class inserdatatoexamchpter2 : DbMigration
    {
        NCSolutionDbContext context = new NCSolutionDbContext();
        public override void Up()
        {
            Chapter[] chapters = context.Chapters.Select(o => o).ToArray<Chapter>();
            Exam[] exams = context.Exams.Select(o => o).ToArray<Exam>();

            context.ExamChapters.AddOrUpdate(
                new ExamChapter
                {
                    ExamId = exams[0].ExamId,
                    ChapterId = chapters[0].ChapterId,
                    NumberOfQuestionsFromChapter = 7,
                    CreatedDate = new DateTime(2017, 04, 25),
                    CreatedBy = "sandun",
                    UpdatedDate = new DateTime(2017, 04, 25),
                    UpdatedBy = "Sandun"
                },
                new ExamChapter
                {
                    ExamId = exams[0].ExamId,
                    ChapterId = chapters[1].ChapterId,
                    NumberOfQuestionsFromChapter = 7,
                    CreatedDate = new DateTime(2017, 04, 25),
                    CreatedBy = "sandun",
                    UpdatedDate = new DateTime(2017, 04, 25),
                    UpdatedBy = "Sandun"
                },

                new ExamChapter
                {
                    ExamId = exams[0].ExamId,
                    ChapterId = chapters[3].ChapterId,
                    NumberOfQuestionsFromChapter = 7,
                    CreatedDate = new DateTime(2017, 04, 25),
                    CreatedBy = "sandun",
                    UpdatedDate = new DateTime(2017, 04, 25),
                    UpdatedBy = "Sandun"
                },
                new ExamChapter
                {
                    ExamId = exams[0].ExamId,
                    ChapterId = chapters[4].ChapterId,
                    NumberOfQuestionsFromChapter = 9,
                    CreatedDate = new DateTime(2017, 04, 25),
                    CreatedBy = "sandun",
                    UpdatedDate = new DateTime(2017, 04, 25),
                    UpdatedBy = "Sandun"
                },
                new ExamChapter
                {
                    ExamId = exams[0].ExamId,
                    ChapterId = chapters[5].ChapterId,
                    NumberOfQuestionsFromChapter = 5,
                    CreatedDate = new DateTime(2017, 04, 25),
                    CreatedBy = "sandun",
                    UpdatedDate = new DateTime(2017, 04, 25),
                    UpdatedBy = "Sandun"
                },
                new ExamChapter
                {
                    ExamId = exams[0].ExamId,
                    ChapterId = chapters[6].ChapterId,
                    NumberOfQuestionsFromChapter = 5,
                    CreatedDate = new DateTime(2017, 04, 25),
                    CreatedBy = "sandun",
                    UpdatedDate = new DateTime(2017, 04, 25),
                    UpdatedBy = "Sandun"
                }


            );

            context.SaveChanges();

            context.ExamChapters.AddOrUpdate(
                new ExamChapter
                {
                    ExamId = exams[1].ExamId,
                    ChapterId = chapters[0].ChapterId,
                    NumberOfQuestionsFromChapter = 10,
                    CreatedDate = new DateTime(2017, 04, 25),
                    CreatedBy = "sandun",
                    UpdatedDate = new DateTime(2017, 04, 25),
                    UpdatedBy = "Sandun"
                },
                new ExamChapter
                {
                    ExamId = exams[1].ExamId,
                    ChapterId = chapters[1].ChapterId,
                    NumberOfQuestionsFromChapter = 7,
                    CreatedDate = new DateTime(2017, 04, 25),
                    CreatedBy = "sandun",
                    UpdatedDate = new DateTime(2017, 04, 25),
                    UpdatedBy = "Sandun"
                },
                new ExamChapter
                {
                    ExamId = exams[1].ExamId,
                    ChapterId = chapters[3].ChapterId,
                    NumberOfQuestionsFromChapter = 7,
                    CreatedDate = new DateTime(2017, 04, 25),
                    CreatedBy = "sandun",
                    UpdatedDate = new DateTime(2017, 04, 25),
                    UpdatedBy = "Sandun"
                },

                new ExamChapter
                {
                    ExamId = exams[1].ExamId,
                    ChapterId = chapters[5].ChapterId,
                    NumberOfQuestionsFromChapter = 10,
                    CreatedDate = new DateTime(2017, 04, 25),
                    CreatedBy = "sandun",
                    UpdatedDate = new DateTime(2017, 04, 25),
                    UpdatedBy = "Sandun"
                },
                new ExamChapter
                {
                    ExamId = exams[1].ExamId,
                    ChapterId = chapters[6].ChapterId,
                    NumberOfQuestionsFromChapter = 8,
                    CreatedDate = new DateTime(2017, 04, 25),
                    CreatedBy = "sandun",
                    UpdatedDate = new DateTime(2017, 04, 25),
                    UpdatedBy = "Sandun"
                }
                    ,
                new ExamChapter
                {
                    ExamId = exams[1].ExamId,
                    ChapterId = chapters[6].ChapterId,
                    NumberOfQuestionsFromChapter = 8,
                    CreatedDate = new DateTime(2017, 04, 25),
                    CreatedBy = "sandun",
                    UpdatedDate = new DateTime(2017, 04, 25),
                    UpdatedBy = "Sandun"
                }


            );

            context.SaveChanges();





        }

        public override void Down()
        {
        }
    }
}
