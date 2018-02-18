using Examine.Core.Models;
using Examine.Presentation.Controls;
using Examine.Presentation.Tags;
using static Examine.Presentation.Tags.Fluent;
using static Examine.Presentation.Controls.Fluent;

namespace Examine.Presentation.Views
{
    public class QuestionView : View
    {
        public QuestionView(Question question) : base(
            H4($"{question.DisplayOrder+1}: {question.Text}"),
            Input(InputType.Text).Attr("name", "answer"))                
        {
        }
    }
}