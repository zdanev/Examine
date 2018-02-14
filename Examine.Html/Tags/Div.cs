namespace Examine.Html.Tags
{
    public class Div : BodyElement
    {
        public Div(params IBodyElement[] content) : base("div", content)
        {
        }
    }

    public static partial class Fluent
    {
        public static Div Div(params IBodyElement[] content) => new Div(content);
    }
}