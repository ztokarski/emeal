using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("emeal.Tests")]

namespace emeal.Models.Utils
{
    internal static class ModelUtils
    {
        // TODO: Use Strategy design pattern?
        internal static bool InRange(this int checkedInt, int rangeBottom, int rangeTop)
        {
            return checkedInt >= rangeBottom &&
                   checkedInt <= rangeTop;
        }

        internal static bool CheckUrlValid(this string source)
        {
            return Uri.TryCreate(source, UriKind.Absolute, out var uriResult) &&
                   (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        internal static bool IsValid(this Recipe recipe)
        {
            return recipe != null;
        }
    }
}