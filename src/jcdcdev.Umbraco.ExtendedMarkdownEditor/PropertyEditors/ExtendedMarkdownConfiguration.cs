using System.Text.Json.Serialization;
using Umbraco.Cms.Core.PropertyEditors;

namespace jcdcdev.Umbraco.ExtendedMarkdownEditor.PropertyEditors;

public class ExtendedMarkdownConfiguration
{
    [ConfigurationField("headerOffset")]
    [JsonPropertyName("headerOffset")]
    public SliderValue? HeaderOffsetValue { get; set; }

    public int? GetHeaderOffset() => HeaderOffsetValue?.From;

    [ConfigurationField("externalLinksOpenInNewTab")]
    public bool ExternalLinksOpenInNewTab { get; set; }
}

public class SliderValue
{
    [JsonPropertyName("from")]
    public int From { get; set; }
    
    [JsonPropertyName("to")]
    public int To { get; set; }
}
