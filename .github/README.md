# Extended Markdown Editor

[![Documentation](https://jcdc.dev/badge/Documentation/primary/book)](https://docs.jcdc.dev/jcdcdev-umbraco-extendedmarkdowneditor/latest)
[![Umbraco Marketplace](https://jcdc.dev/badge/Umbraco%20Marketplace/umbraco/umbraco)](https://marketplace.umbraco.com/package/jcdcdev.Umbraco.ExtendedMarkdownEditor)
[![GitHub](https://jcdc.dev/badge/GitHub/github/github)](https://github.com/jcdcdev/jcdcdev.Umbraco.ExtendedMarkdownEditor)
[![NuGet package downloads](https://jcdc.dev/badge/nuget/jcdcdev.Umbraco.ExtendedMarkdownEditor)](https://www.nuget.org/packages/jcdcdev.Umbraco.ExtendedMarkdownEditor)
[![Project Website](https://jcdc.dev/badge/Project%20Website/primary/laptop)](https://jcdc.dev/umbraco-packages/extended-markdown-editor)


A lightweight custom property editor for Umbraco that sits on top of the default Umbraco.MarkdownEditor.

### Plug and Play

All existing and future properties using Umbraco.MarkdownEditor will automatically use the new editor.

Removing this package will revert to the default Umbraco.MarkdownEditor, **no data loss will occur**.

### Data Type

Extends the configuration to allow control over the transformation of Markdown to HTML

- **Header Offset** - The offset to apply to the header levels
    - For example: `-1` would transform `# Header 1` to `<h2>Header 1</h2>`
- **External Links** Open In New Tab - Adds `target="_blank"` to external links

### Property Value Converter

Replaces `IHtmlEncodedString` with `MarkdownValue` which contains the following properties

- **Raw** - The raw markdown as a string
- **Html** - The transformed HTML value
- **Markdown** - The Markdig MarkdownDocument

> [!IMPORTANT]
> Version 13 will only receive security updates and no new features.

> Please review the [security policy](https://github.com/jcdcdev/jcdcdev.Umbraco.ExtendedMarkdownEditor?tab=security-ov-file#supported-versions) for more information.

## Installation

### Install Package

```powershell
dotnet add package jcdcdev.Umbraco.ExtendedMarkdownEditor
```

## Security

> [!NOTE]
> This project takes security and support seriously.
> Please visit the [Security](https://github.com/jcdcdev/jcdcdev.Umbraco.ExtendedMarkdownEditor?tab=security-ov-file) page for more information.



## Contributing

Contributions to this package are most welcome! Please visit the [Contributing](https://github.com/jcdcdev/jcdcdev.Umbraco.ExtendedMarkdownEditor/contribute) page.

## Acknowledgements

Thank you to the following projects and individuals for their contributions. High five, you rock! 🤘🦄

- LottePitcher - [opinionated-package-starter](https://github.com/LottePitcher/opinionated-package-starter)



