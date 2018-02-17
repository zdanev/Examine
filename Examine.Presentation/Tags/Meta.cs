namespace Examine.Presentation.Tags
{
    public class Meta : HeadElement
    {
        public Meta(string name, string value) : base("meta")
        {
            this.Attr(name, value);
        }
    }

    public static partial class Fluent
    {
        public static Meta Meta(string name, string value) => new Meta(name, value);
    }    
}