using Examine.Presentation.Tags;

namespace Examine.Presentation.Controls
{
    public interface IDropdownElement : IBodyElement
    {
    }

    public class Dropdown : Div
    {
        public Dropdown(params IDropdownElement[] content) : base(content)
        {
            this.Class("dropdown");
        }
    }

    public interface IDropdownMenuElement : IBodyElement
    {
    }

    public class DropdownMenu : Div, IDropdownElement
    {
        public DropdownMenu(params IDropdownMenuElement[] content) : base(content)
        {
            this.Class("dropdown-menu");
        }
    }

    public class DropdownItem : Anchor, IDropdownMenuElement
    {
        public DropdownItem(string href, params BodyElement[] content) : base(href, content)
        {
            this.Class("dropdown-item");
        }
    }

    public class DropdownDivider : Div, IDropdownMenuElement
    {
        public DropdownDivider()
        {
            this.Class("dropdown-divider");   
        }
    }

    public class DropdownHeader : H6, IDropdownMenuElement
    {
        public DropdownHeader(params BodyElement[] content) : base(content)
        {
            this.Class("dropdown-header");
        }
    }

    public static partial class Fluent
    {
        public static Dropdown Dropdown(params IDropdownElement[] content)
        {
            return new Dropdown(content);
        }

        public static DropdownMenu DropdownMenu(params IDropdownMenuElement[] content)
        {
            return new DropdownMenu(content);
        }

        public static DropdownItem DropdownItem(string href, params BodyElement[] content)
        {
            return new DropdownItem(href, content);
        }

        public static DropdownDivider DropdownDivider()
        {
            return new DropdownDivider();
        }

        public static DropdownHeader DropdownHeader(params BodyElement[] content)
        {
            return new DropdownHeader(content);
        }
    }
}