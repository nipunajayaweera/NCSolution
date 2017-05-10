namespace NCSolution.Migrations.Migrations
{

    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NCSolution.DataAccessLayer.NCSolutionDbContext>
    {

     

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NCSolution.DataAccessLayer.NCSolutionDbContext context)
        {
                  

            //LoginUser[] users = context.LoginUsers.Select(o => o).ToArray<LoginUser>();
            //Exam[] exams = context.Exams.Select(o => o).ToArray<Exam>();

            //context.UserExamAttempts.AddOrUpdate(
            //    new UserExamAttempt
            //    {
            //        ExamId = exams[0].ExamId,
            //        LoginUserId = users[0].LoginUserId,
            //        ExamDate = new DateTime(2017, 04, 25),
            //        Attempt = 1,
            //        Marks = 50,
            //        CreatedDate = new DateTime(2017, 04, 25),
            //        CreatedBy = "sandun",
            //        UpdatedDate = new DateTime(2017, 04, 25),
            //        UpdatedBy = "Sandun",
            //        PassofFail = false
            //    },
            //      new UserExamAttempt
            //      {
            //          ExamId = exams[0].ExamId,
            //          LoginUserId = users[0].LoginUserId,
            //          ExamDate = new DateTime(2017, 04, 26),
            //          Attempt = 2,
            //          Marks = 75,
            //          CreatedDate = new DateTime(2017, 04, 26),
            //          CreatedBy = "sandun",
            //          UpdatedDate = new DateTime(2017, 04, 26),
            //          UpdatedBy = "Sandun",
            //          PassofFail = true
            //      },
            //       new UserExamAttempt
            //       {
            //           ExamId = exams[0].ExamId,
            //           LoginUserId = users[1].LoginUserId,
            //           ExamDate = new DateTime(2017, 04, 28),
            //           Attempt = 1,
            //           Marks = 90,
            //           CreatedDate = new DateTime(2017, 04, 28),
            //           CreatedBy = "sandun",
            //           UpdatedDate = new DateTime(2017, 04, 28),
            //           UpdatedBy = "Sandun",
            //           PassofFail = true
            //       },
            //        new UserExamAttempt
            //        {
            //            ExamId = exams[1].ExamId,
            //            LoginUserId = users[1].LoginUserId,
            //            ExamDate = new DateTime(2017, 04, 25),
            //            Attempt = 1,
            //            Marks = 78,
            //            CreatedDate = new DateTime(2017, 04, 25),
            //            CreatedBy = "sandun",
            //            UpdatedDate = new DateTime(2017, 04, 25),
            //            UpdatedBy = "Sandun",
            //            PassofFail = true
            //        }






            //    );

            //Chapter item = context.Chapters.Where(o => o.ChapterId == 7).First();

            //for (int i = 0; i < 15; i++)
            //{

            //    Question q = new Question
            //    {
            //        ChapterId = item.ChapterId,
            //        CanRandomizeChoices = false,
            //        DifficultyLevel = 1,
            //        Language = "ENG",
            //        NumberOfChoices = 4,
            //        Priority = 0,
            //        QuestionContent = "Q c -7" + RandomString(6),
            //        Explantion = "xxxxx",
            //        CreatedDate = DateTime.Now,
            //        CreatedBy = "sandun",
            //        UpdatedDate = DateTime.Now,
            //        UpdatedBy = "sandun",
            //        Tag = "xxx"

            //    };

            //    context.Questions.AddOrUpdate(q);
            //    context.SaveChanges();


            //    for (int k = 1; k < 5; k++)
            //    {
            //        Choice c = new Choice()
            //        {
            //            QuestionId = q.QuestionId,
            //            ChoiceString = "Qc7"+ "-C" + k + "-" + RandomString(4),
            //            IsJumble = false,
            //            Order = k,
            //            CorrentOrWrong = k == 2 ? true : false
            //        };

            //        context.Choices.AddOrUpdate(c);
            //        context.SaveChanges();

            //    }


            //}


            //var exam = context.Exams.Where(o => o.IsActive == true).First();
            //var examattempt = context.UserExamAttempts.First();
            //var ExamChapters = context.ExamChapters.Where(o=>o.ExamId == exam.ExamId );

            //List<NCSolution.DomainModel.Model.UserExamAttemptQuestion> list = new List<NCSolution.DomainModel.Model.UserExamAttemptQuestion>(); 

            //foreach (var item in ExamChapters)
            //{
            //    for (int i = 2; i < 5; i++)
            //    {
            //        list.Add(new NCSolution.DomainModel.Model.UserExamAttemptQuestion()
            //        {
                        
            //            Attempt = 5,
            //            ExamId = examattempt.ExamId,
            //            LoginUserId = examattempt.LoginUserId,
            //            QuestionId = context.Questions.Where(o => o.ChapterId == item.ChapterId).ToList()[i].QuestionId,
            //            ChoiceId = 3 ,
            //            CreatedDate = new DateTime(2017, 04, 25),
            //            CreatedBy = "sandun",
            //            UpdatedDate = new DateTime(2017, 04, 25),
            //            UpdatedBy = "Sandun"
            //        });

                   
            //    }

            //}

            //context.UserExamAttemptsQuestions.AddRange(list);
        








        }
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
