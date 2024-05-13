using jcdcdev.Umbraco.ExtendedMarkdownEditor.Models;
using jcdcdev.Umbraco.ExtendedMarkdownEditor.Services;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.PropertyEditors.ValueConverters;
using Umbraco.Cms.Core.Templates;

namespace jcdcdev.Umbraco.ExtendedMarkdownEditor.PropertyEditors;

public class ExtendedMarkdownEditorValueConverter : MarkdownEditorValueConverter
{
    private readonly IMarkdownService _markdownService;

    public ExtendedMarkdownEditorValueConverter(
        HtmlLocalLinkParser localLinkParser,
        HtmlUrlParser urlParser,
        IMarkdownService markdownService) : base(localLinkParser, urlParser)
    {
        _markdownService = markdownService;
    }

    public override Type GetPropertyValueType(IPublishedPropertyType propertyType) => typeof(MarkdownValue);

    public override object ConvertIntermediateToObject(IPublishedElement owner, IPublishedPropertyType propertyType, PropertyCacheLevel referenceCacheLevel, object? inter, bool preview)
    {
        if (inter is not string s)
        {
            return MarkdownValue.Empty;
        }

        var config = propertyType.DataType.ConfigurationAs<ExtendedMarkdownConfiguration>();
        var options = new MarkdownConvertorOptions
        {
            HeaderOffset = config?.HeaderOffset,
            ExternalLinksOpenInNewTab = config?.ExternalLinksOpenInNewTab ?? false
        };

        return _markdownService.CreateFromMarkdownString(s, options);
    }
}
