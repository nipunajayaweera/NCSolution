namespace NCSolution.Migrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserExamAttemptQuestion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserExamAttemptQuestion",
                c => new
                    {
                        ExamId = c.Int(nullable: false),
                        LoginUserId = c.Int(nullable: false),
                        Attempt = c.Int(nullable: false),
                        QuestionId = c.Int(nullable: false),
                        ChoiceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ExamId, t.LoginUserId, t.Attempt, t.QuestionId })
                .ForeignKey("dbo.Question", t => t.QuestionId, cascadeDelete: true)
                .ForeignKey("dbo.UserExamAttempt", t => new { t.ExamId, t.LoginUserId, t.Attempt }, cascadeDelete: true)
                .Index(t => new { t.ExamId, t.LoginUserId, t.Attempt })
                .Index(t => t.QuestionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserExamAttemptQuestion", new[] { "ExamId", "LoginUserId", "Attempt" }, "dbo.UserExamAttempt");
            DropForeignKey("dbo.UserExamAttemptQuestion", "QuestionId", "dbo.Question");
            DropIndex("dbo.UserExamAttemptQuestion", new[] { "QuestionId" });
            DropIndex("dbo.UserExamAttemptQuestion", new[] { "ExamId", "LoginUserId", "Attempt" });
            DropTable("dbo.UserExamAttemptQuestion");
        }
    }
}
