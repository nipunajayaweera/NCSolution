namespace NCSolution.Migrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class attributeforxams_isavtive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Exam", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Exam", "IsActive");
        }
    }
}
