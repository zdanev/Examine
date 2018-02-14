namespace Examine.Html.Tags
{
    public class Html : Tag
    {
        public Head Head { get; }

        public Body Body { get; }

        public Html(Head head, Body body) 
            : base ("html", head, body)
        {
            Head = head;
            Body = body;
        }
    }

    public static partial class Fluent
    {
        public static Html Html_(Head head, Body body)
        {
            return new Html(head, body);
        }
    }    
}