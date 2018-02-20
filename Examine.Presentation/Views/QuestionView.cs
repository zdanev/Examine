using Examine.Core.Models;
using Examine.Presentation.Controls;
using static Examine.Presentation.Controls.Fluent;

namespace Examine.Presentation.Views
{
    public class QuestionView : View
    {
        public QuestionView(Question question)
        {
            Content.Add(TextControl(
                id: $"q{question.DisplayOrder + 1}", 
                name: "answer", 
                label: $"{question.DisplayOrder + 1}: {question.Text}"));
        }
    }
}