using System;

namespace Examine.Core.Models
{
    public class Question : Entity
    {
        public int DisplayOrder { get; set; }

        public string Text { get; set; }

        public string CorrectAnswer { get; set; }

        public string Answer { get; set; }

        public bool IsAnswerCorrect { get; set; }
    }
}