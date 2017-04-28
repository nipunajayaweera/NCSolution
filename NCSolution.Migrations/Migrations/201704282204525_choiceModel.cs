namespace NCSolution.Migrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class choiceModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Choice",
                c => new
                    {
                        ChoiceId = c.Int(nullable: false, identity: true),
                        ChoiceString = c.String(),
                        Order = c.Int(nullable: false),
                        IsJumble = c.Boolean(nullable: false),
                        CorrentOrWrong = c.Boolean(nullable: false),
                        QuestionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ChoiceId)
                .ForeignKey("dbo.Question", t => t.QuestionId, cascadeDelete: true)
                .Index(t => t.QuestionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Choice", "QuestionId", "dbo.Question");
            DropIndex("dbo.Choice", new[] { "QuestionId" });
            DropTable("dbo.Choice");
        }
    }
}
