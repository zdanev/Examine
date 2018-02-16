using System;
using System.Collections.Generic;
using System.Text;

namespace Examine.Presentation.Tags
{
    public interface IHtmlElement
    {
        string Name { get; }

        List<HtmlAttribute> Attributes { get; }

        List<IHtmlElement> Content { get; }

        string Render(StringBuilder sb = null);
    }
}
