/* 
 * This file is part of md2html
 * (c) 2014 Alan Barber
 * (c) 2019 Gregory Karastergios
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 * This file has been modified from the original version
 */
using System.IO;
using System.Linq;
using MarkdownSharp;

namespace md2html
{
    class Program
    {
        public static void Main(string[] args)
        {
            if (args == null || args.Count() != 1)
            {
                PrintUsageInfo();
                return;
            }

            if (!File.Exists(args[0]))
                return;

            // Read in file contents
            string markdownData = File.ReadAllText(args[0]);

            // Load the markdown converter and convert to html
            IMarkdownConverter markdownConverter = new MarkdownConverter(new Markdown());
            markdownConverter.Options.AutoNewLines = true;
            string htmlData = markdownConverter.Transform(markdownData);
            
            htmlData = "<body style='font-family: Arial;'>\n" + htmlData + "</body>";

            // Write out file to html
            File.WriteAllText(args[0].Replace(".md", ".html"), htmlData);
        }
    }
}
