namespace Examine.Presentation.Tags
{
    public interface IBodyElement : IHtmlElement
    {
    }

    public abstract class BodyElement : Tag, IBodyElement
    {
        public BodyElement(string name, params IHtmlElement[] content) : base(name, content)
        {
        }

        public static implicit operator BodyElement(string value)
        {
            return new Literal(value);
        } 
    }
    
    public class Body : Tag
    {
        public Body(params IBodyElement[] content) : base("body", content)
        {
        }
    }

    public static partial class Fluent
    {
        public static Body Body(params IBodyElement[] content) => new Body(content);

        public static T Id<T>(this T element, string id) where T: BodyElement => element.Attr("id", id);
    }    
}