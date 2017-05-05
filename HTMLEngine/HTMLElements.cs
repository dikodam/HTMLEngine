namespace HTML
{
    class DocumentType
    {
        public override string ToString()
        {
            return "<!DOCTYPE html>";
        }
    }

    class Html : INested, ITagged
    {

        public string TagId { get; }

        public object[] Elements { get; }

        public Html()
        {
            TagId = "html";
        }

        public Html(params object[] elements) : base()
        {
            Elements = elements;
        }

        public override string ToString()
        {
            string html = "<" + TagId + ">";

            foreach (object element in Elements)
            {
                html += element.ToString();
            }

            return html + "</" + TagId + ">";
        }
    }
}