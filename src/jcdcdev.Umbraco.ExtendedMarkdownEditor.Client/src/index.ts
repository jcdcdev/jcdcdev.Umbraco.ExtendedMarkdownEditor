import { UmbEntryPointOnInit } from "@umbraco-cms/backoffice/extension-api";
import { ManifestPropertyEditorUi } from "@umbraco-cms/backoffice/property-editor";

export const onInit: UmbEntryPointOnInit = (_host, extensionRegistry) => {
    const alias = 'Umb.PropertyEditorUi.MarkdownEditor';
    extensionRegistry.byAlias(alias).subscribe((ext) => {
        if (!ext) {
            return
        }
        const manifestPropertyEditorUi = ext as ManifestPropertyEditorUi;
        manifestPropertyEditorUi.meta.settings?.properties.push(
            {
                alias: "headerOffset",
                label: "Header Offset",
                propertyEditorUiAlias: "Umb.PropertyEditorUi.Slider",
                config: [
                    {
                        alias: "minVal",
                        value: -6
                    },
                    {
                        alias: "maxVal",
                        value: 6
                    },
                    {
                        alias: "initVal1",
                        value: 0
                    },
                    {
                        alias: "step",
                        value: 1
                    }
                ]
            });

        manifestPropertyEditorUi.meta.settings?.properties.push(
            {
                alias: "externalLinksOpenInNewTab",
                label: "External Links Open in New Tab",
                propertyEditorUiAlias: "Umb.PropertyEditorUi.Toggle"
            });

    });
};

