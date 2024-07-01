# jcdcdev.Umbraco.ExtendedMarkdownEditor

[![Umbraco Marketplace](https://img.shields.io/badge/Umbraco-Marketplace-%233544B1?style=flat&logo=umbraco)](https://marketplace.umbraco.com/package/jcdcdev.umbraco.extendedmarkdowneditor)
[![GitHub License](https://img.shields.io/github/license/jcdcdev/jcdcdev.Umbraco.ExtendedMarkdownEditor?color=8AB803&label=License&logo=github)](https://github.com/jcdcdev/jcdcdev.Umbraco.ExtendedMarkdownEditor/blob/main/LICENSE)
[![NuGet Downloads](https://img.shields.io/nuget/dt/jcdcdev.Umbraco.ExtendedMarkdownEditor?color=cc9900&label=Downloads&logo=nuget)](https://www.nuget.org/packages/jcdcdev.Umbraco.ExtendedMarkdownEditor/)
[![Project Website](https://img.shields.io/badge/Project%20Website-jcdc.dev-jcdcdev?style=flat&color=3c4834&logo=data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIxNiIgaGVpZ2h0PSIxNiIgZmlsbD0id2hpdGUiIGNsYXNzPSJiaSBiaS1wYy1kaXNwbGF5IiB2aWV3Qm94PSIwIDAgMTYgMTYiPgogIDxwYXRoIGQ9Ik04IDFhMSAxIDAgMCAxIDEtMWg2YTEgMSAwIDAgMSAxIDF2MTRhMSAxIDAgMCAxLTEgMUg5YTEgMSAwIDAgMS0xLTF6bTEgMTMuNWEuNS41IDAgMSAwIDEgMCAuNS41IDAgMCAwLTEgMG0yIDBhLjUuNSAwIDEgMCAxIDAgLjUuNSAwIDAgMC0xIDBNOS41IDFhLjUuNSAwIDAgMCAwIDFoNWEuNS41IDAgMCAwIDAtMXpNOSAzLjVhLjUuNSAwIDAgMCAuNS41aDVhLjUuNSAwIDAgMCAwLTFoLTVhLjUuNSAwIDAgMC0uNS41TTEuNSAyQTEuNSAxLjUgMCAwIDAgMCAzLjV2N0ExLjUgMS41IDAgMCAwIDEuNSAxMkg2djJoLS41YS41LjUgMCAwIDAgMCAxSDd2LTRIMS41YS41LjUgMCAwIDEtLjUtLjV2LTdhLjUuNSAwIDAgMSAuNS0uNUg3VjJ6Ii8+Cjwvc3ZnPg==)](https://jcdc.dev/umbraco-packages/extended-markdown-editor)

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
