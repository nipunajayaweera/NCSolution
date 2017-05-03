namespace NCSolution.Migrations.Migrations
{
    using DataAccessLayer;
    using DomainModel.Model;
    using System;
    using System.Data.Entity.Migrations;


    //insert chapter 2

    public partial class insertExamchapter : DbMigration
    {
        NCSolutionDbContext context = new NCSolutionDbContext();
        Chapter chapterFive;
        Chapter chapterSix;
        Chapter chapterSeven;

        public override void Up()
        {

            chapterFive = new Chapter
            {
                ChapterName = "chapter Five",
                ChapterDescription = "CXXXXXX",
                CreatedDate = DateTime.Now,
                CreatedBy = "sandun",
                UpdatedDate = DateTime.Now,
                UpdatedBy = "sandun"
            };
            chapterSix = new Chapter
            {
                ChapterName = "chapter Six",
                ChapterDescription = "CXXXXXX",
                CreatedDate = DateTime.Now,
                CreatedBy = "sandun",
                UpdatedDate = DateTime.Now,
                UpdatedBy = "sandun"
            };

            chapterSeven = new Chapter
            {
                ChapterName = "chapter Seven",
                ChapterDescription = "CXXXXXX",
                CreatedDate = DateTime.Now,
                CreatedBy = "sandun",
                UpdatedDate = DateTime.Now,
                UpdatedBy = "sandun"
            };

        

            context.Chapters.AddOrUpdate(chapterSix, chapterFive, chapterSeven);

            context.SaveChanges();







        }
        
        public override void Down()
        {
        }
    }
}
