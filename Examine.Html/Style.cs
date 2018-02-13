using static Examine.Html.Fluent;

namespace Examine.Html
{
    public class Style : HeadElement
    {
        public Style(string inlineStyle) : base("style", Literal(inlineStyle))
        {            
        }
    }

    public static partial class Fluent
    {
        public static Style Style(string inlineStyle) => new Style(inlineStyle);
    }
}