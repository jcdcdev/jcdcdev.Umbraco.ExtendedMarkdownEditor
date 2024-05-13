using jcdcdev.Umbraco.ExtendedMarkdownEditor.Models;

namespace jcdcdev.Umbraco.ExtendedMarkdownEditor.Services;

public interface IMarkdownService
{
    MarkdownValue CreateFromMarkdownString(string markdown, MarkdownConvertorOptions? config = null);
}
