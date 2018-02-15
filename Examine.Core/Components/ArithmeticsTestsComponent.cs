using System;
using Examine.Core.Data;
using Examine.Core.Models;

namespace Examine.Core.Components
{
    public class ArithmeticsTestComponent : TestComponent
    {
        public ArithmeticsTestComponent(IRepository<Test> testRepo) : base(testRepo)
        {          
        }

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
                    DisplayOrder = i,
                    Text = Arithmetics.Expr(a, b, o),
                    CorrectAnswer = Arithmetics.Calc(a, b, o).ToString()
                });
            }

            _testRepo.Add(test);

            return test;
        }

        public Test ScoreTest(Guid testId, string[] answers)
        {
            var test = _testRepo.Get(testId);

            if (test == null) throw new InvalidOperationException("test not found!");

            foreach (var question in test.Questions)
            {
                question.Answer = answers[question.DisplayOrder];
                question.IsAnswerCorrect = question.Answer.Trim().ToLower() == question.CorrectAnswer.Trim().ToLower();
            }

            return test;
        }
    }
}