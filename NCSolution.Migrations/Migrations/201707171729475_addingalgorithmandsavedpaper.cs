namespace NCSolution.Migrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingalgorithmandsavedpaper : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Algorithms",
                c => new
                    {
                        AlgorithmId = c.Int(nullable: false, identity: true),
                        AlgorithmName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.AlgorithmId);
            
            CreateTable(
                "dbo.SavedPapers",
                c => new
                    {
                        SavedPaperId = c.Int(nullable: false, identity: true),
                        ExamId = c.Int(nullable: false),
                        QuestionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SavedPaperId)
                .ForeignKey("dbo.Exam", t => t.ExamId, cascadeDelete: true)
                .ForeignKey("dbo.Question", t => t.QuestionId, cascadeDelete: true)
                .Index(t => t.ExamId)
                .Index(t => t.QuestionId);
            
            AddColumn("dbo.Exam", "AlgorithmId", c => c.Int(nullable: false));
            CreateIndex("dbo.Exam", "AlgorithmId");
            AddForeignKey("dbo.Exam", "AlgorithmId", "dbo.Algorithms", "AlgorithmId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SavedPapers", "QuestionId", "dbo.Question");
            DropForeignKey("dbo.SavedPapers", "ExamId", "dbo.Exam");
            DropForeignKey("dbo.Exam", "AlgorithmId", "dbo.Algorithms");
            DropIndex("dbo.SavedPapers", new[] { "QuestionId" });
            DropIndex("dbo.SavedPapers", new[] { "ExamId" });
            DropIndex("dbo.Exam", new[] { "AlgorithmId" });
            DropColumn("dbo.Exam", "AlgorithmId");
            DropTable("dbo.SavedPapers");
            DropTable("dbo.Algorithms");
        }
    }
}
