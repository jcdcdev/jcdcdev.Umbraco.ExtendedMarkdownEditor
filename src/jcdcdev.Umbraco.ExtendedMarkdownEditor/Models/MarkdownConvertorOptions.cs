namespace jcdcdev.Umbraco.ExtendedMarkdownEditor.Models;

public class MarkdownConvertorOptions
{
    public int? HeaderOffset { get; init; }
    public bool ExternalLinksOpenInNewTab { get; init; }
    public bool TransformLinks => ExternalLinksOpenInNewTab;
}
