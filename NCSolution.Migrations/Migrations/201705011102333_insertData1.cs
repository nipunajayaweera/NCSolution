namespace NCSolution.Migrations.Migrations
{
    using NCSolution.DataAccessLayer;
    using NCSolution.DomainModel.Model;
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insertData1 : DbMigration
    {
    
    
  

        NCSolutionDbContext context = new NCSolutionDbContext();
        LoginUser kumaraLogin;
        LoginUser tokeLogin;
        Exam examTwo;
        Exam examOne;

        public override void Up()
        {

            //loginUser
            kumaraLogin = new LoginUser { LoginUserName = "kumara", PhoneNumber = 077, Email = "clive", CreatedDate = DateTime.Now, CreatedBy = "sandun", UpdatedDate = DateTime.Now, UpdatedBy = "sandun" };
            tokeLogin = new LoginUser { LoginUserName = "Toke", PhoneNumber = 077, Email = "toke", CreatedDate = DateTime.Now, CreatedBy = "toke", UpdatedDate = DateTime.Now, UpdatedBy = "toke" };
            context.LoginUsers.AddOrUpdate(
                                 kumaraLogin, tokeLogin

                );

            examTwo = new Exam { ExamDescription = "ExamTwo", TotalQuestions = 50, CreatedDate = DateTime.Now, CreatedBy = "sandun", UpdatedDate = DateTime.Now, UpdatedBy = "sandun" };
            examOne = new Exam { ExamDescription = "ExamOne", TotalQuestions = 40, CreatedDate = DateTime.Now, CreatedBy = "sandun", UpdatedDate = DateTime.Now, UpdatedBy = "sandun" };
            context.Exams.AddOrUpdate(examOne, examTwo);

            context.SaveChanges();


        }

        public override void Down()
        {
        }
    }
}
