namespace NCSolution.Migrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chapter_chapterexam_models : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExamChapter",
                c => new
                    {
                        ExamId = c.Int(nullable: false),
                        ChapterId = c.Int(nullable: false),
                        NumberOfQuestionsFromChapter = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ExamId, t.ChapterId })
                .ForeignKey("dbo.Chapter", t => t.ChapterId, cascadeDelete: true)
                .ForeignKey("dbo.Exam", t => t.ExamId, cascadeDelete: true)
                .Index(t => t.ExamId)
                .Index(t => t.ChapterId);
            
            CreateTable(
                "dbo.Chapter",
                c => new
                    {
                        ChapterId = c.Int(nullable: false, identity: true),
                        ChapterName = c.String(),
                        ChapterDescription = c.String(),
                    })
                .PrimaryKey(t => t.ChapterId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExamChapter", "ExamId", "dbo.Exam");
            DropForeignKey("dbo.ExamChapter", "ChapterId", "dbo.Chapter");
            DropIndex("dbo.ExamChapter", new[] { "ChapterId" });
            DropIndex("dbo.ExamChapter", new[] { "ExamId" });
            DropTable("dbo.Chapter");
            DropTable("dbo.ExamChapter");
        }
    }
}
