namespace Examine.Presentation.Tags
{
    public class UnorderedList : BodyElement
    {
        public UnorderedList(params ListItem[] items) : base("ul", items)
        {
        }
    }

    public class OrderedList : BodyElement
    {
        public OrderedList(params ListItem[] items) : base("ol", items)
        {            
        }
    }

    public class ListItem : BodyElement
    {
        public ListItem(params BodyElement[] content) : base("li", content)
        {            
        }
    }

    public static partial class Fluent
    {
        public static UnorderedList UL(params ListItem[] items) => new UnorderedList(items);

        public static OrderedList OL(params ListItem[] items) => new OrderedList(items);

        public static ListItem LI(params BodyElement[] content) => new ListItem(content);
    }
}