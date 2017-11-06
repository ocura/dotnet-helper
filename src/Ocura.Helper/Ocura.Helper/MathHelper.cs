using System;
using System.Drawing;

namespace Ocura.Helper
{
  /// <summary>
  /// Math Helper
  /// </summary>
  public static class MathHelper
  {
    /// <summary>
    ///   Rounds up.
    /// </summary>
    /// <param name="input">The input.</param>
    /// <param name="places">The places.</param>
    /// <returns></returns>
    public static decimal RoundUp(decimal input, int places)
    {
      var multiplier = Math.Pow(10, Convert.ToDouble(places));
      return Convert.ToDecimal(Math.Ceiling(Convert.ToDouble(input) * multiplier) / multiplier);
    }

    /// <summary>
    ///   Rounds up.
    /// </summary>
    /// <param name="input">The input.</param>
    /// <returns></returns>
    public static int RoundUp(this decimal input)
    {
      return Convert.ToInt32(RoundUp(input, 0));
    }

    /// <summary>
    ///   Variations the specified new value.
    /// </summary>
    /// <param name="newValue">The new value.</param>
    /// <param name="oldValue">The old value.</param>
    /// <returns></returns>
    public static decimal Variation(decimal newValue, decimal oldValue)
    {
      return oldValue == 0 || newValue == 0 ? 0 : newValue / oldValue - 1;
    }

    /// <summary>
    ///   Shares the specified partial value.
    /// </summary>
    /// <param name="partialValue">The partial value.</param>
    /// <param name="totalValue">The total value.</param>
    /// <returns></returns>
    public static decimal Share(decimal partialValue, decimal totalValue)
    {
      return totalValue == 0 ? 0 : partialValue / totalValue;
    }

    /// <summary>
    ///   Converts the color of to heat.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="low">The low.</param>
    /// <param name="high">The high.</param>
    /// <returns></returns>
    public static string ConvertToHeatColor(this long value, long low, long high)
    {
      decimal range = high - low;
      var alpha = range == 0 ? 0 : (value / range * 255).RoundUp();
      var color = Color.FromArgb(alpha, 255, 165, 0);
      return color.ToRGBString();
    }

    /// <summary>
    ///   Converts the color of to heat.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="low">The low.</param>
    /// <param name="high">The high.</param>
    /// <returns></returns>
    public static string ConvertToHeatColor(this int value, long low, long high)
    {
      return ConvertToHeatColor((long) value, low, high);
    }

    /// <summary>
    ///   Converts the color of to heat.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="low">The low.</param>
    /// <param name="high">The high.</param>
    /// <returns></returns>
    public static string ConvertToHeatColor(this short value, long low, long high)
    {
      return ConvertToHeatColor((long) value, low, high);
    }
  }
}
