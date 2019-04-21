# Md2Html

A simple console application that converts Markdown files to HTML

This repository is a fork of [AlanBarber/MD2HTML](https://github.com/AlanBarber/MD2HTML)

## Usage

    Md2Html.exe <File>.md <Options>

### Options

    -Header <File>              Adds a header from the file specified
    -Footer <File>              Adds a footer from the file specified
    -AsteriskIntraWordEmphasis  Allows asterisks to be used for intraword emphasis
    -AutoNewLines               Converts RETURN into a literal newline *
    -AutoHyperlink              Converts most bare plain URLs into hyperlinks *
    -CloseEmptyElements         Uses '/>' instead of '>' to close empty HTML elements for XHTML
    -DontLinkEmails             Will never convert emails into hyperlinks *
    -StrictBoldItalic           Requires non-word characters on either side of bold and italic text *
    -OutFile <File>             Will output the HTML to the specified file
    -Help                       Displays the help screen

    * Denotes an option that is a significant deviation from the markdown spec

## Copyright

(c) 2019 Gregory Karastergios

(c) 2014 Alan Barber

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.

### 3rd Party Licenses

#### MarkdownSharp
[https://github.com/StackExchange/MarkdownSharp/](https://github.com/StackExchange/MarkdownSharp/)

(c) 2018 Stack Exchange

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.