namespace NCSolution.Migrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class question_image_model : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        QuestionId = c.Int(nullable: false, identity: true),
                        QuestionContent = c.String(),
                        Explantion = c.String(),
                        NumberOfChoices = c.Int(nullable: false),
                        Priority = c.Int(nullable: false),
                        CanRandomizeChoices = c.Boolean(nullable: false),
                        DifficultyLevel = c.Int(nullable: false),
                        Language = c.String(),
                        Tag = c.String(),
                        ChapterId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.QuestionId)
                .ForeignKey("dbo.Chapter", t => t.ChapterId, cascadeDelete: true)
                .Index(t => t.ChapterId);
            
            CreateTable(
                "dbo.Image",
                c => new
                    {
                        ImageId = c.Int(nullable: false, identity: true),
                        Url = c.String(),
                        QuestionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ImageId)
                .ForeignKey("dbo.Question", t => t.QuestionId, cascadeDelete: true)
                .Index(t => t.QuestionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Image", "QuestionId", "dbo.Question");
            DropForeignKey("dbo.Question", "ChapterId", "dbo.Chapter");
            DropIndex("dbo.Image", new[] { "QuestionId" });
            DropIndex("dbo.Question", new[] { "ChapterId" });
            DropTable("dbo.Image");
            DropTable("dbo.Question");
        }
    }
}
