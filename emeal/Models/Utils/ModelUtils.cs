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

        internal static bool IsValid(this Recipe recipe)
        {
            return recipe != null && recipe.PathToImage.CheckUrlValid() && recipe.EstimatedTime > 0;
        }
    }
}