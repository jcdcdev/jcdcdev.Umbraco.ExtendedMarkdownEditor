using jcdcdev.Umbraco.ExtendedMarkdownEditor.Models;
using jcdcdev.Umbraco.ExtendedMarkdownEditor.Services;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.PropertyEditors.ValueConverters;
using Umbraco.Cms.Core.Strings;
using Umbraco.Cms.Core.Templates;

namespace jcdcdev.Umbraco.ExtendedMarkdownEditor.PropertyEditors;

public class ExtendedMarkdownEditorValueConverter(
    HtmlLocalLinkParser localLinkParser,
    HtmlUrlParser urlParser,
    IMarkdownService markdownService,
    IMarkdownToHtmlConverter markdownToHtmlConverter
) : MarkdownEditorValueConverter(localLinkParser, urlParser, markdownToHtmlConverter)
{
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
            HeaderOffset = config?.GetHeaderOffset(),
            ExternalLinksOpenInNewTab = config?.ExternalLinksOpenInNewTab ?? false
        };

        return markdownService.CreateFromMarkdownString(s, options);
    }
}
