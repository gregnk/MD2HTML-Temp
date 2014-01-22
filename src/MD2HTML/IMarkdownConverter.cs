using MarkdownSharp;

namespace MD2HTML
{
    public interface IMarkdownConverter
    {
        IMarkdownOptions Options { get; }
        string Version { get; }
        string Transform(string text);
    }
}