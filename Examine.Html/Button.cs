namespace Examine.Html
{
    public class Button : BodyElement
    {
        public Button(params BodyElement[] content) : base("button", content)
        {
            this.Attr("type", "button");
        }
    }

    public static partial class Fluent
    {
        public static Button Button(params BodyElement[] content) => new Button(content);

        public static Button OnClick(this Button button, ScriptElement onclick) => button.Attr("onclick", onclick.ToString());
    }    
}