using System.Collections.Generic;

namespace Examine.Core.Models
{
    public class Test : Entity
    {
        public string Name { get; set; }

        public ICollection<Question> Questions { get; set; } = new List<Question>();
    }
}