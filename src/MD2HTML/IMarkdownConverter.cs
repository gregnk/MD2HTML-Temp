 /* 
  * This file is part of MD2HTML
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
using MarkdownSharp;

namespace md2html
{
    public interface IMarkdownConverter
    {
        Markdown Options { get; }
        string Version { get; }
        string Transform(string text);
    }
}