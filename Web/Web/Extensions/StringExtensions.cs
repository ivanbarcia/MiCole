using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Extensions
{
    public static class StringExtensions
    {
        public static string GetLast(this string source, int tailLength)
        {
            if (tailLength >= source.Length)
                return source;
            return source.Substring(source.Length - tailLength);
        }
    }
}