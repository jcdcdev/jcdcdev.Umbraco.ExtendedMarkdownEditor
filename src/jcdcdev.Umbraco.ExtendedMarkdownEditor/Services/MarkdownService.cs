using jcdcdev.Umbraco.ExtendedMarkdownEditor.Models;
using Markdig;
using Markdig.Renderers.Html;
using Markdig.Syntax;
using Markdig.Syntax.Inlines;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.Logging;
using Umbraco.Cms.Core.Strings;
using MarkdownExtensions = jcdcdev.Umbraco.ExtendedMarkdownEditor.Extensions.MarkdownExtensions;

namespace jcdcdev.Umbraco.ExtendedMarkdownEditor.Services;

internal class MarkdownService : IMarkdownService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly ILogger<MarkdownService> _logger;

    public MarkdownService(IHttpContextAccessor httpContextAccessor, ILogger<MarkdownService> logger)
    {
        _httpContextAccessor = httpContextAccessor;
        _logger = logger;
    }

    public MarkdownValue CreateFromMarkdownString(string markdown, MarkdownConvertorOptions? config = null)
    {
        if (!MarkdownExtensions.TryParse(markdown, out var markdownDocument))
        {
            _logger.LogWarning("Failed to parse markdown");
            return MarkdownValue.Empty;
        }

        if (config == null)
        {
            return MarkdownValue.Create(markdown, markdownDocument, ConvertToHtml(markdownDocument));
        }

        if (config.HeaderOffset.HasValue)
        {
            ApplyOffsetToHeaders(markdownDocument, config.HeaderOffset.Value);
        }

        if (config.TransformLinks)
        {
            var uri = _httpContextAccessor.HttpContext?.Request.GetDisplayUrl();
            if (uri == null)
            {
                _logger.LogWarning("Failed to get the current request URL");
            }
            else
            {
                var hostUri = new UriBuilder(uri)
                {
                    Path = string.Empty,
                    Query = string.Empty,
                    Fragment = string.Empty
                };

                TransformLinks(markdownDocument, config.ExternalLinksOpenInNewTab, hostUri.Uri);
            }
        }

        return MarkdownValue.Create(markdown, markdownDocument, ConvertToHtml(markdownDocument));
    }

    private HtmlEncodedString ConvertToHtml(MarkdownDocument document)
    {
        try
        {
            return new HtmlEncodedString(document.ToHtml());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error converting markdown to HTML");
            throw;
        }
    }

    private void TransformLinks(MarkdownObject markdown, bool externalLinksOpenInNewTab, Uri hostUri)
    {
        var links = markdown.Descendants<LinkInline>().Where(x => !x.IsImage).ToList();
        if (links.Count == 0)
        {
            return;
        }

        foreach (var link in links)
        {
            try
            {
                if (link.Url?.StartsWith("/") ?? false)
                {
                    continue;
                }

                if (!Uri.TryCreate(link.Url, UriKind.RelativeOrAbsolute, out var uri))
                {
                    continue;
                }

                if (uri.Host == string.Empty || uri.Host == hostUri.Host)
                {
                    continue;
                }

                if (externalLinksOpenInNewTab)
                {
                    link.GetAttributes().AddPropertyIfNotExist("target", "_blank");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error transforming link");
            }
        }
    }

    private static void ApplyOffsetToHeaders(MarkdownDocument markdown, int offset)
    {
        var headers = markdown.Descendants<HeadingBlock>();
        foreach (var header in headers)
        {
            var level = header.Level + offset;
            header.Level = Math.Clamp(level, 1, 6);
        }
    }
}
