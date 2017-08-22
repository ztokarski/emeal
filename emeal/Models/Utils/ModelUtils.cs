using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("emeal.Tests")]
namespace emeal.Models.Utils
{
    internal static class ModelUtils
    {
        internal static bool InRange(this int checkedInt, int rangeBottom, int rangeTop)
        {
            return checkedInt >= rangeBottom && checkedInt <= rangeTop;
        }

        internal static bool CheckUrlValid(this string source)
        {
            Uri uriResult;
            return Uri.TryCreate(source, UriKind.Absolute, out uriResult)
                   && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }
    }
}