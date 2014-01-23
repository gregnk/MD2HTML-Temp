using System.IO;
using System.Linq;
using MarkdownSharp;

namespace MD2HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null || args.Count() != 1)
                return;

            if (!File.Exists(args[0]))
            {
                return;
            }

            // Read in file contents
            string markdownData = File.ReadAllText(args[0]);

            // load the markdown converter and tranform to html
            IMarkdownConverter markdownConverter = new MarkdownConverter(new Markdown());
            string htmlData = markdownConverter.Transform(markdownData);

            // write out file to html
            File.WriteAllText(args[0].ToLower().Replace(".md",".html"), htmlData);
        }
    }
}
