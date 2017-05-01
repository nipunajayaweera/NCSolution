namespace NCSolution.Migrations.Migrations
{
    using NCSolution.DataAccessLayer;
    using NCSolution.DomainModel.Model;
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insertDatachapter : DbMigration
    {


        NCSolutionDbContext context = new NCSolutionDbContext();

        Chapter chapterOne = new Chapter()
        {
            ChapterName = "chapter one",
            ChapterDescription="xxxxxxxx",
            CreatedDate = DateTime.Now,
            CreatedBy = "sandun",
            UpdatedDate = DateTime.Now,
            UpdatedBy = "sandun"
        };

        Chapter chapterTwo = new Chapter()
        {
            ChapterName = "chapter two",
            ChapterDescription = "xxxxxxxx",
            CreatedDate = DateTime.Now,
            CreatedBy = "sandun",
            UpdatedDate = DateTime.Now,
            UpdatedBy = "sandun"
        };

        Chapter chapterThree = new Chapter()
        {
            ChapterName = "chapter Three",
            ChapterDescription = "xxxxxxxx",
            CreatedDate = DateTime.Now,
            CreatedBy = "sandun",
            UpdatedDate = DateTime.Now,
            UpdatedBy = "sandun"
        };







        public override void Up()
        {
            context.Chapters.AddOrUpdate(chapterOne,chapterTwo,chapterThree);
            context.SaveChanges();


        }
        
        public override void Down()
        {
        }
    }
}
