using Umbraco.Cms.Core.PropertyEditors;

namespace jcdcdev.Umbraco.ExtendedMarkdownEditor.PropertyEditors;

public class ExtendedMarkdownConfiguration : MarkdownConfiguration
{
    [ConfigurationField("headerOffset", "Header Offset", "number", Description = "The offset to apply to any header tags")]
    public int? HeaderOffset { get; set; }

    [ConfigurationField("externalLinksOpenInNewTab", "External Links Open In New Tab", "boolean", Description = "Ensures external links open in a new tab")]
    public bool ExternalLinksOpenInNewTab { get; set; }
}
