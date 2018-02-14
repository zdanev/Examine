using System.Collections.Generic;
using System.Linq;
using Examine.Core.Models;
using Examine.Html.Tags;
using static Examine.Html.Tags.Fluent;

namespace Examine.Html.Renderers
{
    public static class TestRenderer
    {
        public static IBodyElement Render(this Test test)
        {
            var content = new List<IBodyElement>();
            
            content.Add(H3(test.Name));
            content.AddRange(test.Questions.Select(question => question.Render()));

            return Div(content.ToArray());
        }

        public static IBodyElement Render(this Question question)
        {
            return Div(
                H4(question.Text)
            );
        }
    }
}