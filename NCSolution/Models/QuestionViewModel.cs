using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace NCSolution.Models
{
    class QuestionViewModel
    {
    }

    public class AddNewQuestion
    {
        public string Question { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string CorrectAnswer { get; set; }
        public string Chapter { get; set; }
        public SelectList ChaptersList { get; set; }
        public SelectList SectionList { get; set; }
    }
    
    public class QuestionFinalize
    {
        public int QuestionId { get; set; }
        public int YourAnswer { get; set; }
        public bool IsCorrect { get; set; }
        public string Question { get; set; }
    }

    public class FinalSummury
    {
        public List<QuestionFinalize> FinalizeQuestionList { get; set; }
        public int NoOfQuestions { get; set; }
        public int CorrectAnswers { get; set; }
    }

    public class Chapter
    {
        public int ChapterId { get; set; }
        public string ChapterName { get; set; }
        public List<Section> SectionList { get; set; }
    }

    public class Section
    {
        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public List<Question> QuestionList { get; set; }
    }

    public class Question
    {
        public int Id { get; set; }
        public string QuestionBody { get; set; }
        public List<Answer> AnswerList { get; set; }
        public int CorrectAnswerId { get; set; }
        public List<int> RelatedQuestionIds { get; set; }
    }
}
