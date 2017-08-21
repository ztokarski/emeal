using System;

namespace emeal.Models.Utils
{
    internal static class ModelUtils
    {
        internal static bool InRange(this int checkedInt, int rangeBottom, int rangeTop)
        {
            return checkedInt >= rangeBottom && checkedInt <= rangeTop;
        }

        private static bool CheckUrlValid(this string source)
        {
            Uri uriResult;
            return Uri.TryCreate(source, UriKind.Absolute, out uriResult)
                   && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        private static bool IsDifficultyEnum(Enum checkedEnum)
        {
            return Enum.IsDefined(typeof(Difficulty), checkedEnum);
        }

        internal static bool IsRequestValid(this Recipe recipe)
        {
            return recipe.PathToImage.CheckUrlValid() && IsDifficultyEnum(recipe.DifficultyLevel);
        }
    }
}