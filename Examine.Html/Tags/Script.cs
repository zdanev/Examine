namespace Examine.Html.Tags
{
    public interface IScriptElement : IHtmlElement
    {        
    }

    public class Script : Tag, IHeadElement, IBodyElement
    {
        public Script(params IScriptElement[] content) : base("script", content)
        {            
        }
    }

    public class ExtScript : Script
    {
        public string Src { get; }

        public ExtScript(string src)
        {
            DoNotCollapse = true;
            Src = src;

            this.Attr("src", src);
        }
    }

    public class ScriptElement : Literal, IScriptElement
    {
        public ScriptElement(string value) : base(value)
        {            
        }

        public override string ToString()
        {
            return Value;
        }

        public static implicit operator ScriptElement(string value)
        {
            return new ScriptElement(value);
        }
    }

    public static partial class Fluent
    {
        public static ExtScript ExtScript(string src) => new ExtScript(src);

        public static Script Script(params IScriptElement[] content) => new Script(content);
    }    
}