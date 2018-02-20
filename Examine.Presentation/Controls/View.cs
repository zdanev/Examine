using System.Linq;
using System.Text;
using Examine.Presentation.Tags;

namespace Examine.Presentation.Controls
{
    public abstract class View : Tag, IBodyElement // BodyElement
    {
        public View(params IBodyElement[] content) : base("", content)
        {
        }

        public override void RenderTo(StringBuilder sb)
        {
            if (Content.Any())
            {
                foreach (var element in Content)
                {
                    element.RenderTo(sb);
                }
            }
        }
    }
}