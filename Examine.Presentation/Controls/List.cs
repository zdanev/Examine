using System.Collections.Generic;
using System.Linq;
using Examine.Presentation.Tags;

namespace Examine.Presentation.Controls
{
    // TODO: PagedList

    public class List : Tag, IBodyElement
    {
        public List(IEnumerable<IBodyElement> content) : base("div", content.ToArray())
        {
        }
    }

    public static partial class Fluent
    {
        public static List List(IEnumerable<IBodyElement> content) => new List(content);
    }
}