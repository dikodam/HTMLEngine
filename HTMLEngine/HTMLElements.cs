namespace HTML
{
    abstract class HtmlElement : ITagged
    {
        public string TagId { get; }

        public HtmlElement(string tagId)
        {
            TagId = tagId;
        }

        public override string ToString()
        {
            return $"<{TagId}>\n";
        }
    }

    abstract class NestedHtmlElement : ITagged, INested
    {
        public string TagId { get; }
        public object[] Elements { get; }

        public NestedHtmlElement(string tagId, params object[] elements)
        {
            TagId = tagId;
            Elements = elements;
        }

        public override string ToString()
        {
            string html = $"<{TagId}>\n";
            foreach (object element in Elements)
            {
                html += element.ToString();
            }
            return $"{html}\n</{TagId}>";
        }
    }

    class DocumentType : HtmlElement
    {
        public DocumentType() : base("br/")
        {
        }
    }

    class Html : NestedHtmlElement
    {
        public Html(params object[] elements) : base("html", elements)
        {
        }
    }

    class Head : NestedHtmlElement
    {
        public Head(params object[] elements) : base("head", elements)
        {
        }
    }

    class Title : NestedHtmlElement
    {
        public Title(params object[] elements) : base("title", elements)
        {
        }
    }

    class Body : NestedHtmlElement
    {
        public Body(params object[] elements) : base("body", elements)
        {
        }
    }

    class Heading : NestedHtmlElement
    {
        public Heading(params object[] elements) : base("h1", elements)
        {
        }
    }

    class Paragraph : NestedHtmlElement
    {
        public Paragraph(params object[] elements) : base("p", elements)
        {
        }
    }

    class Italic : NestedHtmlElement
    {
        public Italic(params object[] elements) : base("i", elements)
        {
        }
    }

    class Bold : NestedHtmlElement
    {
        public Bold(params object[] elements) : base("b", elements)
        {
        }
    }

    class LineBreak : HtmlElement
    {
        public LineBreak() : base("br")
        {
        }
    }
}