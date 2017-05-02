namespace NCSolution.Migrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserExamAttemptQuestion_AuditableEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserExamAttemptQuestion", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.UserExamAttemptQuestion", "CreatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.UserExamAttemptQuestion", "UpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.UserExamAttemptQuestion", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.UserExamAttempt", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.UserExamAttempt", "CreatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.UserExamAttempt", "UpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.UserExamAttempt", "UpdatedBy", c => c.String(maxLength: 256));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserExamAttempt", "UpdatedBy");
            DropColumn("dbo.UserExamAttempt", "UpdatedDate");
            DropColumn("dbo.UserExamAttempt", "CreatedBy");
            DropColumn("dbo.UserExamAttempt", "CreatedDate");
            DropColumn("dbo.UserExamAttemptQuestion", "UpdatedBy");
            DropColumn("dbo.UserExamAttemptQuestion", "UpdatedDate");
            DropColumn("dbo.UserExamAttemptQuestion", "CreatedBy");
            DropColumn("dbo.UserExamAttemptQuestion", "CreatedDate");
        }
    }
}
