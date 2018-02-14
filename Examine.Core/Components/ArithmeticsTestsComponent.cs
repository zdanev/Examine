using System;
using Examine.Core.Models;

namespace Examine.Core.Components
{
    public class ArithmeticsTestComponent
    {
        public Test GenerateTest(int count)
        {
            var rnd = new Random();

            var test = new Test { Id = Guid.NewGuid(), Name = "Arithmetics Test" };

            for (var i = 0; i < count; i++)
            {
                var a = rnd.Next(100);
                var b = rnd.Next(100);
                var o = (Arithmetics.Operator)rnd.Next(4);

                test.Questions.Add(new Question
                {
                    Id = Guid.NewGuid(),
                    Text = Arithmetics.Expr(a, b, o),
                    Answer = Arithmetics.Calc(a, b, o).ToString()
                });
            }

            return test;
        }
    }
}