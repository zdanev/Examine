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

            content.Add(Hidden("id", test.Id.ToString()));

            content.AddRange(test.Questions.Select(question => question.Render()));

            content.Add(Div(
                BR(),
                SubmitButton("Submit")));

            return Form(FormMethod.Post, content.ToArray());
        }

        public static IBodyElement Render(this Question question)
        {
            return Div(
                H4(question.Text),
                Input(InputType.Text).Attr("name", "answer")                
            );
        }
    }
}