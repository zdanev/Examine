using System.Collections.Generic;
using System.Linq;
using Examine.Core.Models;
using Examine.Html.Tags;
using static Examine.Html.Tags.Fluent;

namespace Examine.Html.Renderers
{
    public static class TestRenderer
    {
        public static IBodyElement Render(Test test)
        {
            var content = new List<IBodyElement>();
            
            content.Add(H3(test.Name));

            content.Add(Hidden("id", test.Id.ToString()));

            content.AddRange(test.Questions.Select(question => Render(question)));

            content.Add(Div(
                BR(),
                SubmitButton("Submit")));

            return Form(FormMethod.Post, content.ToArray());
        }

        public static IBodyElement Render(Question question)
        {
            return Div(
                H4($"{question.DisplayOrder+1}: {question.Text}"),
                Input(InputType.Text).Attr("name", "answer")                
            );
        }

        public static IBodyElement RenderScore(Test test)
        {
            var content = new List<IBodyElement>();

            content.Add(H3($"{test.Name} - {test.Score}/{test.Questions.Count}"));

            content.AddRange(test.Questions.Select(question => RenderAnswer(question)));
            
            return Div(content.ToArray());
        }

        public static IBodyElement RenderAnswer(Question question)
        {
            if (question.IsAnswerCorrect)
            {
                return Div(
                    H4($"{question.DisplayOrder+1}: {question.Text} {question.Answer}").Attr("style", "color:green")                
                );
            }
            else
            {
                return Div(
                    H4($"{question.DisplayOrder+1}: {question.Text} {question.CorrectAnswer} (Your answer: {question.Answer})").Attr("style", "color:red")                
                );
            }
        }
    }
}