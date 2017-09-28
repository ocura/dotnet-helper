using System;

namespace Ocura.Helper
{
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
  }
}
