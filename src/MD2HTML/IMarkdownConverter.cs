using MarkdownSharp;

namespace MD2HTML
{
    public interface IMarkdownConverter
    {
        Markdown Options { get; }
        string Version { get; }
        string Transform(string text);
    }
}