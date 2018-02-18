using Examine.Presentation.Tags;

namespace Examine.Presentation.Controls
{
    public abstract class View : BodyElement
    {
        public View(params IBodyElement[] content) : base("div", content)
        {
        }
    }
}