namespace NCSolution.Migrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _int : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exam",
                c => new
                    {
                        ExamId = c.Int(nullable: false, identity: true),
                        ExamDescription = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        TotalQuestions = c.Int(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.ExamId);
            
            CreateTable(
                "dbo.UserExamAttempt",
                c => new
                    {
                        ExamId = c.Int(nullable: false),
                        LoginUserId = c.Int(nullable: false),
                        Attempt = c.Int(nullable: false),
                        Marks = c.Int(nullable: false),
                        PassofFail = c.Boolean(nullable: false),
                        ExamDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.ExamId, t.LoginUserId, t.Attempt })
                .ForeignKey("dbo.Exam", t => t.ExamId, cascadeDelete: true)
                .ForeignKey("dbo.LoginUser", t => t.LoginUserId, cascadeDelete: true)
                .Index(t => t.ExamId)
                .Index(t => t.LoginUserId);
            
            CreateTable(
                "dbo.LoginUser",
                c => new
                    {
                        LoginUserId = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        LoginUserName = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.LoginUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserExamAttempt", "LoginUserId", "dbo.LoginUser");
            DropForeignKey("dbo.UserExamAttempt", "ExamId", "dbo.Exam");
            DropIndex("dbo.UserExamAttempt", new[] { "LoginUserId" });
            DropIndex("dbo.UserExamAttempt", new[] { "ExamId" });
            DropTable("dbo.LoginUser");
            DropTable("dbo.UserExamAttempt");
            DropTable("dbo.Exam");
        }
    }
}
