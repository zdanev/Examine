namespace Examine.Presentation.Tags
{
    public static class Formatters
    {
        // example: this-is-kebab-case
        public static string AsKebab(this object o)
        {
            return o.ToString().ToLower().Replace("_", "-");
        }

        // example: this/is/a/path
        public static string AsPath(this object o)
        {
            return o.ToString().ToLower().Replace("_", "/");
        }
    }
}