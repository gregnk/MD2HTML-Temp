using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Emit;
using Ninject;

namespace MD2HTML
{
    class Program
    {
        static void Main(string[] args)
        {

            // parse options

            // load the markdown converter
            IMarkdownConverter markdownConverter = GetMarkdownConverter();
            


#if DEBUG
            Console.Write("Press any key to continue...");
            Console.ReadKey();
#endif
        }

        private static void ParseArgs(string[] args)
        {
            return;
        }

        private static IMarkdownConverter GetMarkdownConverter()
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IMarkdownConverter>().To<MarkdownConverter>();
            return kernel.Get<IMarkdownConverter>();
        }

        private static void ProcessFiles(IMarkdownConverter markdownConverter, IEnumerable<string> files)
        {
            foreach (var file in files)
            {
                // read in .md file
                String data = File.ReadAllLines(file).ToString();
                // convert
                var md = markdownConverter.Transform(data);
                // write out .html file
                File.WriteAllText(file, md);
            }
        }
    }
}
