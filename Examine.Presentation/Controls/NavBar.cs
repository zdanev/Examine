using Examine.Presentation.Tags;
using static Examine.Presentation.Tags.Fluent;

namespace Examine.Presentation.Controls
{
    public interface INavBarElement : IBodyElement
    {        
    }
    
    public class NavBar : BodyElement
    {
        public NavBar(params INavBarElement[] content) : base("nav", content)
        {
            this.Class("navbar"); 
            this.Class("navbar-toggleable-md"); 
            // this.AddClass("navbar-light"); 
            // this.AddClass("bg-faded");   
            this.Class("navbar-inverse");         
            this.Class("bg-inverse");            
        }
    }

    public class NavBarToggler : Tags.Button, INavBarElement
    {
        public NavBarToggler() : base(Tags.ButtonType.Button,  Span("").Class("navbar-toggler-icon"))
        {
            this.Class("navbar-toggler");
            this.Class("navbar-toggler-right");

            this.Attr("data-toggle", "collapse");
            this.Attr("data-target", "#navbarSupportedContent");
            this.Attr("aria-controls", "navbarSupportedContent");
            this.Attr("aria-expanded", "false");
            this.Attr("aria-label", "Toggle navigation");
        }
    }

    public class NavBarBrand : H1, INavBarElement
    {
        public NavBarBrand(string title) : base(title)
        {
            this.Class("navbar-brand");
            this.Class("mb-0");
        }
    }

    public class NavBarLinkBrand : Anchor, INavBarElement
    {
        public NavBarLinkBrand(string title, string href) : base(href, title)
        {
            this.Class("navbar-brand");
        }
    }

    public class NavBarItems : Div, INavBarElement
    {
        public NavBarItems(params NavBarItem[] items) : base(UL(items).Class("navbar-nav").Class("mr-auto"))
        {
            this.Class("collapse");
            this.Class("navbar-collapse");
            this.Id("navbarSupportedContent"); // todo: ...?!?            
        }
    }

    public class NavBarItem : ListItem
    {
        public NavBarItem(string title, string href, bool isActive = false)
            : base(Anchor(href, title).Class("nav-link"))
        {
            this.Class("nav-item");            

            if (isActive)
            {
                this.Class("active");
            }
        }
    }

    public static partial class Fluent
    {
        public static NavBar NavBar(params INavBarElement[] content)
        {
            return new NavBar(content);
        }

        public static NavBarToggler NavBarToggler()
        {
            return new NavBarToggler();
        }

        public static NavBarBrand NavBarBrand(string title)
        {
            return new NavBarBrand(title);
        }

        public static NavBarLinkBrand NavBarLinkBrand(string title, string href)
        {
            return new NavBarLinkBrand(title, href);
        }

        public static NavBarItems NavBarItems(params NavBarItem[] items)
        {
            return new NavBarItems(items);
        }
        
        public static NavBarItem NavBarItem(string title, string href, bool isActive = false)
        {
            return new NavBarItem(title, href, isActive);            
        }
    }
}