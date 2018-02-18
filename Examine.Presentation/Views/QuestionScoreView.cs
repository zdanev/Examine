using Examine.Core.Models;
using Examine.Presentation.Controls;
using Examine.Presentation.Tags;
using static Examine.Presentation.Tags.Fluent;
using static Examine.Presentation.Controls.Fluent;

namespace Examine.Presentation.Views
{
    public class QuestionScoreView : View
    {
        public QuestionScoreView(Question question)
        {
            if (question.IsAnswerCorrect)
            {
                this.Content.Add(
                    H4($"{question.DisplayOrder+1}: {question.Text} {question.Answer}").Attr("style", "color:green")                
                );
            }
            else
            {
                this.Content.Add(
                    H4($"{question.DisplayOrder+1}: {question.Text} {question.CorrectAnswer} (Your answer: {question.Answer})").Attr("style", "color:red")                
                );
            }
        }
    }
}
