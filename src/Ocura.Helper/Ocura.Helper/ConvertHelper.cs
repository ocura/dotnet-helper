using System;
using System.Globalization;

namespace Ocura.Helper
{
  public static class ConvertHelper
  {
    /// <summary>
    ///   Converts the string representation of a number to an Int16.
    /// </summary>
    /// <param name="value">The value</param>
    /// <returns>The value converted in Int16</returns>
    public static short ToInt16(this string value)
    {
      return Convert.ToInt16(value);
    }

    /// <summary>
    ///   Converts the string representation of a number to an Int16.
    /// </summary>
    /// <param name="value">The value</param>
    /// <returns>The value converted in Int16</returns>
    public static short ToIntShort(this string value)
    {
      return ToInt16(value);
    }

    /// <summary>
    ///   Converts the string representation of a number to an Int32.
    /// </summary>
    /// <param name="value">The value</param>
    /// <returns>The value converted in Int32</returns>
    public static int ToInt32(this string value)
    {
      return Convert.ToInt32(value);
    }

    /// <summary>
    ///   Converts the string representation of a number to an Int32.
    /// </summary>
    /// <param name="value">The value</param>
    /// <returns>The value converted in Int32</returns>
    public static int ToInt(this string value)
    {
      return ToInt32(value);
    }

    /// <summary>
    ///   Converts the string representation of a number to an Int64.
    /// </summary>
    /// <param name="value">The value</param>
    /// <returns>The value converted in Int64</returns>
    public static long ToInt64(this string value)
    {
      return Convert.ToInt64(value);
    }

    /// <summary>
    ///   Converts the string representation of a number to an Int64.
    /// </summary>
    /// <param name="value">The value</param>
    /// <returns>The value converted in Int64</returns>
    public static long ToLong(this string value)
    {
      return ToInt64(value);
    }

    /// <summary>
    ///   Converts the string representation of a char to an char.
    /// </summary>
    /// <param name="value">The value</param>
    /// <returns>The value converted in chart</returns>
    public static char ToChar(this string value)
    {
      return Convert.ToChar(value);
    }

    /// <summary>
    ///   Converts the string representation of a DateTime to an DateTime.
    /// </summary>
    /// <param name="value">The value</param>
    /// <returns>The value converted in DateTime</returns>
    public static DateTime ToDateTime(this string value)
    {
      return Convert.ToDateTime(value);
    }

    /// <summary>
    ///   Converts the string representation of a DateTime to an DateTime based in a format.
    /// </summary>
    /// <param name="value">The value</param>
    /// <param name="format">The format</param>
    /// <returns>The value converted in DateTime</returns>
    public static DateTime ToDateTime(this string value, string format)
    {
      DateTime.TryParseExact(value, format, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out var date);
      return date;
    }
  }
}
