namespace Examine.Html
{
    public abstract class Heading : Tag, IBodyElement
    {
        public int Level { get; }

        public Heading(int level, params IBodyElement[] content) : base("h" + level, content)
        {
            Level = level;
        }
    }

    public class H1 : Heading
    {
        public H1(params BodyElement[] content) : base(1, content)
        {
        }
    }

    public class H2 : Heading
    {
        public H2(params BodyElement[] content) : base(2, content)
        {
        }
    }

    public class H3 : Heading
    {
        public H3(params BodyElement[] content) : base(3, content)
        {
        }
    }

    public class H4 : Heading
    {
        public H4(params BodyElement[] content) : base(4, content)
        {
        }
    }

    public class H5 : Heading
    {
        public H5(params BodyElement[] content) : base(5, content)
        {
        }
    }

    public class H6 : Heading
    {
        public H6(params BodyElement[] content) : base(6, content)
        {
        }
    }

    public static partial class Fluent
    {
        public static H1 H1(params BodyElement[] content) =>  new H1(content);

        public static H2 H2(params BodyElement[] content) => new H2(content);

        public static H3 H3(params BodyElement[] content) => new H3(content);

        public static H4 H4(params BodyElement[] content) => new H4(content);

        public static H5 H5(params BodyElement[] content) => new H5(content);

        public static H6 H6(params BodyElement[] content) => new H6(content);
    }
}