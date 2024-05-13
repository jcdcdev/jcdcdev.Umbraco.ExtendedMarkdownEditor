using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.Services;

namespace jcdcdev.Umbraco.ExtendedMarkdownEditor.PropertyEditors;

// Or should it be: ExtendedMarkdownConfigurationConfigurationEditor? :D
internal class ExtendedMarkdownConfigurationEditor : ConfigurationEditor<ExtendedMarkdownConfiguration>
{
    public ExtendedMarkdownConfigurationEditor(IIOHelper ioHelper, IEditorConfigurationParser editorConfigurationParser) : base(ioHelper, editorConfigurationParser)
    {
    }
}
