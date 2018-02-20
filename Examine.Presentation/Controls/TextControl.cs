using Examine.Presentation.Tags;
using static Examine.Presentation.Tags.Fluent;

namespace Examine.Presentation.Controls
{
    public class TextControl : BodyElement
    {
        public string Id { get; set; }

        public string Label { get; set; }

        public TextControl(string id, string name, string label) : base("div")
        {
            Id = id;
            Label = label;

            this.Class("form-group");
            this.Content.Add(Label(label).Attr("label-for", id));
            this.Content.Add(Input(InputType.Text).Id(id).Attr("name", name).Class("form-control"));
        }
    }

    public static partial class Fluent
    {
        public static TextControl TextControl(string id, string label) => new TextControl(id, id, label);

        public static TextControl TextControl(string id, string name, string label) => new TextControl(id, name, label);
    }
}