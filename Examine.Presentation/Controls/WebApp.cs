using Examine.Presentation.Tags;
using static Examine.Presentation.Tags.Fluent;

namespace Examine.Presentation.Controls
{
    public class WebApp : HtmlPage
    {
        public string Title { get; }

        public WebApp(string title, params IBodyElement[] content) : base(
            Html(
                Head(
                    Title(title)
                ),
                Body(content)
            )
        )
        {
            Title = title;
        }
    }

    public static partial class Fluent
    {
        public static WebApp WebApp(string title, params IBodyElement[] content) => new WebApp(title, content);
    }
}