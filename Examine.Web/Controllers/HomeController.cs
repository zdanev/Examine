using System;
using Examine.Core.Components;
using Examine.Html.Renderers;
using Microsoft.AspNetCore.Mvc;
using static Examine.Html.Tags.Fluent;

namespace Examine.Web.Controllers
{
    public class HomeController : Controller
    {
        // private readonly TestComponent _testComponent;
        private readonly ArithmeticsTestComponent _arithmeticsTestComponent;

        public HomeController(
            // TestComponent testComponent,
            ArithmeticsTestComponent arithmeticsTestComponent)
        {
            //_testComponent = testComponent;
            _arithmeticsTestComponent = arithmeticsTestComponent;
        }

        public IActionResult Index()
        {
            // var testId = Guid.NewGuid();
            // var test = _testComponent.GetTest(testId);
            var test = _arithmeticsTestComponent.GenerateTest(5);

            var html = HtmlPage(
                Html_(
                    Head(),
                    Body(
                        TestRenderer.Render(test)
                    )
                )
            );

            return Content(html.Render(), "text/html");
        }

        [HttpPost, Route("/")]
        public IActionResult Submit()
        {
            var id = Request.Form["id"];
            var answers = Request.Form["answer"];

            var test = _arithmeticsTestComponent.ScoreTest(Guid.Parse(id), answers);

            var html = HtmlPage(
                Html_(
                    Head(),
                    Body(
                        TestRenderer.RenderScore(test)
                    )
                )
            );

            return Content(html.Render(), "text/html");
        }
    }
}
