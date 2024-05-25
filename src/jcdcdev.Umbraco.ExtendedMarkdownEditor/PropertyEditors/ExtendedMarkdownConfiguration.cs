using Umbraco.Cms.Core.PropertyEditors;

namespace jcdcdev.Umbraco.ExtendedMarkdownEditor.PropertyEditors;

public class ExtendedMarkdownConfiguration
{
    [ConfigurationField("headerOffset")]
    public int? HeaderOffset { get; set; }

    [ConfigurationField("externalLinksOpenInNewTab")]
    public bool ExternalLinksOpenInNewTab { get; set; }
}
