using Markdig;
using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Westwind.AspNetCore.Markdown;

namespace PersonalCollectionManagement
{
    public static class Markdown
    {
        private static MarkdigMarkdownParserFactory markdownParserFactory = new MarkdigMarkdownParserFactory();
        public static string Parse(string markdown,
                        bool usePragmaLines = false,
                        bool forceReload = false)
        {
            if (string.IsNullOrEmpty(markdown))
                return "";
            var parser = markdownParserFactory.GetParser(usePragmaLines, forceReload);
            return parser.Parse(markdown).Normalize();
        }
        public static HtmlString ParseHtmlString(
                       string markdown,
                       bool usePragmaLines = false,
                       bool forceReload = false)
        {
            return new HtmlString(Parse(markdown,
                         usePragmaLines, forceReload));
        }
    }
}
