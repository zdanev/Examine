using System;
using Examine.Core.Components;
using Examine.Presentation.Renderers;
using Microsoft.AspNetCore.Mvc;
using static Examine.Presentation.Controls.Fluent;

namespace Examine.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ArithmeticsTestComponent _arithmeticsTestComponent;

        public HomeController(
            ArithmeticsTestComponent arithmeticsTestComponent)
        {
            _arithmeticsTestComponent = arithmeticsTestComponent;
        }

        public IActionResult Index()
        {
            var test = _arithmeticsTestComponent.GenerateTest(5);

            var html = WebApp("Examine", TestRenderer.Render(test));

            return Content(html.Render(), "text/html");
        }

        [HttpPost, Route("/")]
        public IActionResult Submit()
        {
            var id = Request.Form["id"];
            var answers = Request.Form["answer"];

            var test = _arithmeticsTestComponent.ScoreTest(Guid.Parse(id), answers);

            var html = WebApp("Examine", TestRenderer.RenderScore(test));

            return Content(html.Render(), "text/html");
        }
    }
}
