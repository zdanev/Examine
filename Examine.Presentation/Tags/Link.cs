namespace Examine.Presentation.Tags
{
    public enum LinkRel
    {
        Stylesheet,
        Icon
    }

    public enum LinkType 
    {
        Text_Css
    }

    public class Link : HeadElement
    {
        public LinkRel Rel { get; }

        public LinkType Type { get; }

        public string Href { get; }

        public Link(LinkRel rel, LinkType type, string href) : base("link")
        {
            Rel = rel;
            Type = type;
            Href = href;

            this.Attr("rel", rel.AsPath());
            this.Attr("type", type.AsPath());
            this.Attr("href", href);
        }
    }

    public static partial class Fluent
    {
        public static Link Link(LinkRel rel, LinkType type, string href) => new Link(rel, type, href);
    }    
}