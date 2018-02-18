using System.Collections.Generic;
using System.Linq;
using Examine.Core.Models;
using Examine.Presentation.Tags;
using static Examine.Presentation.Tags.Fluent;
using static Examine.Presentation.Controls.Fluent;

namespace Examine.Presentation.Renderers
{
    public static class TestRenderer
    {
        public static IBodyElement Render(Test test)
        {
            return Form(FormMethod.Post, 
                Hidden("id", test.Id.ToString()),
                H3(test.Name),
                List(test.Questions.Select(question => Render(question))),
                BR(),
                SubmitButton("Submit"));
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
            return Div(
                H3($"{test.Name} - {test.Score}/{test.Questions.Count}"),
                List(test.Questions.Select(question => RenderAnswer(question))));
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