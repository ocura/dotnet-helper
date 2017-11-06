using System.Collections.Generic;
using System.Linq;

namespace Ocura.Helper
{
  /// <summary>
  ///   DataMining Helper
  /// </summary>
  public static class DataMiningHelper
  {
    /// <summary>
    ///   Forecasts the specified y.
    ///   based on http://bit.ly/29k08nO
    /// </summary>
    /// <param name="y">The y.</param>
    /// <param name="ys">The ys.</param>
    /// <param name="xs">The xs.</param>
    /// <returns></returns>
    public static decimal Forecast(this decimal y, IEnumerable<decimal> ys, IEnumerable<decimal> xs)
    {
      var yAvg = ys.Sum() / ys.Count();
      var xAvg = xs.Sum() / xs.Count();

      var yxs = ys.CombineWith(xs);

      var b = yxs.Sum(yx => (yx.Item1 - yAvg) * (yx.Item2 - xAvg)) / yxs.Sum(yx => (yx.Item2 - xAvg) * (yx.Item2 - xAvg));
      var a = yAvg - b * xAvg;

      return a + y * b;
    }
  }
}
