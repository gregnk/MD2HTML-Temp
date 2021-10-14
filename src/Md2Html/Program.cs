/* 
 * This file is part of Md2Html
 * (c) 2019 Gregory Karastergios
 * (c) 2014 Alan Barber
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
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using MarkdownSharp;

namespace Md2Html
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Usage info
            if (args == null || args.Count() < 1 || args[0] == "-Help" || args[0] == "-help")
            {
                PrintUsageInfo();
                return;
            }

            // About
            else if (args[0] == "-About" || args[0] == "-about")
            {
                PrintAboutScreen();
                return;
            }

            // File does not exist
            else if (!File.Exists(args[0]))
            {
                Console.WriteLine("ERROR : Specified file foes not exist ({0})", args[0]);
                return;
            }

            // Read in file contents
            string markdownData = File.ReadAllText(args[0]);

            // Load the markdown converter and convert to html
            IMarkdownConverter markdownConverter = new MarkdownConverter(new Markdown());

            // Arg based vars
            string header = null;
            string footer = null;
            string outFile = null;

            // Cycle through each command line arg
            for (int argIndex = 1; argIndex < args.Length; argIndex++)
            {
                switch (args[argIndex])
                {
                    case "-Header":
                    case "-header":
                        header = File.ReadAllText(args[argIndex + 1]);
                        break;
                    case "-Footer":
                    case "-footer":
                        footer = File.ReadAllText(args[argIndex + 1]);
                        break;
                    case "-AsteriskIntraWordEmphasis":
                    case "-asteriskIntraWordEmphasis":
                        markdownConverter.Options.AsteriskIntraWordEmphasis = true;
                        break;
                    case "-AutoNewLines":
                    case "-autoNewLines":
                        markdownConverter.Options.AutoNewLines = true;
                        break;
                    case "-AutoHyperlink":
                    case "-autoHyperlink":
                        markdownConverter.Options.AutoHyperlink = true;
                        break;
                    case "-CloseEmptyElements":
                    case "-closeEmptyElements":
                        markdownConverter.Options.EmptyElementSuffix = "/>";
                        break;
                    case "-DontLinkEmails":
                    case "-dontLinkEmails":
                        markdownConverter.Options.LinkEmails = false;
                        break;
                    case "-StrictBoldItalic":
                    case "-strictBoldItalic":
                        markdownConverter.Options.StrictBoldItalic = true;
                        break;
                    case "-OutFile":
                    case "-outFile":
                        outFile = args[argIndex + 1];
                        break;
                    default:
                        if (args[argIndex - 1] != "-Header" && args[argIndex - 1] != "-Footer" && args[argIndex - 1] != "-OutFile")
                            Console.WriteLine("ERROR: Invalid option ({0})", args[argIndex]);
                        break;
                }
            }

            string htmlData = markdownConverter.Transform(markdownData);

            // Add header and footer if specified
            if (header != null && footer != null)
                htmlData = header + "\n" + htmlData + "\n" + footer;
            else if (header != null && footer == null)
                htmlData = header + "\n" + htmlData;
            else if (header == null && footer != null)
                htmlData = htmlData + "\n" + footer;

            // Write out file to html
            if (outFile != null)
                File.WriteAllText(outFile, htmlData);
            else
                File.WriteAllText(args[0].Replace(".md", ".html"), htmlData);
        }

        private static void PrintUsageInfo()
        {
            Console.Write(Properties.Resources.Usage);
        }

        private static void PrintAboutScreen()
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            Console.Write(
                "Md2Html\n" +
                "v{0}.{1}.{2}\n\n" +
                "{3}", 
                version.Major, version.Minor, version.Revision, Properties.Resources.License);
        }
    }
}
