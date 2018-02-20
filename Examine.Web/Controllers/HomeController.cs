using System;
using Microsoft.AspNetCore.Mvc;
using Examine.Core.Components;
using Examine.Presentation.Views;
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

            var app =  new ExamineWebApp(new TestView(test));

            return Content(app, "text/html");
        }

        [HttpPost, Route("/")]
        public IActionResult Submit()
        {
            var id = Request.Form["id"];
            var answers = Request.Form["answer"];

            var test = _arithmeticsTestComponent.ScoreTest(Guid.Parse(id), answers);

            var app = new ExamineWebApp(new TestScoreView(test));

            return Content(app, "text/html");
        }
    }
}
