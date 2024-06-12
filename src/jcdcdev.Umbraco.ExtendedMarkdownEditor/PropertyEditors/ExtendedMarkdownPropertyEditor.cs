using Umbraco.Cms.Core;
using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;

namespace jcdcdev.Umbraco.ExtendedMarkdownEditor.PropertyEditors;

[DataEditor(
    Constants.PropertyEditors.Aliases.MarkdownEditor,
    ValueType = ValueTypes.Text,
    ValueEditorIsReusable = true)]
public class ExtendedMarkdownPropertyEditor : MarkdownPropertyEditor
{
    private readonly IIOHelper _ioHelper;

    protected override IConfigurationEditor CreateConfigurationEditor()
    {
        var config = new ExtendedMarkdownConfigurationEditor(_ioHelper);
        return config;
    }

    public ExtendedMarkdownPropertyEditor(IDataValueEditorFactory dataValueEditorFactory, IIOHelper ioHelper) : base(dataValueEditorFactory)
    {
        _ioHelper = ioHelper;
    }
}
