using static Examine.Html.Fluent;

namespace Examine.Html
{
    public class Title : Tag, IHeadElement
    {
        public string Value { get; }

        public Title(string title) : base("title", new Literal(title))
        {
            Value = title; 
        }
    }
    
    public static partial class Fluent
    {
        public static Title Title(string title) => new Title(title);
    }
}