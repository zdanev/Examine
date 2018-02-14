using System;
using Examine.Core.Models;

namespace Examine.Core.Components 
{
    public class TestComponent
    {
        public Test GetTest(Guid testId)
        {
            return new Test
            {
                Id = testId,
                Name = "Sample Test",
                Questions = new[]
                {
                    new Question 
                    {
                        Id = Guid.NewGuid(),
                        Text = "Sample question one"
                    },
                    new Question
                    {
                        Id = Guid.NewGuid(),
                        Text = "Sample question two"
                    },
                    new Question
                    {
                        Id = Guid.NewGuid(),
                        Text = "Sample question treee"
                    }
                }
            };
        }
    }
}