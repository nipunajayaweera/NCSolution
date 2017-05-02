namespace NCSolution.Migrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chapter_chapterexam_add_AuditableEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExamChapter", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.ExamChapter", "CreatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.ExamChapter", "UpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.ExamChapter", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Chapter", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Chapter", "CreatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Chapter", "UpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Chapter", "UpdatedBy", c => c.String(maxLength: 256));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Chapter", "UpdatedBy");
            DropColumn("dbo.Chapter", "UpdatedDate");
            DropColumn("dbo.Chapter", "CreatedBy");
            DropColumn("dbo.Chapter", "CreatedDate");
            DropColumn("dbo.ExamChapter", "UpdatedBy");
            DropColumn("dbo.ExamChapter", "UpdatedDate");
            DropColumn("dbo.ExamChapter", "CreatedBy");
            DropColumn("dbo.ExamChapter", "CreatedDate");
        }
    }
}
