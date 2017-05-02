namespace NCSolution.Migrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class question_image_model_AuditableEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Question", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Question", "CreatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Question", "UpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Question", "UpdatedBy", c => c.String(maxLength: 256));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Question", "UpdatedBy");
            DropColumn("dbo.Question", "UpdatedDate");
            DropColumn("dbo.Question", "CreatedBy");
            DropColumn("dbo.Question", "CreatedDate");
        }
    }
}
