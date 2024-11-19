using jcdcdev.Umbraco.ExtendedMarkdownEditor.PropertyEditors;
using jcdcdev.Umbraco.ExtendedMarkdownEditor.Services;
using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.PropertyEditors.ValueConverters;
using Umbraco.Cms.Infrastructure.Manifest;

namespace jcdcdev.Umbraco.ExtendedMarkdownEditor.Composing;

public static class UmbracoBuilderExtensions
{
    public static IUmbracoBuilder AddMarkDown(this IUmbracoBuilder builder)
    {
        builder.Services.AddSingleton<IMarkdownService, MarkdownService>();
        builder.PropertyValueConverters().Replace<MarkdownEditorValueConverter, ExtendedMarkdownEditorValueConverter>();
        builder.DataEditors().Exclude<MarkdownPropertyEditor>();
        builder.Services.AddSingleton<IPackageManifestReader, PackageManifestReader>();
        return builder;
    }
}
