using Examine.Presentation.Controls;
using static Examine.Presentation.Controls.Fluent;

namespace Examine.Presentation.Views
{
    public class ExamineWebApp : WebApp
    {
        const string AppTitle = "Examine";

        public ExamineWebApp(View view) : base(AppTitle, view)
        {
            this.Html.Body.Content.Insert(0, new NavBar(
                NavBarToggler(),
                NavBarLinkBrand(AppTitle, "#"),
                NavBarItems(
                    NavBarItem("Item 1", "#", true),
                    NavBarItem("Item 2", "#"),
                    NavBarItem("Item 3", "#")
                )
            ));

            // todo: header / footer
        }
    }
}