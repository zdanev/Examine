using System.Linq;
using Examine.Core.Models;
using Examine.Presentation.Controls;
using Examine.Presentation.Tags;
using static Examine.Presentation.Tags.Fluent;
using static Examine.Presentation.Controls.Fluent;

namespace Examine.Presentation.Views
{
    public class TestScoreView : View
    {
        public TestScoreView(Test test) : base(
            H3($"{test.Name} - {test.Score}/{test.Questions.Count}"),
            List(test.Questions.Select(question => new QuestionScoreView(question))))
        {
        }
    }
}