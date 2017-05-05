namespace HTML
{
    public abstract class HtmlElement : ITagged
    {
        public string TagId { get; }

        public HtmlElement(string tagId)
        {
            TagId = tagId;
        }

        public override string ToString()
        {
            return $"<{TagId}/>\n";
        }
    }

    public abstract class NestedHtmlElement : HtmlElement, INested
    {
        public object[] Elements { get; }

        public NestedHtmlElement(string tagId, object[] elements) : base(tagId)
        {
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

    class DocumentType
    {
        public override string ToString()
        {
            return "<!DOCTYPE html>";
        }
    }

    class Html : NestedHtmlElement
    {
        public Html(object[] elements) : base("html", elements)
        {
        }

    }

    class Head : NestedHtmlElement
    {
        public Head(object[] elements) : base("head", elements)
        {
        }
    }

    class Title : NestedHtmlElement
    {
        public Title(object[] elements) : base("title", elements)
        {
        }
    }

    class Body : NestedHtmlElement
    {
        public Body(object[] elements) : base("body", elements)
        {
        }
    }

    class Heading : NestedHtmlElement
    {
        public Heading(object[] elements) : base("h1", elements)
        {
        }
    }

    class Paragraph : NestedHtmlElement
    {
        public Paragraph(object[] elements) : base("p", elements)
        {
        }
    }

    class Italic : NestedHtmlElement
    {
        public Italic(object[] elements) : base("i", elements)
        {
        }
    }

    class Bold : NestedHtmlElement
    {
        public Bold(object[] elements) : base("b", elements)
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