using System.Linq;
using Examine.Core.Models;
using Examine.Presentation.Controls;
using Examine.Presentation.Tags;
using static Examine.Presentation.Tags.Fluent;
using static Examine.Presentation.Controls.Fluent;

namespace Examine.Presentation.Views
{
    public class TestView : View
    {
        public TestView(Test test) : base(
            Form(FormMethod.Post, 
                Hidden("id", test.Id.ToString()),
                H3(test.Name),
                List(test.Questions.Select(question => new QuestionView(question))),
                BR(),
                SubmitButton("Submit")))
        {
        }
    }
}