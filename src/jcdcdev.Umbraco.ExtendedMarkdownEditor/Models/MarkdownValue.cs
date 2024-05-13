using System.Diagnostics.CodeAnalysis;
using Markdig.Syntax;
using Umbraco.Cms.Core.Strings;

namespace jcdcdev.Umbraco.ExtendedMarkdownEditor.Models;

public class MarkdownValue
{
    private MarkdownValue(string raw, MarkdownDocument? markdown, IHtmlEncodedString html)
    {
        Raw = raw;
        Html = html;
        Markdown = markdown;
    }

    private MarkdownValue()
    {
    }

    [MemberNotNullWhen(true, nameof(Markdown), nameof(Html), nameof(Raw))]
    public bool IsValid => Markdown != null && Html != null && !string.IsNullOrWhiteSpace(Raw);

    public MarkdownDocument? Markdown { get; }
    public string? Raw { get; }
    public IHtmlEncodedString? Html { get; }
    public static MarkdownValue Empty => new();
    public static MarkdownValue Create(string raw, MarkdownDocument markdown, IHtmlEncodedString html) => new(raw, markdown, html);
}
