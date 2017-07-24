namespace NCSolution.Migrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sectiontable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Question", "ChapterId", "dbo.Chapter");
            DropIndex("dbo.Question", new[] { "ChapterId" });
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        SectionId = c.Int(nullable: false, identity: true),
                        SectionName = c.String(),
                        ChapterId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SectionId)
                .ForeignKey("dbo.Chapter", t => t.ChapterId, cascadeDelete: true)
                .Index(t => t.ChapterId);
            
            AddColumn("dbo.Question", "SectionId", c => c.Int(nullable: false));
            CreateIndex("dbo.Question", "SectionId");
            AddForeignKey("dbo.Question", "SectionId", "dbo.Sections", "SectionId", cascadeDelete: true);
            DropColumn("dbo.Question", "ChapterId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Question", "ChapterId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Question", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.Sections", "ChapterId", "dbo.Chapter");
            DropIndex("dbo.Sections", new[] { "ChapterId" });
            DropIndex("dbo.Question", new[] { "SectionId" });
            DropColumn("dbo.Question", "SectionId");
            DropTable("dbo.Sections");
            CreateIndex("dbo.Question", "ChapterId");
            AddForeignKey("dbo.Question", "ChapterId", "dbo.Chapter", "ChapterId", cascadeDelete: true);
        }
    }
}
