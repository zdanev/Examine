namespace Examine.Presentation.Tags
{
    public enum ButtonType
    {
        Button,
        Submit
    }

    public class Button : BodyElement
    {
        public ButtonType Type { get; }

        public Button(ButtonType type, params BodyElement[] content) : base("button", content)
        {
            this.Attr("type", type.ToString());
        }
    }

    public static partial class Fluent
    {
        public static Button Button(params BodyElement[] content) => new Button(ButtonType.Button, content);
        
        public static Button SubmitButton(params BodyElement[] content) => new Button(ButtonType.Submit, content);

        public static Button OnClick(this Button button, ScriptElement onclick) => button.Attr("onclick", onclick.ToString());
    }    
}