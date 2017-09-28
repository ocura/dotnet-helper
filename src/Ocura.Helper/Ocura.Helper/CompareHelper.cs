using System;
using System.Collections.Generic;
using System.Linq;

namespace Ocura.Helper
{
  public static class CompareHelper
  {
    /// <summary>
    ///   Check if the long value is in the specified long values.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="values">The values.</param>
    /// <returns></returns>
    public static bool In(this long value, IEnumerable<long> values)
    {
      return values.Contains(value);
    }

    /// <summary>
    ///   Check if the int value is in the specified int values.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="values">The values.</param>
    /// <returns></returns>
    public static bool In(this int value, IEnumerable<int> values)
    {
      return In(value, values.Select(Convert.ToInt64));
    }

    /// <summary>
    ///   Check if the int value is not in the specified int values.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="values">The values.</param>
    /// <returns></returns>
    public static bool NotIn(this long value, IEnumerable<long> values)
    {
      return !value.In(values);
    }
  }
}
