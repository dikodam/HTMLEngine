using HTML;

class Program
{
    static void Main()
    {
        // Generate HTML document and store result in string:

        string html = Engine.Generate
        (
            new DocumentType(),
            new Html
            (
                new Head
                (
                    new Title("Generated HTML Example")
                ),
                new Body
                (
                    new Heading("Welcome to the Technical University Nuremberg"),
                    new Paragraph
                    (
                        "We have a ", new Italic("distinct profile"), " and strive to maintain our ",
                        new Italic("leading position"), " among comparable universities."
                    ),
                    new Heading("Study for your future"),
                    new Paragraph
                    (
                        12, " departments provide more than ", 40, " degree programs in ",
                        new Bold("engineering, business, design and social sciences."),
                        new LineBreak(),
                        "If you have questions, please contact the ", new Italic("Student Counseling Service"),
                        " or the ", new Italic("Student Office.")
                    )
                )
            )
        );

        // Write resulting HTML string:

        System.Console.WriteLine("GENERATED HTML DOCUMENT:");

        System.Console.WriteLine(html);

        System.Console.ReadKey(true);

        /*
          // Write reformatted HTML string:

          System.Console.WriteLine("\nREFORMATTED HTML DOCUMENT:");

          System.Console.WriteLine("\n<" + new DocumentType().TagId + ">\n" + System.Xml.Linq.XElement.Parse(html.Replace("\n", "")));

          System.Console.ReadKey(true);
        */

        // Show (original) HTML string in default browser:

        System.Console.WriteLine("\nSTARTING BROWSER WITH GENERATED DOCUMENT...");

        System.IO.File.WriteAllText("Example.html", html);

        System.Diagnostics.Process.Start("Example.html");
    }
}