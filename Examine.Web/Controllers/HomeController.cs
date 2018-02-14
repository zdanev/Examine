using System;
using Examine.Core.Components;
using Examine.Html.Renderers;
using Microsoft.AspNetCore.Mvc;
using static Examine.Html.Tags.Fluent;

namespace Examine.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly TestComponent _testComponent;

        public HomeController(TestComponent testComponent)
        {
            _testComponent = testComponent;
        }

        public IActionResult Index()
        {
            var testId = Guid.NewGuid();
            var test = _testComponent.GetTest(testId);

            var html = HtmlPage(
                Html_(
                    Head(),
                    Body(
                        test.Render()
                    )
                )
            );

            return Content(html.Render(), "text/html");
        }
    }
}
