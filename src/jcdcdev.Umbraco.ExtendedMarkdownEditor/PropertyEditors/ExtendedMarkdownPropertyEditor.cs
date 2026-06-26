using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;

namespace jcdcdev.Umbraco.ExtendedMarkdownEditor.PropertyEditors;

[DataEditor(
    global::Umbraco.Cms.Core.Constants.PropertyEditors.Aliases.MarkdownEditor,
    ValueType = ValueTypes.Text,
    ValueEditorIsReusable = true)]
public class ExtendedMarkdownPropertyEditor(IDataValueEditorFactory dataValueEditorFactory, IIOHelper ioHelper) : MarkdownPropertyEditor(dataValueEditorFactory)
{
    protected override IConfigurationEditor CreateConfigurationEditor()
    {
        var config = new ExtendedMarkdownConfigurationEditor(ioHelper);
        return config;
    }
}
