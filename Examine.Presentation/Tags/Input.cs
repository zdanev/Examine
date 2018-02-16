namespace Examine.Presentation.Tags
{
    public enum InputType
    {
        Button,

        Text,

        Hidden

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

        public static Input Hidden(string name, string value) => new Input(InputType.Hidden)
            .Attr("name", name)
            .Attr("value", value);
    }    
}