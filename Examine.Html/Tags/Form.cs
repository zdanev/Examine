namespace Examine.Html.Tags
{
    public enum FormMethod
    {
        Put,
        Post,
        Delete
    }

    public class Form : BodyElement
    {
        public FormMethod Method { get; }

        public Form(FormMethod method, params IBodyElement[] content) : base("form", content)
        {
            Method = method;

            this.Attr("method", method.ToString());
        }
    }

    public static partial class Fluent
    {
        public static Form Form(FormMethod method, params IBodyElement[] content) => new Form(method, content);
    }
}