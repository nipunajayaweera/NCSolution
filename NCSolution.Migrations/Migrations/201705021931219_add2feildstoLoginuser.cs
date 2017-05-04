namespace NCSolution.Migrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add2feildstoLoginuser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LoginUser", "Nic", c => c.String());
            AddColumn("dbo.LoginUser", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.LoginUser", "Password");
            DropColumn("dbo.LoginUser", "Nic");
        }
    }
}
