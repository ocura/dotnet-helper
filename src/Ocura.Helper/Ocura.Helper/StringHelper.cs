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
    ///   Remove diacritics and set to upper
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns></returns>
    public static string ToUpperNormalize(this string text)
    {
      return text?.ToUpper().Trim().RemoveDiacritics();
    }

    /// <summary>
    ///   Remove diacritics and set to lower
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns></returns>
    public static string ToLowerNormalize(this string text)
    {
      return text?.ToLower().Trim().RemoveDiacritics();
    }

    /// <summary>
    ///   Likes normalize.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <param name="searchValue">The search value.</param>
    /// <param name="normalize">if set to <c>true</c> [normalize string].</param>
    /// <returns></returns>
    public static bool Like(this string text, string searchValue, bool normalize = true)
    {
      return normalize
        ? (text?.ToUpperNormalize().Contains(searchValue?.ToUpperNormalize() ?? "") ?? false)
        : (text?.Contains(searchValue ?? "") ?? false);
    }

    /// <summary>
    ///   To title case.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns></returns>
    public static string ToTitleCase(this string text)
    {
      var textInfo = new CultureInfo("en-US", true).TextInfo;
      return textInfo.ToTitleCase(text);
    }

    /// <summary>
    ///   Pluralizes the specified count.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <param name="count">The count.</param>
    /// <param name="plural">The plural.</param>
    /// <returns></returns>
    public static string Pluralize(this string text, int count, string plural = null)
    {
      if (count < 2) return text;
      return string.IsNullOrEmpty(plural) ? text + "s" : plural;
    }

    /// <summary>
    ///   Adds a value before the string.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <param name="value">The value to be added.</param>
    /// <returns></returns>
    public static string AddBefore(this string text, string value)
    {
      return text != null ? value + text : "";
    }
  }
}
