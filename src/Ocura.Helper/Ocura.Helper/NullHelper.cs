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
    /// Checks the null.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns></returns>
    public static DateTime? CheckNull(this DateTime? value, DateTime? defaultValue = null)
    {
      return value == null || value == DateTime.MinValue ? defaultValue : value;
    }

    /// <summary>
    /// Determines whether this instance is null.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>
    ///   <c>true</c> if the specified value is null; otherwise, <c>false</c>.
    /// </returns>
    public static bool IsNull(this object value)
    {
      return value == null;
    }

    /// <summary>
    /// Determines whether this instance is not null.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>
    ///   <c>true</c> if [is not null] [the specified value]; otherwise, <c>false</c>.
    /// </returns>
    public static bool IsNotNull(this object value)
    {
      return !value.IsNull();
    }
  }
}
