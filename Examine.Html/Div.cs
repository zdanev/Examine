namespace Examine.Html
{
    public class Div : BodyElement
    {
        public Div(params IBodyElement[] content) : base("div", content)
        {
        }
    }

    public static partial class Fluent
    {
        public static Div Div(params BodyElement[] content) => new Div(content);
    }
}