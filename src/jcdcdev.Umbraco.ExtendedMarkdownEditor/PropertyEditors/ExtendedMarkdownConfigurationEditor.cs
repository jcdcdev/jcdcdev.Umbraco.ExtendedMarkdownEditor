using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;

namespace jcdcdev.Umbraco.ExtendedMarkdownEditor.PropertyEditors;

// Or should it be: ExtendedMarkdownConfigurationConfigurationEditor? :D
internal class ExtendedMarkdownConfigurationEditor : ConfigurationEditor<ExtendedMarkdownConfiguration>
{
    public ExtendedMarkdownConfigurationEditor(IIOHelper ioHelper) : base(ioHelper)
    {
    }
}
