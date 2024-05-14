using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Web.Common.DependencyInjection;

namespace jcdcdev.Umbraco.ExtendedMarkdownEditor.PropertyEditors;

[DataEditor(
    Constants.PropertyEditors.Aliases.MarkdownEditor,
    "Markdown editor",
    "markdowneditor",
    ValueType = ValueTypes.Text,
    Group = Constants.PropertyEditors.Groups.RichContent,
    Icon = "icon-code",
    ValueEditorIsReusable = true)]
public class ExtendedMarkdownPropertyEditor : MarkdownPropertyEditor
{
    private readonly IEditorConfigurationParser _editorConfigurationParser;

    private readonly IIOHelper _ioHelper;

    [Obsolete("Please use constructor that takes an IEditorConfigurationParser instead")]
    public ExtendedMarkdownPropertyEditor(IDataValueEditorFactory dataValueEditorFactory, IIOHelper ioHelper) : base(dataValueEditorFactory, ioHelper)
    {
        _ioHelper = ioHelper;
        _editorConfigurationParser = StaticServiceProvider.Instance.GetRequiredService<IEditorConfigurationParser>();
    }

    public ExtendedMarkdownPropertyEditor(IDataValueEditorFactory dataValueEditorFactory, IIOHelper ioHelper, IEditorConfigurationParser editorConfigurationParser) : base(dataValueEditorFactory,
        ioHelper,
        editorConfigurationParser)
    {
        _ioHelper = ioHelper;
        _editorConfigurationParser = editorConfigurationParser;
    }

    protected override IConfigurationEditor CreateConfigurationEditor()
    {
        var config = new ExtendedMarkdownConfigurationEditor(_ioHelper, _editorConfigurationParser);
        return config;
    }
}
