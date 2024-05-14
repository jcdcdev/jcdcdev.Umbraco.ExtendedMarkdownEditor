# jcdcdev.Umbraco.ExtendedMarkdownEditor

[![Umbraco Version](https://img.shields.io/badge/Umbraco-10.4+-%233544B1?style=flat&logo=umbraco)](https://umbraco.com/products/umbraco-cms/)
[![NuGet](https://img.shields.io/nuget/vpre/jcdcdev.Umbraco.ExtendedMarkdownEditor?color=0273B3)](https://www.nuget.org/packages/jcdcdev.Umbraco.ExtendedMarkdownEditor)
[![GitHub license](https://img.shields.io/github/license/jcdcdev/jcdcdev.Umbraco.ExtendedMarkdownEditor?color=8AB803)](https://github.com/jcdcdev/jcdcdev.Umbraco.ExtendedMarkdownEditor/blob/main/LICENSE)
[![Downloads](https://img.shields.io/nuget/dt/jcdcdev.Umbraco.ExtendedMarkdownEditor?color=cc9900)](https://www.nuget.org/packages/jcdcdev.Umbraco.ExtendedMarkdownEditor/)

A lightweight custom property editor for Umbraco that sits on top of the default Umbraco.MarkdownEditor.

## Features

### Property Value Converter

Replaces `IHtmlEncodedString` with `MarkdownValue` which contains the following properties

- **Raw** - The raw markdown as a string
- **Html** - The transformed HTML value
- **Markdown** - The Markdig MarkdownDocument

### Data Type

Extends the configuration to allow control over the transformation of Markdown to HTML

- **Header Offset** - The offset to apply to the header levels
    - For example: `-1` would transform `# Header 1` to `<h2>Header 1</h2>`
- **External Links** Open In New Tab - Adds `target="_blank"` to external links

### Plug and Play

All existing and future properties using Umbraco.MarkdownEditor will automatically use the new editor.

Removing this package will revert to the default Umbraco.MarkdownEditor, **no data loss will occur**.

## Quick Start

```csharp
dotnet add package jcdcdev.Umbraco.ExtendedMarkdownEditor
```

## Contributing

Contributions to this package are most welcome! Please read
the [Contributing Guidelines](https://github.com/jcdcdev/jcdcdev.Umbraco.ExtendedMarkdownEditor/blob/main/.github/CONTRIBUTING.md).

## Acknowledgments (thanks!)

- LottePitcher - [opinionated-package-starter](https://github.com/LottePitcher/opinionated-package-starter)
- jcdcdev - [jcdcdev.Umbraco.PackageTemplate](https://github.com/jcdcdev/jcdcdev.Umbraco.PackageTemplate)