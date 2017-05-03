namespace NCSolution.Migrations.Migrations
{
    using DataAccessLayer;
    using DomainModel.Model;
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    public partial class userloginExamsdata_insert : DbMigration
    {
        NCSolutionDbContext context = new NCSolutionDbContext();
        public override void Up()
        {
            LoginUser[] users = context.LoginUsers.Select(o => o).ToArray<LoginUser>();
            Exam[] exams = context.Exams.Select(o => o).ToArray<Exam>();

            context.UserExamAttempts.AddOrUpdate(
                new UserExamAttempt
                {
                    ExamId = exams[0].ExamId,
                    LoginUserId = users[0].LoginUserId,
                    ExamDate = new DateTime(2017, 04, 25),
                    Attempt = 1,
                    Marks = 50,
                    CreatedDate = new DateTime(2017, 04, 25),
                    CreatedBy = "sandun",
                    UpdatedDate = new DateTime(2017, 04, 25),
                    UpdatedBy = "Sandun",
                    PassofFail = false
                },
                  new UserExamAttempt
                  {
                      ExamId = exams[0].ExamId,
                      LoginUserId = users[0].LoginUserId,
                      ExamDate = new DateTime(2017, 04, 26),
                      Attempt = 2,
                      Marks = 75,
                      CreatedDate = new DateTime(2017, 04, 26),
                      CreatedBy = "sandun",
                      UpdatedDate = new DateTime(2017, 04, 26),
                      UpdatedBy = "Sandun",
                      PassofFail = true
                  },
                   new UserExamAttempt
                   {
                       ExamId = exams[0].ExamId,
                       LoginUserId = users[1].LoginUserId,
                       ExamDate = new DateTime(2017, 04, 28),
                       Attempt = 1,
                       Marks = 90,
                       CreatedDate = new DateTime(2017, 04, 28),
                       CreatedBy = "sandun",
                       UpdatedDate = new DateTime(2017, 04, 28),
                       UpdatedBy = "Sandun",
                       PassofFail = true
                   },
                    new UserExamAttempt
                    {
                        ExamId = exams[1].ExamId,
                        LoginUserId = users[1].LoginUserId,
                        ExamDate = new DateTime(2017, 04, 25),
                        Attempt = 1,
                        Marks = 78,
                        CreatedDate = new DateTime(2017, 04, 25),
                        CreatedBy = "sandun",
                        UpdatedDate = new DateTime(2017, 04, 25),
                        UpdatedBy = "Sandun",
                        PassofFail = true
                    }






                );

            context.SaveChanges();



        }

        public override void Down()
        {
        }
    }
}
