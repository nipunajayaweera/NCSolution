namespace NCSolution.Migrations.Migrations
{
    using DataAccessLayer;
    using DomainModel.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;
    public partial class insertQuestionpart2 : DbMigration
    {

        NCSolutionDbContext context = new NCSolutionDbContext();


        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public override void Up()
        {

            List<Chapter> chapters2 = context.Chapters.Where(o => o.ChapterName.Equals("chapter Five") || o.ChapterName.Equals("chapter Six") || o.ChapterName.Equals("chapter Seven")).ToList<Chapter>(); ;

            int quesnumber = 2000;

            foreach (Chapter item in chapters2)
            {
                for (int i = 0; i < 15; i++)
                {

                    Question q = new Question
                    {
                        ChapterId = item.ChapterId,
                        CanRandomizeChoices = false,
                        DifficultyLevel = 1,
                        Language = "ENG",
                        NumberOfChoices = 4,
                        Priority = 0,
                        QuestionContent = "Q" + quesnumber + "-" + RandomString(6),
                        Explantion = "xxxxx",
                        CreatedDate = DateTime.Now,
                        CreatedBy = "sandun",
                        UpdatedDate = DateTime.Now,
                        UpdatedBy = "sandun",
                        Tag = "xxx"

                    };

                    context.Questions.AddOrUpdate(q);
                    context.SaveChanges();


                    for (int k = 1; k < 5; k++)
                    {
                        Choice c = new Choice()
                        {
                            QuestionId = q.QuestionId,
                            ChoiceString = "Q" + quesnumber + "-C" + k + "-" + RandomString(4),
                            IsJumble = false,
                            Order = k,
                            CorrentOrWrong = k == 2 ? true : false
                        };

                        context.Choices.AddOrUpdate(c);
                        context.SaveChanges();

                    }
                    quesnumber++;

                }

            }



        }
        
        public override void Down()
        {
        }
    }
}
