Md2Html
=======

A simple console application that converts Markdown files to HTML

This repository is a fork of [AlanBarber/MD2HTML](https://github.com/AlanBarber/MD2HTML)

Usage
-----

Md2Html.exe <File>.md <Options>

### Options

    -Header   <File>				Adds a header from the file specified`
    -Footer <File>					Adds a footer from the file specified
    -AsteriskIntraWordEmphasis		Allows asterisks to be used for intraword emphasis
    -AutoNewLines					Converts RETURN into a literal newline *
    -AutoHyperlink					Converts most bare plain URLs into hyperlinks *
    -CloseEmptyElements				Uses '/>' instead of '>' to close empty HTML elements for XHTML
    -LinkEmails						Will Mever convert emails into hyperlinks *
    -StrictBoldItalic				Requires non-word characters on either side of bold and italic text *
    -OutFile <File>					Will output the HTML to the specified file
    -Help							Displays the help screen

    * Denotes an option that is a significant deviation from the markdown spec

Copyright
-----

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