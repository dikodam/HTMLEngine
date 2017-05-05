using System.Text;

namespace HTML
{
    public interface ITagged
    {
        string TagId { get; }
    }

    public interface INested
    {
        object[] Elements { get; }
    }

    public static class Engine
    {
        public static string Generate(params object[] elements)
        {
            string html = "";
            foreach (object element in elements)
            {
                html += element.ToString();
            }
            return html;
        }
    }
}