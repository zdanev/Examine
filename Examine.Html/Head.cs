namespace Examine.Html
{
    public interface IHeadElement : IHtmlElement
    {
    }

    public abstract class HeadElement : Tag, IHeadElement
    {
        public HeadElement(string name, params IHtmlElement[] content) : base(name, content)
        {
        }
    }

    public class Head : Tag
    {
        public Head(params IHeadElement[] content) : base("head", content)
        {
        }
    }

    public static partial class Fluent
    {
        public static Head Head(params IHeadElement[] content)
        {
            return new Head(content);
        }
    }    
}