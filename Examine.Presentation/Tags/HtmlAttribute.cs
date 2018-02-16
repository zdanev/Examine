namespace Examine.Presentation.Tags
{
    public class HtmlAttribute
    {
        public string Name { get; }

        public string Value { get; set; }

        public HtmlAttribute(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}