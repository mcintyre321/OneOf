using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Extensions
{
    public static string Joined<T>(this IEnumerable<T> source, string delimiter, Func<T, string>? selector = null)
    {
        if (source == null)
        {
            return "";
        }

        if (selector == null)
        {
            return string.Join(delimiter, source);
        }

        return string.Join(delimiter, source.Select(selector));
    }

    public static string Joined<T>(this IEnumerable<T> source, string delimiter, Func<T, int, string> selector)
    {
        if (source == null)
        {
            return "";
        }

        return string.Join(delimiter, source.Select(selector));
    }

    public static IEnumerable<T> ExceptSingle<T>(this IEnumerable<T> source, T single) =>
        source.Except(Enumerable.Repeat(single, 1));

    public static void AppendLineTo(this string? s, StringBuilder sb) => sb.AppendLine(s);
}
