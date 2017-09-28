using System;

namespace Ocura.Helper
{
  public static class NullHelper
  {
    /// <summary>
    ///   Checks the null.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns></returns>
    public static long? CheckNull(this long? value)
    {
      return value == 0 ? null : value;
    }

    /// <summary>
    ///   Checks the null.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns></returns>
    public static DateTime? CheckNull(this DateTime? value)
    {
      return value == DateTime.MinValue ? null : value;
    }

    /// <summary>
    ///   Checks the null.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns></returns>
    public static DateTime? CheckNull(this DateTime? value, DateTime? defaultValue)
    {
      return value == null || value == DateTime.MinValue ? defaultValue : value;
    }
  }
}
