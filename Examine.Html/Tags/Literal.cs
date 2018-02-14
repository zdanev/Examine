using System;
using System.Collections.Generic;
using System.Text;

namespace Examine.Html.Tags
{
    public class Literal : BodyElement
    {
        public string Value { get; }

        private Literal() : base(null)
        {
        }

        public Literal(string value) : this()
        {
            Value = value;
        }

        public override string Render(StringBuilder sb = null)
        {
            var returnResult = sb == null;

            sb = sb ?? new StringBuilder();

            sb.Append(Value);

            return returnResult ? sb.ToString() : null;
        }

        public static implicit operator Literal(string value)
        {
            return new Literal(value);
        }
    }

    public static partial class Fluent
    {
        public static Literal Literal(string content)
        {
            return new Literal(content);
        }
    } 
}