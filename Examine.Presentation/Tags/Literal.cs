using System;
using System.Collections.Generic;
using System.Text;

namespace Examine.Presentation.Tags
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

        public override string Render()
        {
            return Value;
        }

        public override void RenderTo(StringBuilder sb)
        {
            sb.Append(Value);
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