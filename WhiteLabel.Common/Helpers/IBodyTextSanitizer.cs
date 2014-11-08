﻿using System.Globalization;

namespace WhiteLabel.Common.Helpers
{
    public interface IBodyTextSanitizer
    {
        string Sanitize(string bodyText);
        string Sanitize(string bodyText, CultureInfo locale);
        string RemovePositionAttribute(string bodyText);
        string CleanText(string text, CultureInfo locale);
        string CleanText(string text);
        string CleanHtml(string html, CultureInfo locale);
        string StripHtml(string html, CultureInfo locale);
    }
}
