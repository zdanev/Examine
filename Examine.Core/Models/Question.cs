using System;

namespace Examine.Core.Models
{
    public class Question : Entity
    {
        public string Text { get; set; }

        public string Answer { get; set; }
    }
}