using Microsoft.AspNetCore.Mvc;
using static Examine.Html.Fluent;

namespace Examine.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var html = HtmlPage(
                Html_(
                    Head(),
                    Body(
                        H1("Examine"),
                        H3("hello world")
                    )
                )
            );

            return Content(html.Render(), "text/html");
        }
    }
}
