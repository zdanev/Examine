using static Examine.Html.Tags.Fluent;

namespace Examine.Html.Tags
{
    public class Anchor : BodyElement
    {
        public string Href { get; }

        public Anchor(string href, params BodyElement[] content) : base("a", content)
        {
            Href = href;

            this.Attr("href", href);
        }
    }

    public static partial class Fluent
    {
        public static Anchor Anchor(string href, string text) => new Anchor(href, text);
    }    
}