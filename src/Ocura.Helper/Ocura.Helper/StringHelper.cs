using System.Globalization;
using System.Text;

namespace Ocura.Helper
{
  public static class StringHelper
  {
    /// <summary>
    ///   Removes the diacritics.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns></returns>
    public static string RemoveDiacritics(this string text)
    {
      var formD = text.Normalize(NormalizationForm.FormD);
      var sb = new StringBuilder();

      foreach (var ch in formD)
      {
        var uc = CharUnicodeInfo.GetUnicodeCategory(ch);
        if (uc != UnicodeCategory.NonSpacingMark)
          sb.Append(ch);
      }

      return sb.ToString().Normalize(NormalizationForm.FormC);
    }

    /// <summary>
    ///   Normalizes and clean.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns></returns>
    public static string NormalizeAndClean(this string text)
    {
      return text?.ToLower().Trim().RemoveDiacritics();
    }

    /// <summary>
    ///   Likes normalize.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <param name="searchValue">The search value.</param>
    /// <returns></returns>
    public static bool LikeNormalize(this string text, string searchValue)
    {
      return text?.NormalizeAndClean().Contains(searchValue?.NormalizeAndClean() ?? "") ?? false;
    }
  }
}
