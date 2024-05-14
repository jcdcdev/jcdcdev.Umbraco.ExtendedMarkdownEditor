using System.Diagnostics.CodeAnalysis;
using Markdig;
using Markdig.Syntax;

namespace jcdcdev.Umbraco.ExtendedMarkdownEditor.Extensions;

internal static class MarkdownExtensions
{
    public static bool TryParse(string markdown, [NotNullWhen(true)] out MarkdownDocument? document)
    {
        try
        {
            document = Markdown.Parse(markdown);
            return true;
        }
        catch
        {
            document = null;
            return false;
        }
    }
}
