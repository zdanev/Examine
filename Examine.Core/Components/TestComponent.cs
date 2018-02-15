using System;
using Examine.Core.Models;
using Examine.Core.Data;

namespace Examine.Core.Components 
{
    public class TestComponent
    {
        protected readonly IRepository<Test> _testRepo;

        public TestComponent(IRepository<Test> testRepo)
        {
            _testRepo = testRepo;
        }

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