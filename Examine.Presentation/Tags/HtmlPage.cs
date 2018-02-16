namespace Examine.Presentation.Tags
{
    public class HtmlPage : Tag
    {
        public Html Html { get; }

        public HtmlPage(Html html) : base("!DOCTYPE html", html)
        {
            Html = html;
            DoNotClose = true;
        }
    }

    public static partial class Fluent
    {
        public static HtmlPage HtmlPage(Html html)
        {
            return new HtmlPage(html);
        }
    }    
}