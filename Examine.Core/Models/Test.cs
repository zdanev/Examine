using System.Collections.Generic;
using System.Linq;

namespace Examine.Core.Models
{
    public class Test : Entity
    {
        public string Name { get; set; }

        public ICollection<Question> Questions { get; set; } = new List<Question>();

        public int Score => Questions.Count(q => q.IsAnswerCorrect);
    }
}