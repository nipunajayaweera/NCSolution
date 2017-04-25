namespace NCSolution.Migrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LoginUser",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Email = c.String(),
                        LoginUserName = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LoginUser");
        }
    }
}
