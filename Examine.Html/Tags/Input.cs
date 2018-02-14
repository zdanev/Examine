namespace Examine.Html.Tags
{
    public enum InputType
    {
        Button,

        Text,

        // todo...
    }

    public class Input : BodyElement
    {
        public InputType Type { get; }

        public Input(InputType type, params BodyElement[] content) : base("input", content)
        {
            this.Type = type;

            this.Attr("type", type.ToString() /* .AsKebab() */);
        }
    }

    public static partial class Fluent
    {
        public static Input Input(InputType type, params BodyElement[] content) => new Input(type, content);
    }    
}